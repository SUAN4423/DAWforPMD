using MahApps.Metro;
using System;
using System.Windows;

namespace SSTEditor {
  /// <summary>
  /// App.xaml の相互作用ロジック
  /// </summary>
  public partial class App : Application {
    protected override void OnStartup(StartupEventArgs e) {
      Tuple<AppTheme, Accent> appStyle = ThemeManager.DetectAppStyle(Application.Current);

      ThemeManager.ChangeAppStyle(Application.Current,
                                  ThemeManager.GetAccent("Olive"),
                                  ThemeManager.GetAppTheme("BaseLight")); // or appStyle.Item1

      base.OnStartup(e);
    }
  }
}
