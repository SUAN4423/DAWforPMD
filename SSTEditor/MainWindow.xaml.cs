using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SSTEditor {
  /// <summary>
  /// MainWindow.xaml の相互作用ロジック
  /// </summary>
  public partial class MainWindow : MahApps.Metro.Controls.MetroWindow {
    public MainWindow() {
      InitializeComponent();
      
      CalcPianoRollHeight();
    }

    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
      CalcPianoRollHeight();
    }

    private void CalcPianoRollHeight() {
      PianoRoll.Height = (Math.Round(PianoRollHeightSlider.Value) + 7) * 120;
    }

    private void QuitApp_Executed(object sender, ExecutedRoutedEventArgs e) {
      this.Close();
    }
  }
}
