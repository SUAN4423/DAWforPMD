﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAWforPMD.STT;

namespace DAWforPMD.YM2608
{
    class FMChannel : IChannel
    {
        private float sample = 0.0f;
        private UInt32 counter = 0x00000000;
        private Byte ChannelNumber = 0x00;
        private const Byte N = 21;
        private Byte startreadRegister = 0x00;
        private UInt16 FNumber = 0x0000;
        private Byte Block = 0x00;
        private Boolean[] KeyON = new Boolean[4] { false, false, false, false };
        private Byte KeyONReg = 0x00;

        public FMChannel(int CHnum)
        {
            this.ChannelNumber = (Byte)CHnum;
        }

        public float GetSample()
        {
            throw new NotImplementedException();
        }

        public void NextCycle()
        {
            Register.Select((Byte)(0xA0 + (this.ChannelNumber % 3)));
            FNumber = Register.Read(this.ChannelNumber >= 3);
            Register.Select((Byte)(0xA4 + (this.ChannelNumber % 3)));
            Block = Register.Read(this.ChannelNumber >= 3);
            FNumber += (UInt16)((UInt16)(Block & 0b00000111) << 8);
            Block = (Byte)((Byte)(Block & 0b00111000) >> 3);

            Register.Select(0x26);
            KeyONReg = Register.Read(this.ChannelNumber >= 3);
            if ((KeyONReg & 0b00000111) == Default.SelectChannel_KeyONOFF[this.ChannelNumber])
            {
                for (int i = 0; i < 4; i++) this.KeyON[i] = ((this.KeyONReg >> (4 + i)) & 0b01) == 0b1;
            }

            Register.Select(0x29);
            if (this.ChannelNumber < 3 || Register.Read(false) >> 7 == 0b00000001 ? true : false)
            {

            }

            //カウンタ計算
            this.counter += (UInt32)((1.0 / 9.0) * Math.Pow(2, Block + N - 15) * FNumber);
            if (this.counter >= (UInt32)1024 << N) this.counter -= (UInt32)1024 << N;
            //throw new NotImplementedException();
        }

        public void PushEvent(SSTTrackEvent anEvent)
        {
            throw new NotImplementedException();
        }
    }
}