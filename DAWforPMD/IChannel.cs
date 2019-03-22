using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD.YM2608 {
  interface IChannel {
    void nextCycle(uint counter);
    float getSample();
  }
}
