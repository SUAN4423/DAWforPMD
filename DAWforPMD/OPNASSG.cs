/// <summary>
/// YM2608（OPNA）のSSG実装
/// </summary>

using System;
using DAWforPMD.STT;

namespace DAWforPMD.YM2608 {

  public class OPNASSG : IChannel, IRegisterHandler {
    private bool  KeyOnStatus  = false;
    private uint  CycleCounter = 0;
    private uint  T_2          = 8000;
    private bool  Signal       = true;
    private float Volume       = .0f;

    public void PushEvent(SSTTrackEvent anEvent) {
      switch (anEvent.EventType) {
      case SSTEventType.Ch_KeyOn:
        KeyOnStatus = true;
        break;
      case SSTEventType.Ch_KeyOff:
        KeyOnStatus = false;
        break;
      case SSTEventType.Ch_Control:
        break;
      case SSTEventType.Ch_Kill:
        break;
      case SSTEventType.Ch_Reset:
        break;
      case SSTEventType.Tr_Kill:
        break;
      default:
        throw new ArgumentOutOfRangeException();
      }
    }

    public void HandleRegister(byte regAddr, byte regValue) {
      switch (regAddr) {
      default:
        throw new UnhandledRegisterException(regAddr, regValue);
      }
    }

    public void NextCycle() {
      if (CycleCounter >= T_2) {
        Signal       = !Signal;
        CycleCounter = 0;
      }

      CycleCounter++;
    }

    public float GetSample() {
      return Volume * (Signal ? 1 : -1);
    }
  }
}
