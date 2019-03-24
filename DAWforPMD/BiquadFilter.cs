// http://www.musicdsp.org/files/Audio-EQ-Cookbook.txt を参考のこと

using System;

namespace DAWforPMD {
  public abstract class BiquadFilter {
    protected        double a0, a1, a2, b0, b1, b2;
    private readonly double samplingFreq;
    protected        double w0, alpha;
    private          double q;
    private          double x_2, x_1;
    private          double y_2, y_1;

    protected BiquadFilter(uint samplingFreq) {
      this.samplingFreq = samplingFreq;
    }

    // 係数を計算
    protected virtual void CalcCoefficient() { }

    public void SetPeakFrequency(float freq) {
      w0    = 2 * Math.PI * freq / samplingFreq;
      alpha = Math.Sin(w0)       / (2.0 * q);
      CalcCoefficient();
    }

    public void SetQ(float q) {
      this.q = q;
      alpha  = Math.Sin(w0) / (2.0 * q);
      CalcCoefficient();
    }

    public void ProcessSample(ref float[] fbuf) {
      for (var i = 0; i < fbuf.Length; i++) {
        // 入力をディレイさせるためにとっておく
        var xtmp = fbuf[i];

        // 親の顔より見た双二次フィルタ
        fbuf[i] = (float) ((b0   / a0) * xtmp
                           + (b1 / a0) * x_1 + (b2 / a0) * x_2
                           - (a1 / a0) * y_1 - (a2 / a0) * y_2);

        // 信号をディレイさせる
        y_2 = y_1;
        y_1 = fbuf[i];
        x_2 = x_1;
        x_1 = xtmp;
      }
    }
  }

  public class LowpassFilter : BiquadFilter {
    public LowpassFilter(uint samplingFreq) : base(samplingFreq) { }

    protected override void CalcCoefficient() {
      b0 = (1 - Math.Cos(w0)) / 2;
      b1 = 1 - Math.Cos(w0);
      b2 = (1 - Math.Cos(w0)) / 2;
      a0 = 1 + alpha;
      a1 = -2 * Math.Cos(w0);
      a2 = 1 - alpha;
    }
  }

  public class HighpassFilter : BiquadFilter {
    public HighpassFilter(uint samplingFreq) : base(samplingFreq) { }

    protected override void CalcCoefficient() {
      b0 = (1 + Math.Cos(w0)) / 2;
      b1 = -1 - Math.Cos(w0);
      b2 = (1 + Math.Cos(w0)) / 2;
      a0 = 1 + alpha;
      a1 = -2 * Math.Cos(w0);
      a2 = 1 - alpha;
    }
  }

  public class PeakFilter : BiquadFilter {
    private double _a = 0;

    public PeakFilter(uint samplingFreq) : base(samplingFreq) { }

    public void SetAmplitude(double a) => this._a = a;

    protected override void CalcCoefficient() {
      b0 = 1 + alpha * _a;
      b1 = -2 * Math.Cos(w0);
      b2 = 1 - alpha * _a;
      a0 = 1 + alpha / _a;
      a1 = -2 * Math.Cos(w0);
      a2 = 1 - alpha / _a;
    }
  }
}
