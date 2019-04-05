namespace DAWforPMD.YM2608 {
  public interface IRegisterHandler {
    void HandleRegister(byte regAddr, byte regValue);
  }
}
