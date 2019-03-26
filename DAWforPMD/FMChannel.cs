using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD {
  // audio traits
  class OPNAOutputTraits { }

  // FM channel
  class FMChannel {
  }

  // FM operator
  class Operator {
    private bool m_mute            = false;

    private uint m_fnum            = 0;
    private byte m_detuneValue     = 0;
    private byte m_multiple        = 0;
    private byte m_total_level     = 0;

    private uint m_phase_counter   = 0;
    private uint m_detune_counter  = 0;

    private EnvelopeState m_state  = EnvelopeState.ENV_OFF;

    private enum EnvelopeState {
      ENV_ATTACK,
      ENV_DECAY,
      ENV_SUSTAIN,
      ENV_RELEASE,
      ENV_OFF,
    }

    private byte m_key_scale       = 0;
    private byte m_attack_rate     = 0;
    private byte m_decay_rate      = 0;
    private byte m_am_on           = 0;
    private byte m_sustain_rate    = 0;
    private byte m_sustain_level   = 0;
    private byte m_release_rate    = 0;
    private byte m_ssg__env_ctrl   = 0;

    private float m_envelope       = .0f;

    private float m_fb_intensity = .0f;

    public Operator() { }

    public float NextPG() {
      return .0f;
    }
    
    public float NextEG() {
      return .0f;
    }

    public float NextFeedback() {
      return .0f;
    }

    float m_feedbackValue = .0f;
    private void PushSample(float fv) {
      // use simple filter to avoid aliasing noise
      m_feedbackValue = m_feedbackValue * .6f + fv * .4f;
    }

    public float NextSample() {
      // if muted, skip
      if (m_mute)
        return .0f;

      // calculate the next sample
      float omega = .0f;
      float f     = NextEG() * (float) Math.Sin(omega * NextPG() + m_fb_intensity * NextFeedback());

      // push a sample for feedback
      PushSample(f);

      return f;
    }
  }
}
