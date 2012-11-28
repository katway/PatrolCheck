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
    public partial class frmReportRecordDetail : Form
    {
        public frmReportRecordDetail()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = SqlHelper.ExecuteDataset(@"");
        }

        private void frmReportRecordDetail_Load(object sender, EventArgs e)
        {

        }

        private void bindComboBox()
        {
            DataSet ds = SqlHelper.ExecuteDataset("select ID,Name from Employee");
            DataRow dr= ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr,0);
            cboEmployee.DisplayMember = "Name";
            cboEmployee.ValueMember = "ID";
            cboEmployee.DataSource = ds.Tables[0];
            ds.Dispose();

            ds = SqlHelper.ExecuteDataset("select ID,Name From PhysicalCheckPoint");
            dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboPoint.DisplayMember = "Name";
            cboPoint.ValueMember = "ID";
            cboPoint.DataSource = ds.Tables[0];
            ds.Dispose();

            ds = SqlHelper.ExecuteDataset("select ID,Name From CheckItem");
            dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboItem.DisplayMember = "Name";
            cboItem.ValueMember = "ID";
            cboItem.DataSource = ds.Tables[0];
            ds.Dispose();

            ds = SqlHelper.ExecuteDataset("select ID,Name From CheckRoute");
            dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboRoute.DisplayMember = "Name";
            cboRoute.ValueMember = "ID";
            cboRoute.DataSource = ds.Tables[0];
            ds.Dispose();

            ds = SqlHelper.ExecuteDataset("select ID,Name From CheckTask");
            dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboTask.DisplayMember = "Name";
            cboTask.ValueMember = "ID";
            cboTask.DataSource = ds.Tables[0];
            ds.Dispose();
        }


    }
}
