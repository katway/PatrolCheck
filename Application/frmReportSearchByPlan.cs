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
    public partial class frmReportSearchByPlan : Form
    {
        public frmReportSearchByPlan()
        {
            InitializeComponent();
        }

        private void frmReportSearchByPlan_Load(object sender, EventArgs e)
        {

        }

        private void bindRoute()
        {
            DataSet ds = SqlHelper.ExecuteDataset("select ID,Name From CheckRoute");
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboRoute.DisplayMember = "Name";
            cboRoute.ValueMember = "ID";
            cboRoute.DataSource = ds.Tables[0];
            ds.Dispose();
        }

        private void bindPlan(int routeid,DateTime start,DateTime end)
        {
            DataSet ds = SqlHelper.ExecuteDataset("Select ID,Name from checkplan where route_Id="+routeid+" and StartTime>"+start+" and endtime<"+end);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboPlan.DisplayMember = "Name";
            cboPlan.ValueMember = "ID";
            cboPlan.DataSource = ds.Tables[0];
            ds.Dispose();
        }
    }
}
