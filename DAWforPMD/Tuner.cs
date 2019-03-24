using System;

namespace DAWforPMD.Tuner {
  public enum TuningType {
    EQUAL_TEMPERAMENT,    // 平均律
    MEANTONE_TEMPERAMENT, // 中全音律
    JUST_INTONATION,      // 純正律
    PYTHAGOREAN_TUNING,   // ピタゴラス音律
    CUSTOM,               // カスタム
  }

  public interface ITuningStrategy {
    bool IsOctaveIndependent();

    double NoteNumberToFrequency(int noteNumber, double baseFrequency);
  }

  // 平均律
  public class EqualTemperament : ITuningStrategy {
    // 1オクターブで周波数が2倍になるよ
    public bool IsOctaveIndependent() {
      return true;
    }

    public double NoteNumberToFrequency(int noteNumber, double baseFrequency) {
      // 69で A3 (baseFrequency) だから...
      return baseFrequency * Math.Pow(2.0, (noteNumber - 69) / 12.0);
    }
  }

  // ピタゴラス音律
  public class PythagoreanTuning : ITuningStrategy {
    private static readonly double[] MultipleTable = {
                                                       1.0,            // C
                                                       256.0  / 243.0, // C#
                                                       9.0    / 8.0,   // D
                                                       32.0   / 27.0,  // D#
                                                       81.0   / 64.0,  // E
                                                       4.0    / 3.0,   // F
                                                       759.0  / 512.0, // F#
                                                       3.0    / 2.0,   // G
                                                       128.0  / 81.0,  // G#
                                                       27.0   / 16.0,  // A
                                                       1024.0 / 729.0, // A#
                                                       243.0  / 128.0  // B
                                                     };

    public bool IsOctaveIndependent() {
      return true;
    }

    public double NoteNumberToFrequency(int noteNumber, double baseFrequency) {
      // 69のA3 (baseFrequency)を基準として考える
      var num = noteNumber - 69;
      var key = num % 12;
      var oct = num / 12;
      return baseFrequency * MultipleTable[key] * Math.Pow(2.0, oct);
    }
  }

  public class Tuner {
    private TuningType      type           = TuningType.EQUAL_TEMPERAMENT;
    private bool            isYamahaMode   = true;
    private double          baseFrequceny  = 442.0;
    private int             transposeValue = 0;
    private ITuningStrategy tuningStrategy = null;
    public  TuningType      TuningType        => type;
    public  bool            OctaveIndependent => tuningStrategy.IsOctaveIndependent();

    public Tuner(TuningType tuningType = TuningType.EQUAL_TEMPERAMENT) {
      SetTuning(tuningType);
    }

    public static Tuner New<T>() where T : ITuningStrategy, new() {
      var tuner = new Tuner();
      tuner.SetTuning<T>();
      return tuner;
    }

    public void SetTuning(TuningType tuningType) {
      type = tuningType;
      switch (type) {
      case TuningType.EQUAL_TEMPERAMENT:
        tuningStrategy = new EqualTemperament();
        break;
      case TuningType.PYTHAGOREAN_TUNING:
        tuningStrategy = new PythagoreanTuning();
        break;
      case TuningType.MEANTONE_TEMPERAMENT:
        throw new System.NotImplementedException();
        break;
      case TuningType.JUST_INTONATION:
        throw new System.NotImplementedException();
        break;

      default:
        tuningStrategy = null;
        break;
      }
    }

    public void SetCustomTuning(ITuningStrategy tuning) {
      tuningStrategy = tuning;
    }

    public void SetTuning<T>() where T : ITuningStrategy, new() {
      tuningStrategy = new T();
    }

    public void SetBaseFrequency(double baseFrequency,
                                 string baseNoteName = "A",
                                 bool   isYamaha     = true) {
      this.baseFrequceny = baseFrequency;
      this.isYamahaMode  = isYamaha;
    }

    public void Transpose(int value) {
      transposeValue = value;
    }

    public double NoteNumberToFrequency(int noteNumber) {
      return tuningStrategy.NoteNumberToFrequency((int) (noteNumber - transposeValue),
                                                  baseFrequceny);
    }
  }
}
