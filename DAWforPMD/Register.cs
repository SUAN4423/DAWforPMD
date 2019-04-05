using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD {
  class Register {
    enum RegisterAddress {
      /* PSG音源の設定 */
      REG_CH_A_FINE_TUNE = 0x00,
      REG_CH_A_COARSE_TUNE,

      REG_CH_B_FINE_TUNE,
      REG_CH_B_COARSE_TUNE,

      REG_CH_C_FINE_TUNE,
      REG_CH_C_COARSE_TUNE,

      //--
      REG_NOISE_TUNE,
      REG_NOISE_TONE_MIXING,

      //--
      REG_CH_A_AMPLITUDE,
      REG_CH_B_AMPLITUDE,
      REG_CH_C_AMPLITUDE,

      //--
      REG_ENV_PERIOD_FINE_TUNE,
      REG_ENV_PERIOD_COARSE_TUNE,
      REG_ENV_SHAPE,

      /* Atari規格のジョイスティックの入力 */
      REG_IO_PORT_A,
      REG_IO_PORT_B,

      /* リズム機能 */
      REG_DUMP_RHYTHM_KEY_ON,                // write-only, YM2608
      REG_RHYTHM_TONAL_LEVEL,                // write-only, YM2608
      REG_LSI_TEST,                          // write-only, YM2608
      REG_OUTPUT_SELECT_INST_LEVEL_0 = 0x18, // write-only, YM2608

      /* FM音源 */
      REG_TEST          = 0x21, // write-only
      REG_LFO           = 0x22, // write-only, YM2608
      REG_TIMER_A_UPPER = 0x24, // write-only
      REG_TIMER_A_LOWER,        // write-only
      REG_TIMER_B,              // write-only
      REG_TIMER_CTRL_CH3_MODE,  // write-only

      REG_KEY_ON_OFF_CTRL,    // write-only
      REG_KEY_IRQ_ENABLE_SCH, // write-only, YM2608

      REG_SET_PRESCALER  = 0x2D, // write-only
      REG_SET_THIRD      = 0x2E, // write-only
      REG_SET_HALF_COUNT = 0x2F, // write-only

      //--
      REG_DETUNE_MULTIPLE            = 0x30,
      REG_TOTAL_LEVEL                = 0x40, // write-only (~ 0x4E)
      REG_KEY_SCALE_ATTACK_RATE      = 0x50, // write-only (~ 0x5E)
      REG_DECAY_RATE_AMON            = 0x60, // write-only (~ 0x6E)
      REG_SUSTAIN_RATE               = 0x70, // write-only (~ 0x7E)
      REG_SUSTAIN_LEVEL_RELEASE_RATE = 0x80, // write-only (~ 0x8E)
      REG_SSG_TYPE_ENV_CTRL          = 0x90, // write-only (~ 0x90)
      REG_F_NUM_1                    = 0xA0, // write-only (~ 0xA2)
      REG_BLOCK_F_NUM_2              = 0xA4, // write-only (~ 0xA6)
      REG_3CH_F_NUM_1                = 0xA8, // write-only (~ 0xAA)
      REG_3CH_BLOCK_F_NUM_2          = 0xAC, // write-only (~ 0xAE)

      REG_SELF_FB_CONNECTION = 0xB0, // write-only (~ 0xB2)
      REG_PMS_AMS_LR         = 0xB4, // write-only (~ 0xB6, YM2608)

      //--
      REG_ID_NUM = 0xFF, // read-only (YM2608)
    };

    private static byte[,]   _registers = new byte[2, 0x100];
    private static Action[,] _registerCallback = new Action[2, 0x100];
    public static  byte[,]   Registers => _registers;

    public static void Reset() {
      for (int i = 0; i < 0x100; i++) {
        _registers[0, i] = 0x00;
        _registers[1, i] = 0x00;
      }
    }

    private static Byte RegAddr             = REGISTER_UNSELECTED;
    private const  Byte REGISTER_UNSELECTED = 0xFE; // おそらく使用しない位置なので

    /// <summary>
    /// 不正なアクセスをしたときに例外を投げるかどうかを指定します。
    /// </summary>
    public static bool WarnInvalidAccess = true;

    public static void Select(Byte address) {
      switch (address) {
      // 特殊レジスタには適当な値を書き込んでしまうことでコールバックを発生させる　
      case 0x2D:
      case 0x2E:
      case 0x2F:
        RegAddr = address;
        Write(0x00, false);
        break;
      default:
        RegAddr = address;
        break;
      }
    }

    public static void WriteBit(bool value, byte offset, bool A1) {
      if (offset >= 8)
        throw new IndexOutOfRangeException();

      var pos = (byte) (1 << offset);
      Write((byte) ((Read(A1) & ~pos) | (value ? pos : 0)), A1);
    }

    public static void ToggleBit(byte offset, bool A1) {
      if (offset >= 8)
        throw new IndexOutOfRangeException();

      Write((byte) (Read(A1) ^ (1 << offset)), A1);
    }

    public static void Write(byte value, bool A1) {
      // レジスタが未選択の場合は、なにもしない
      if (RegAddr != REGISTER_UNSELECTED) {
        return;
      }

      // レジスタの値を書き換える
      _registers[A1 ? 1 : 0, RegAddr] = value;

      // コールバックが存在する場合は、呼び出す
      (_registerCallback[A1 ? 1 : 0, RegAddr])?.Invoke();

      // レジスタを未選択状態にする
      RegAddr = REGISTER_UNSELECTED;
    }

    public static byte Read(bool A1) {
      // 書き込み専用レジスタの場合に例外を発生させる
      // （吐き出される.SSTイベントに正しく対応できてるかデバッグするために欲しい）
      if (((byte) RegisterAddress.REG_DUMP_RHYTHM_KEY_ON <= RegAddr) && (RegAddr != 0xFF)) {
        throw new ReadOnlyException(string.Format("register 0x%02X is read-only", RegAddr));
      }
      
      // 読み出しの際は、レジスタ未選択状態でエラーになるようにする
      if (RegAddr != REGISTER_UNSELECTED) {
        throw new Exception("register is not selected");
      }

      return _registers[A1 ? 1 : 0, RegAddr];
    }
  }
}
