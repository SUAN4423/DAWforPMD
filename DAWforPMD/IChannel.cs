using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAWforPMD.STT;

namespace DAWforPMD.YM2608 {
  interface IChannel {
    void  PushEvent(SSTTrackEvent anEvent);
    void  NextCycle();
    float GetSample();
  }
}
