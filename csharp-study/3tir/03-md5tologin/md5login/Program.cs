using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace md5login
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frmMain = new Form1();
            Application.Run(frmMain);
        }
    }
}
