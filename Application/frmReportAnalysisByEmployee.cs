using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkStation
{
    public partial class frmReportAnalysisByEmployee : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmReportAnalysisByEmployee()
        {
            InitializeComponent();
        }

        private void frmReportAnalysisByEmployee_Load(object sender, EventArgs e)
        {
            bindPost();
        }
        private void bindEmployee(object postid)
        {
            string sql = "select e.ID,e.Name from employee e left join post_employee pe  on pe.employee_id=e.id where pe.post_id=" + postid;
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboOperator.DisplayMember = "Name";
            cboOperator.ValueMember = "ID";
            cboOperator.DataSource = ds.Tables[0];
        }
        private void bindPost()
        {
            string sql = "select ID,Name From Post where validstate=1";
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1; dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboPost.DisplayMember = "Name";
            cboPost.ValueMember = "ID";
            cboPost.DataSource = ds.Tables[0];
        }

        private void cboPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPost.SelectedValue != null)
            {
                bindEmployee(cboPost.SelectedValue);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
