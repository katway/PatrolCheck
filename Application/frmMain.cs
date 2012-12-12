using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using WeifenLuo.WinFormsUI.Docking;

namespace WorkStation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
<<<<<<< JieMian2
        public Dictionary<string, WeifenLuo.WinFormsUI.Docking.DockContent> FormMap = new Dictionary<string, WeifenLuo.WinFormsUI.Docking.DockContent>();
        private WeifenLuo.WinFormsUI.Docking.DockContent CreteFormFormName(string formName)
=======
        private Dictionary<string, Form> FormMap = new Dictionary<string, Form>();
        private Form CreteFormFormName(string formName)
>>>>>>> local
        {
            Assembly assem = Assembly.GetExecutingAssembly();
            System.Type t = assem.GetType("WorkStation." + formName);
            object obj = null;
            if (t != null)
                obj = Activator.CreateInstance(t);
            if (obj != null)
            {
                (obj as Form).MdiParent = this;
                return (obj as Form);
            }
            else
            {
                return null;
            }
        }
        private void ShowForm(object sender, EventArgs e)
        {
            string className = (sender as ToolStripMenuItem).Name.Replace("tsmi", "frm");

            if (className.Contains("Edit"))
                className = className.Replace("Edit", "EditDelete");
            else
                className = className.Replace("Delete", "EditDelete");
            this.Text = className;
            if (FormMap.Keys.Contains(className))
            {
                if (FormMap[className] != null)
                {
                    if (FormMap[className].IsDisposed)
                    {
                        FormMap[className] = this.CreteFormFormName(className);
                        FormMap[className].Show();
                    }
                }
                else
                {
                    //窗体类名已经出现在列表，但窗体为NULL，说明无法根据窗体类名创建对象。
                }
            }
            else
            {
                FormMap.Add(className, this.CreteFormFormName(className));
                if (FormMap[className] != null) FormMap[className].Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMainTool tool = new frmMainTool();
            tool.Show(this.dockPanel);
            timer1.Start();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    foreach (Form f in MdiChildren)
        //    {
        //        if (!FormMap.Keys.Contains(f.Name))
        //        {
        //            (f as DockContent).Show(dockPanel);
        //        }
        //        else
        //        {
        //            FormMap
        //        }
        //    }
        //}

        
    }
}
