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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void treeView3_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodeName = e.Node.Name.Replace("node","frm");
            Assembly assem = Assembly.GetExecutingAssembly();
            Type t = assem.GetType("WorkStation." + nodeName);
            object obj=null;
            if (t != null)
            {
                obj = Activator.CreateInstance(t);
            }
            if (obj != null)
            {
                (obj as WeifenLuo.WinFormsUI.Docking.DockContent).MdiParent = this.ParentForm;
                (obj as WeifenLuo.WinFormsUI.Docking.DockContent).Show();
                
            }

            
        }
    }
}
