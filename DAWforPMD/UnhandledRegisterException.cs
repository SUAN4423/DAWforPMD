using System;

namespace DAWforPMD.YM2608 {
  public class UnhandledRegisterException : Exception {
    public UnhandledRegisterException() { }

    public UnhandledRegisterException(string message)
      : base(message) { }

    public UnhandledRegisterException(string message, Exception inner)
      : base(message, inner) { }

    
    public UnhandledRegisterException(byte regAddr) :
      base(string.Format("unhandled register address 0x%02X", regAddr)) { }
    public UnhandledRegisterException(byte regAddr, byte regValue) :
      base(string.Format("unhandled register address 0x%02X (<- value 0x%02X)", regAddr, regValue)) { }
  }
}
