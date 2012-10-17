using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkStation
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            WorkStation.Properties.Settings wset = new Properties.Settings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlParameter[] pars = new SqlParameter[]{
                new SqlParameter(),
            };
        }

        private void getMachine()
        {
            SqlDataReader dataread=SqlHelper.ExecuteReader();
            this.cboMachine.i
        }
        private void getValueType()
        {
 
        }
        private void getPoint()
        {
 
        }
    }
}
