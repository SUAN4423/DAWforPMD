using System;
using DAWforPMD.STT;

namespace DAWforPMD.YM2608 {
  public class RhythmChannel : IChannel, IRegisterHandler {
    private static string[]  _samplesPath;
    private static float[][] _samples;

    private int[]   _sampleCounter = new int[(int) RhythmType._ItemCount];
    private float   _totalVolume   = 1.0f;
    private float[] _instVolume    = new float[(int) RhythmType._ItemCount];

    public enum RhythmType {
      Bass = 0x00,
      Snare,
      RimShot,
      HiHat,
      Tom,
      TopCymbal,

      _ItemCount,
    };

    private enum _RhythmRegMapping {
      RREG_DUMP_RKON   = 0x10,
      RREG_TOTAL_LEVEL = 0x11,
      RREG_BASS_DRUM   = 0x18,
      RREG_SNARE_DRUM  = 0x19,
      RREG_RIMSHOT     = 0x1D,
      RREG_HI_HAT      = 0x1B,
      RREG_TOM         = 0x1C,
      RREG_TOP_CYMBAL  = 0x1A,
    };

    static void LoadSample(string[] samplesPath) {
      _samplesPath = samplesPath; // サンプルのリストを読み込む

      // TODO サンプルの読み込み
    }

    //
    public RhythmChannel() {
      // パート毎の音量を初期化する
      for (int i = 0; i < _instVolume.Length; i++) {
        _instVolume[i] = 1.0f;
      }
    }

    public void HandleRegister(byte regAddr, byte regValue) {
      const double r = 0.75 / 20.0;
      var          v = (float) Math.Pow(10, r * (~regValue & 0x1F));

      switch ((_RhythmRegMapping) regAddr) {
      case _RhythmRegMapping.RREG_DUMP_RKON:
        // キーオンオフ
        var keyFlags = regValue & 0x3F;

        if ((regValue & 0x80) != 0) {
          // キーオフ（DUMP）
          for (int i = 0; keyFlags != 0; i++) {
            if ((keyFlags & 0x01) != 0) {
              // フラグがオンならサンプル位置を-1にする（停止）
              _sampleCounter[i] = -1;
            }

            keyFlags >>= 1;
          }
        } else {
          // キーオン
          for (int i = 0; keyFlags != 0; i++) {
            if ((keyFlags & 0x01) != 0) {
              // フラグがオンならサンプル位置を0にする（開始位置）
              _sampleCounter[i] = 0;
            }

            keyFlags >>= 1;
          }
        }

        break;
      case _RhythmRegMapping.RREG_TOTAL_LEVEL:
        _totalVolume = (float) Math.Pow(10, r * (~regValue & 0x3F));
        break;
      // ココス＝ゴーイバカ（1640-2018）
      case _RhythmRegMapping.RREG_BASS_DRUM:
        _instVolume[(int) RhythmType.Bass] = v;
        break;
      case _RhythmRegMapping.RREG_SNARE_DRUM:
        _instVolume[(int) RhythmType.Snare] = v;
        break;
      case _RhythmRegMapping.RREG_RIMSHOT:
        _instVolume[(int) RhythmType.RimShot] = v;
        break;
      case _RhythmRegMapping.RREG_HI_HAT:
        _instVolume[(int) RhythmType.HiHat] = v;
        break;
      case _RhythmRegMapping.RREG_TOM:
        _instVolume[(int) RhythmType.Tom] = v;
        break;
      case _RhythmRegMapping.RREG_TOP_CYMBAL:
        _instVolume[(int) RhythmType.TopCymbal] = v;
        break;
      default:
        throw new UnhandledRegisterException(regAddr, regValue);
      }
    }

    public void PushEvent(SSTTrackEvent anEvent) {
      throw new NotImplementedException();
    }

    public void NextCycle() {
      // サンプル送りはGetSample()で行う（どうせ1サンプルにつき一回しか呼び出されないと思うので）
    }

    public float GetSample() {
      double summingResult = 0;

      // それぞれの楽器について加算する
      for (int i = 0; i < _sampleCounter.Length; i++) {
        if (_sampleCounter[i] != -1) {
          // キーオン状態
          summingResult = summingResult
                          + _samples[i][_sampleCounter[i]] * _instVolume[i];

          ++_sampleCounter[i];

          if (_samples[i].Length <= _sampleCounter[i]) {
            // サンプル数を超えたら自動的に停止
            _sampleCounter[i] = -1;
          }
        }
      }

      return (float) (summingResult * _totalVolume);
    }
  }
}
