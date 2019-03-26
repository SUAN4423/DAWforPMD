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
  /// このカスタム コントロールを XAML ファイルで使用するには、手順 1a または 1b の後、手順 2 に従います。
  ///
  /// 手順 1a) 現在のプロジェクトに存在する XAML ファイルでこのカスタム コントロールを使用する場合
  /// この XmlNamespace 属性を使用場所であるマークアップ ファイルのルート要素に
  /// 追加します:
  ///
  ///     xmlns:MyNamespace="clr-namespace:SSTEditor"
  ///
  ///
  /// 手順 1b) 異なるプロジェクトに存在する XAML ファイルでこのカスタム コントロールを使用する場合
  /// この XmlNamespace 属性を使用場所であるマークアップ ファイルのルート要素に
  /// 追加します:
  ///
  ///     xmlns:MyNamespace="clr-namespace:SSTEditor;assembly=SSTEditor"
  ///
  /// また、XAML ファイルのあるプロジェクトからこのプロジェクトへのプロジェクト参照を追加し、
  /// リビルドして、コンパイル エラーを防ぐ必要があります:
  ///
  ///     ソリューション エクスプローラーで対象のプロジェクトを右クリックし、
  ///     [参照の追加] の [プロジェクト] を選択してから、このプロジェクトを参照し、選択します。
  ///
  ///
  /// 手順 2)
  /// コントロールを XAML ファイルで使用します。
  ///
  ///     <MyNamespace:NotesView/>
  ///
  /// </summary>
  public class NotesView : Control {
    static NotesView() {
      DefaultStyleKeyProperty.OverrideMetadata(typeof(NotesView), new FrameworkPropertyMetadata(typeof(NotesView)));
    }

    protected override void OnRender(DrawingContext drawingContext) {
      base.OnRender(drawingContext);
      var octaves = 10;

      // draw background
      var br = new SolidColorBrush(Color.FromRgb(0x20, 0x20, 0x20));
      var br2 = new SolidColorBrush(Color.FromRgb(0x70, 0x70, 0x70));

      drawingContext.DrawRectangle(br, null, new Rect(0, 0, this.Width, this.Height));

      // draw grids
      var notes_height = (this.Height / octaves / 12);
      var gridBorder = new Pen(br2, 0.5);
      var gridBorderBold = new Pen(br2, 2);
      var view_width = this.Width;
      var br3 = new SolidColorBrush(Color.FromRgb(0x35, 0x35, 0x35));

      for (int i = 0; i < 12 * octaves; i++) {
        var j = i % 12;
        if (j == 1 || j == 3 || j == 5 || j == 8 || j == 10)
          drawingContext.DrawRectangle(br3, null, new Rect(0,  i * notes_height, this.Width, notes_height));
        else
          drawingContext.DrawLine(gridBorder, new Point(0, i * notes_height), new Point(view_width, i * notes_height));
      }

      
      var view_height = this.Height;
      for (int i = 0, j = 0; i < this.Width; i += 70) {
        if ((j & 0x03) != 0) {
          drawingContext.DrawLine(gridBorder, new Point(i, 0), new Point(i, view_height));
        } else {
          drawingContext.DrawLine(gridBorderBold, new Point(i, 0), new Point(i, view_height));
        }
        j++;
      }
    }
  }
}
