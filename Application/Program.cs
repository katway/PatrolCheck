using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace WorkStation
{
    static class Program
    {
        public static frmMain MainForm = null;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new frmMain();
            Application.Run(MainForm);
        }
    }
}
