using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace WorkStation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Dictionary<string, Form> FormMap = new Dictionary<string, Form>();
        private Form CreteFormFormName(string formName)
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
    }
}
