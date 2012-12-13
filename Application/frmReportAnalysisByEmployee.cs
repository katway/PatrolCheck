using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

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
            Dictionary<object, object> DirOperator = new Dictionary<object, object>();
            if (cboPost.SelectedValue.ToString() != "-1")
            {
                if (cboOperator.SelectedValue != null && cboOperator.SelectedValue.ToString() == "-1")
                {
                    SqlDataReader dr = SqlHelper.ExecuteReader("select post_id,employee_id from post_employee where post_id=" + cboPost.SelectedValue);
                    if (dr != null)
                    {
                        while (dr.Read())
                        {

                            DirOperator.Add(dr["employee_id"], dr["post_id"]);

                        }
                    }
                    dr.Close();
                }
                else
                {
                    DirOperator.Add(cboPost.SelectedValue, cboOperator.SelectedValue);
                }
            }
            else
            {
                //所有岗位下所有人员
                SqlDataReader dr = SqlHelper.ExecuteReader("select post_id,employee_id from post_employee");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        DirOperator.Add(dr["employee_id"], dr["post_id"]);
                    }
                }
                dr.Close();
            }
            SqlParameter[] pars = null;
            DataSet dsCollect = null;
            bool isFirst = true;
            IDictionaryEnumerator ide = DirOperator.GetEnumerator();
            while (ide.MoveNext())
            {
                
                pars = new SqlParameter[]{
                    new SqlParameter("@StartTime",dtpStart.Value),
                    new SqlParameter("@EndTime",dtpEndTime.Value),
                    new SqlParameter("@PostID",ide.Value),
                    new SqlParameter("@OperatorID",ide.Key)
                };
                DataSet ds = SqlHelper.ExecuteDataset("GetAttendance", CommandType.StoredProcedure, pars);
                if (isFirst == true)
                {
                    dsCollect = ds.Clone();
                    isFirst = false;
                }
                if (dsCollect != null)
                {
                    DataRow dr = ds.Tables[0].NewRow();
                    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                    {
                        dr[i] = ds.Tables[0].Rows[0][i];
                    }
                    dsCollect.Tables[0].ImportRow(ds.Tables[0].Rows[0]);
                }
            }
            this.gridControl1.DataSource = dsCollect.Tables[0];

        }
    }
}
