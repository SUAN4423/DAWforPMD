using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD
{
    class Register
    {
        protected static Byte[,] Regista = new byte[2,0x100];

        public static void RegistaReset()
        {
            for(int i = 0; i < 0x100; i++)
            {
                Regista[0, i] = 0x00;
                Regista[1, i] = 0x00;
            }
        }

        private static Byte SelectedRegNum = 0x00;

        public static void SelectRegsta(Byte REG)
        {
            switch(REG)
            {
                case 0x2D:
                    {
                        YM2608.MasterClock = 8.0f;
                        YM2608.FMDivision = 6;
                        YM2608.SSGDivision = 4;
                        break;
                    }
                case 0x2E:
                    {
                        YM2608.MasterClock = 4.0f;
                        YM2608.FMDivision = 3;
                        YM2608.SSGDivision = 2;
                        break;
                    }
                case 0x2F:
                    {
                        YM2608.MasterClock = 2.67f;
                        YM2608.FMDivision = 2;
                        YM2608.SSGDivision = 1;
                        break;
                    }
                default:
                    {
                        SelectedRegNum = REG;
                        break;
                    }
            }
        }

        public static void WriteBit(Boolean DATA, Byte Offset, Boolean A1)
        {
            if (Offset >= 8) return;
            uint DATAtemp = Read(A1);
            if(DATA)
            {
                if (((DATAtemp >> (int)Offset) & 0x01) == 0x01) ;
                else DATAtemp += (uint)0x01 << (int)Offset;
            }
            else
            {
                if (((DATAtemp >> (int)Offset) & 0x01) == 0x00) ;
                else DATAtemp -= (uint)0x01 << (int)Offset;
            }
            Write((Byte)DATAtemp, A1);
        }

        public static void Write(Byte DATA, Boolean A1)
        {
            Regista[A1 ? 1 : 0, SelectedRegNum] = DATA;
        }

        public static Byte Read(Boolean A1)
        {
            return Regista[A1 ? 1 : 0, SelectedRegNum];
        }
    }
}
