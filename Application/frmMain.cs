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
        private void Application_Load(object sender, EventArgs e)
        {

      
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {



                        
        }         

     
        private Dictionary<string, Form> FormMap = new Dictionary<string, Form>();
        private void ShowForm(object sender, EventArgs e)
        {

            string className = (sender as ToolStripMenuItem).Name.Replace("tsmi", "frm");
            MessageBox.Show(className);
            if (!FormMap.Keys.Contains(className))
            {
                Assembly assem = Assembly.GetExecutingAssembly();
                System.Type t = assem.GetType("WorkStation." + className);
                object obj = null;
                if (t != null)
                    obj = Activator.CreateInstance(t);
                if (obj != null)
                {
                    (obj as Form).MdiParent = this;
                    FormMap.Add(className, obj as Form);
                }
            }
            if (FormMap.Keys.Contains(className))
                FormMap[className].Show();
        }

    }
}
