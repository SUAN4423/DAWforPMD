using System;
using System.Collections;
using System.Collections.Generic;

namespace DAWforPMD.YM2608 {
  public class YM2608 {
    public static float MasterClock = 8.0f; //メインクロック (MHz)
    public static Byte  FMDivision  = 6;
    public static Byte  SSGDivision = 4;

    // クロックジェネレーター関連
    private const uint m_clock = 8000000;

    private double m_correction = 0;

    private const    uint sample_rate         = 44100;
    private readonly uint m_cycles_per_sample = m_clock / sample_rate;
    private readonly uint m_cycles_cor        = m_clock % sample_rate;

    // ティックジェネレーター関連
    private uint tick_clock_counter = 0;
    private uint tick_counter_correction = 0;

    private uint ticks_per_second;
    private uint clocks_per_tick;
    private uint clocks_per_tick_correction;

    private IChannel[] channels;

    private void processBuffer(ref float[] buffer) {
      for (var i = 0; i < buffer.Length; i++) {
        var val = .0f;

        // クロックのずれを補正する
        var c = m_cycles_per_sample;
        if (m_correction >= sample_rate) {
          m_correction = m_correction - sample_rate;
          c++;
        }

        // クロック毎の処理をする
        for (var j = 0; j < c; j++) {
          if (tick_counter_correction >= ticks_per_second) {
            tick_counter_correction = 0;
            tick_clock_counter++;
          }

          if (tick_clock_counter >= clocks_per_tick) {
            // シーケンサーを次のティックに進める

            // シーケンサーからイベントを取得し、それぞれのチャンネルに送る

            tick_clock_counter = 0;
            tick_counter_correction += clocks_per_tick_correction;
          }

          tick_clock_counter++;
        }

        // すべてのチャンネルのサイクルを進める

        // クロックを進める
        m_correction += m_cycles_cor * c;

        // 求めた結果を代入する
        buffer[i] = val;
      }
    }
  }
}
