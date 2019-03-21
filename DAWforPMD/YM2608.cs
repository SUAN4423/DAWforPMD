using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD
{
    class YM2608 : Register
    {
        public static float MasterClock = 8.0f; //メインクロック (MHz)
        public static Byte FMDivision = 6;
        public static Byte SSGDivision = 4;
    }
}
