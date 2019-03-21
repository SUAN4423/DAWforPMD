using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD
{
    class Calc
    {
        public static Byte CalcR(Byte R, Byte KS, Byte Block, Byte Note, Boolean isRR)
        {
            Byte Rout = 0;
            int tmp = 0;
            if (isRR)
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
                if (R == 0) Rout = 0;
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

        public static float ClacDT(Byte DT, Byte Block, Byte Note)
        {
            float DTout = Default.Detune[DT < 4 ? DT : DT - 4, Block * 4 + Note] * (DT < 4 ? 1 : -1);
            return DTout;
        }

        public static float ClacFreq(Byte ML, Byte DT, Byte Block, Byte Note)
        {
            return 0f;
        }

        public static Byte ClacHex(int bit) //10000101とかで入力、出力は0x85など。
        {
            Byte HEXout = 0;
            for(int i = 0; i < 8; i++)
            {
                HEXout += (Byte)(bit % 10 * (Byte)Math.Pow(2, i));
                bit /= 10;
            }
            return HEXout;
        }
    }
}
