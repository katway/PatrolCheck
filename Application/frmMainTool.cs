using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace WorkStation
{
    public partial class frmMainTool : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmMainTool()
        {
            InitializeComponent();
        }

        private void frmMainTool_Load(object sender, EventArgs e)
        {
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Program.MainForm.ShowForm(e.Node.Name);
        }

 
    }
}
