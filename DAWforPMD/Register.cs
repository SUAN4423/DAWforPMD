using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD {
  class Register {
    private static byte[,] _registers = new byte[2, 0x100];
    
    private static Action[,] _registerCallback = new Action[2, 0x100];
    public static byte[,] Registers => _registers;
    
    public static void Reset() {
      for (int i = 0; i < 0x100; i++) {
        _registers[0, i] = 0x00;
        _registers[1, i] = 0x00;
      }
    }

    private static Byte RegAddr = 0x00;

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

    public static void Write(byte value, bool A1) {
      // レジスタの値を書き換える
      _registers[A1 ? 1 : 0, RegAddr] = value;
      
      // コールバックが存在する場合は、呼び出す
      (_registerCallback[A1 ? 1 : 0, RegAddr])?.Invoke();
    }

    public static byte Read(bool A1) {
      return _registers[A1 ? 1 : 0, RegAddr];
    }
  }
}
