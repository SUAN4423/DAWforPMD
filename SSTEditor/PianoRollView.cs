using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
  ///     <MyNamespace:PianoRollView/>
  ///
  /// </summary>
  public class PianoRollView : Control {
    static PianoRollView() => DefaultStyleKeyProperty.OverrideMetadata(typeof(PianoRollView), new FrameworkPropertyMetadata(typeof(PianoRollView)));

    protected override void OnRender(DrawingContext drawingContext) {
      base.OnRender(drawingContext);
      var octaves = 10;

      // draw background
      var br = new SolidColorBrush(Color.FromRgb(0x20, 0x20, 0x20));
      var br2 = new SolidColorBrush(Color.FromRgb(0x70, 0x70, 0x70));

      drawingContext.DrawRectangle(br, null, new Rect(0, 0, this.Width, this.Height));

      // draw grids
      var notes_width = (this.Height / octaves / 12);
      var gridBorder = new Pen(br2, 0.5);
      var view_width = this.Width;
      var br3 = new SolidColorBrush(Color.FromRgb(0x35, 0x35, 0x35));

      for (int i = 0; i < 120; i++) {
        var j = i % 12;
        if (j == 1 || j == 3 || j == 5 || j == 8 || j == 10)
          drawingContext.DrawRectangle(br3, null, new Rect(0,  i * notes_width, this.Width, notes_width));
        else
          drawingContext.DrawLine(gridBorder, new Point(0, i * notes_width), new Point(view_width, i * notes_width));
      }

      
      var view_height = this.Height;
      for (int i = 50; i < this.Width; i += 70) {
        drawingContext.DrawLine(gridBorder, new Point(i, 0), new Point(i, view_height));
      }

      var whity_width = (this.Height / octaves / 7);
      for (int i = 0; i < octaves; i++)
        DrawPianoKeys(drawingContext, i, whity_width);
    }

    private void DrawPianoKeys(DrawingContext drawingContext, double offset, double width = 10) {
      var pianoBorder = new Pen(Brushes.Gray, 1);
      var startpos    = width * 7 * offset;
      var br = Brushes.White;
      for (int i = 0; i < 7; i++) {
        if (i == 6) br = new SolidColorBrush(Color.FromRgb(0xE0, 0xFF, 0xEE));
        drawingContext.DrawRectangle(br, pianoBorder, new Rect(0, startpos + width * i, 50, width));
      }

      var blackNoteWidth = width * 3 / 5;

      var darky = new SolidColorBrush(Color.FromRgb(0x1E, 0x1F, 0x20));
      var highlight = new SolidColorBrush(Color.FromRgb(0x3E, 0x3F, 0x3E));

      for (int i = 0; i < 6; i++) {
        if (i == 3) continue;

        drawingContext.DrawRectangle(highlight, pianoBorder,
                                      new Rect(0,
                                               width - (blackNoteWidth * 0.5) + startpos + width * i,
                                               25,
                                               blackNoteWidth));
        drawingContext.DrawRectangle(darky, null,
                                      new Rect(0,
                                               width - (blackNoteWidth * 0.5) + startpos + width * i,
                                               25,
                                               blackNoteWidth - (width * 0.25)));
      }
    }
  }
}
