using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Applications
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
