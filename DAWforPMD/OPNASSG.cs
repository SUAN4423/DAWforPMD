/// <summary>
/// YM2608（OPNA）のSSG実装
/// </summary>

using System;
using DAWforPMD.STT;

namespace DAWforPMD.YM2608 {
  public class OPNASSG : IChannel {
    private bool KeyOnStatus = false;
    
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

    public void NextCycle() {
      throw new System.NotImplementedException();
    }

    public float GetSample() {
      return .0f;
    }
  }
}
