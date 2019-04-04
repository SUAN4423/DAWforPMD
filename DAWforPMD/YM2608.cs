using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Threading.Tasks;
using DAWforPMD.STT;

namespace DAWforPMD.YM2608 {
  public class YM2608 {
    public static float MasterClock = 8.0f; //メインクロック (MHz)
    public static Byte  FMDivision  = 6;
    public static Byte  SSGDivision = 4;

    // クロックジェネレーター関連
    private const uint   clock_frequency  = 8000000;
    private       double clock_correction = 0;

    private const uint SampleFreq           = 44100;
    private const uint CyclesPerSample      = clock_frequency / SampleFreq;
    private const uint CycleCorrectionValue = clock_frequency % SampleFreq;

    // ティックジェネレーター関連
    private uint TickGen_ClockCounter      = 0;
    private uint TickGen_CounterCorrection = 0;

    private uint TicksPerSecond;
    private uint ClocksPerTick;
    private uint ClocksPerTickCorrectionValue;

    private IChannel[]  Channels;
    private SSTSequence Sequence;

    private LowpassFilter lpf;

    public YM2608() {
      // ローパスフィルタの初期化 
      lpf = new LowpassFilter(SampleFreq);
      lpf.SetPeakFrequency(20000); // 20kHz

      Channels = new IChannel[10]; // 6 FM, 3 SSG, 1 rhythm

      // FMは6チャンネル
      for (var i = 0; i < 6; i++) {
        Channels[i] = new FMChannel(i);
      }

      // SSGは3チャンネル
      for (var i = 0; i < 4; i++) {
        Channels[i + 6] = new OPNASSG();
      }

      // TODO リズムチャンネルの生成
    }

    public void LoadSequence(SSTSequence sequence) => this.Sequence = sequence;

    private void TickGenNextCycle() {
      // ティック補正値の計算
      if (TickGen_CounterCorrection >= TicksPerSecond) {
        TickGen_CounterCorrection = TickGen_CounterCorrection - TicksPerSecond;
        TickGen_ClockCounter++;
      }

      if (TickGen_ClockCounter >= ClocksPerTick) {
        // シーケンサーを次のティックに進める
        Sequence.NextTick();
        // シーケンサーからイベントを取得し、それぞれのチャンネルに送る
        for (uint k = 0; k < Channels.Length; k++) {
          SSTTrackEvent evt;
          while ((evt = Sequence.NextEvent(k)) != null) {
            Channels[k].PushEvent(evt);
          }
        }

        TickGen_ClockCounter = 0;
        TickGen_CounterCorrection += ClocksPerTickCorrectionValue;
      }

      TickGen_ClockCounter++;
    }

    private void ProcessBuffer(ref float[] buffer) {
      // 与えられたバッファの分だけ信号を処理
      for (var i = 0; i < buffer.Length; i++) {
        var val = .0f;

        // クロックのずれを補正する
        var c = CyclesPerSample;
        if (clock_correction >= SampleFreq) {
          clock_correction = clock_correction - SampleFreq;
          c++;
        }

        // ティックジェネレーターの処理
        for (var j = 0; j < c; j++) {
          TickGenNextCycle();
        }

        // すべてのチャンネルのサイクルを進めて、その結果をサミングする
        // （フィルター処理はしない）
        object lockObject = new object();
        Parallel.For(0, Channels.Length, k => {
          for (var j = 0; j < c; j++) {
            Channels[k].NextCycle();
          }

          lock (lockObject) {
            val = val + Channels[k].GetSample();
          }
        });

        // クロックを進める
        // （正確には補正値の値を追加する）
        clock_correction += CycleCorrectionValue * c;

        // 求めた結果を代入する
        buffer[i] = val;
      }

      // ローパスフィルターに通す
      lpf.ProcessSample(ref buffer);
    }
  }
}
