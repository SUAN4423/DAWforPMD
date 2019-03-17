using System;
using System.Windows.Forms;

namespace DAWforPMD
{
    class MAIN
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form1 cForm1 = new Form1();

            // フォームを表示
            cForm1.Show();

            // メインフレームを指定して、イベントループを発生させる
            Application.Run(cForm1);
        }
    }
}
