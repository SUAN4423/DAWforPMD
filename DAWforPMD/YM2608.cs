using System;
using System.Collections.Generic;

namespace DAWforPMD.YM2608 {
  class YM2608 {
    public static float MasterClock = 8.0f; //メインクロック (MHz)
    public static Byte FMDivision = 6;
    public static Byte SSGDivision = 4;

    public List<IChannel> channels;

    private const uint m_clock = 8000000;
    private uint m_counter = 0;

    private double m_correction = 0;

    private const uint sample_rate = 44100;
    private readonly uint m_cycles_per_sample = m_clock / sample_rate;
    private readonly uint m_cycles_cor = m_clock % sample_rate;

    private void generateSample(ref float[] buffer) {
      for (var i = 0; i < buffer.Length; i++) {
        var val = .0f;

        // クロックのずれを補正する
        var c = m_cycles_per_sample;
        if (m_correction >= sample_rate) {
          m_correction = m_correction - sample_rate;
          c++;
        }

        foreach (var a in channels) {
          // クロックのサイクルを回す
          for (uint j = 0; j < c; j++)
            a.nextCycle(m_counter + j);

          // チャンネルの標本を取る
          val = val + a.getSample();
        }

        buffer[i] = val;

        // クロックを進める
        m_counter += c;
        m_correction += m_cycles_cor * c;
      }
    }
  }
}
