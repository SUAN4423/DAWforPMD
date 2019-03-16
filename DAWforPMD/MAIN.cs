using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWforPMD
{
    class MAIN
    {
        static void Main(string[] args)
        {
            Form1 cForm1 = new Form1();

            //モーダルでフォームを表示する
            cForm1.ShowDialog();

            //リソースを解放する
            cForm1.Dispose();
        }
    }
}
