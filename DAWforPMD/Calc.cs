using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD
{
    class Calc
    {
        public static Byte CalcR(Byte R, Byte KS, Byte Block, Byte Note, String RName)
        {
            Byte Rout = 0;
            int tmp = 0;
            if (RName.Equals("RR"))
            {
                tmp = 2 * (2 * R + 1) + Default.KeyScale[KS,Block*4+Note];
                if (tmp > 63) tmp = 63;
                Rout = (Byte)tmp;
            }
            else
            {
                tmp = 2 * R + Default.KeyScale[KS, Block * 4 + Note];
                if (tmp > 63) tmp = 63;
                Rout = (Byte)tmp;
            }
            return Rout;
        }
        
        public static Byte ClacSL(Byte SL)
        {
            Byte SLout = 0;
            int tmp = (SL & 0x01) * 3 + (SL & 0x02) * 6 + (SL & 0x04) * 12 + (SL & 0x08) * 24;
            if (SL == 0x0F) tmp = 93;
            SLout = (Byte)tmp;
            return SLout;
        }

        public static float ClacML(Byte ML)
        {
            if (ML == 0) return 0.5f;
            else return ML;
        }
    }
}
