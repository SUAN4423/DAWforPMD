using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD
{
    class Register
    {
        protected static Byte[] Regista = new byte[0x100];

        public static void RegistaReset()
        {
            for(int i = 0; i < 0x100; i++)
            {
                Regista[i] = 0x00b;
            }
        }

        private static Byte SelectedRegNum = 0x00;

        public static void SelectRegsta(Byte REG)
        {
            switch(REG)
            {
                case 0x2D:
                    {
                        break;
                    }
                case 0x2E:
                    {
                        break;
                    }
                case 0x2F:
                    {
                        break;
                    }
                default:
                    {
                        SelectedRegNum = REG;
                        break;
                    }
            }
        }

        public static void Write(Byte DATA)
        {
            Regista[SelectedRegNum] = DATA;
        }

        public static Byte Read()
        {
            return Regista[SelectedRegNum];
        }
    }
}
