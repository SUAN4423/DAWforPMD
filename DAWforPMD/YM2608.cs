using System;
using System.Collections;
using System.Collections.Generic;

namespace DAWforPMD.YM2608 {
  class YM2608 {
    public static float MasterClock = 8.0f; //メインクロック (MHz)
    public static Byte FMDivision = 6;
    public static Byte SSGDivision = 4;

    private const uint m_clock = 8000000;

    private double m_correction = 0;

    private const uint sample_rate = 44100;
    private readonly uint m_cycles_per_sample = m_clock / sample_rate;
    private readonly uint m_cycles_cor = m_clock % sample_rate;

    public IChannel[] channels;
    private Stack<OPNAEvent>[] m_events_sorted;
    private readonly uint m_ticks = 480;

    private void generateSample(ref float[] buffer) {
      for (var i = 0; i < buffer.Length; i++) {
        var val = .0f;

        // クロックのずれを補正する
        var c = m_cycles_per_sample;
        if (m_correction >= sample_rate) {
          m_correction = m_correction - sample_rate;
          c++;
        }

        for (var i = 0; i < channels.Length; i++) {
          var ch        = channels[i];
          var nextEvent = m_events_sorted.Peek();

          // クロックのサイクルを回す
          for (uint j = 0; j < c; j++) {
            
            ch.nextCycle();
          }

          // チャンネルの標本を取る
          val = val + ch.getSample();
        }

        buffer[i] = val;

        // クロックを進める
        m_correction += m_cycles_cor * c;
      }
    }
  }
}
