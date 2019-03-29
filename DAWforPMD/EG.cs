using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD.YM2608.FM
{
    class EG
    {
        Byte AR;
        Byte DR;
        Byte SR;
        Byte RR;
        Byte SL;
        Byte TL;
        Byte KS;

        EVState state = EVState.RR;

        enum EVState
        {
            AR, DR, SR, RR
        };

        void setParameter(Byte AR, Byte DR, Byte SR, Byte RR, Byte SL, Byte TL, Byte KS)
        {
            this.AR = Calc.CalcR(AR, KS);
            this.DR = DR;
            this.SR = SR;
            this.RR = RR;
            this.SL = SL;
            this.TL = TL;
            this.KS = KS;
        }

        float Envelope()
        {
            switch(state)
            {
                case EVState.AR:
                    {
                        break;
                    }
                case EVState.DR:
                    {
                        break;
                    }
                case EVState.SR:
                    {
                        break;
                    }
                case EVState.RR:
                    {
                        break;
                    }
            }
            return 0.0f;
        }
    }
}
