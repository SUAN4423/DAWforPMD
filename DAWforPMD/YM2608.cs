using System;
using System.Collections;
using System.Collections.Generic;

namespace DAWforPMD.YM2608 {
  public class YM2608 {
    public static float MasterClock = 8.0f; //メインクロック (MHz)
    public static Byte  FMDivision  = 6;
    public static Byte  SSGDivision = 4;

    private const uint m_clock = 8000000;

    private double m_correction = 0;

    private const    uint sample_rate         = 44100;
    private readonly uint m_cycles_per_sample = m_clock / sample_rate;
    private readonly uint m_cycles_cor        = m_clock % sample_rate;

    private IChannel[] channels;

    private void generateSample(ref float[] buffer) {
      for (var i = 0; i < buffer.Length; i++) {
        var val = .0f;

        // クロックのずれを補正する
        var c = m_cycles_per_sample;
        if (m_correction >= sample_rate) {
          m_correction = m_correction - sample_rate;
          c++;
        }

        // クロックを進める
        m_correction += m_cycles_cor * c;
      }
    }
  }

  private class TickGenerator {
    
  }

}
