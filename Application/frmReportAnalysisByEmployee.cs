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
    public partial class frmReportAnalysisByEmployee : Form
    {
        public frmReportAnalysisByEmployee()
        {
            InitializeComponent();
        }        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<object, object> DirOperator = new Dictionary<object, object>();
            if (cboPost.SelectedValue.ToString() != "-1")
            {
                if (cboOperator.SelectedValue != null && cboOperator.SelectedValue.ToString() == "-1")
                {
                    SqlDataReader dr = SqlHelper.ExecuteReader("select employee_id, post_id from post_employee where post_id=" + cboPost.SelectedValue);
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
                    DirOperator.Add(cboOperator.SelectedValue,cboPost.SelectedValue);

                }
            }
            else
            {
                //所有岗位下所有人员 
                SqlDataReader dr = SqlHelper.ExecuteReader("select employee_id,post_id from post_employee");
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
                pars = new SqlParameter[]
                {  
                  new SqlParameter("@StartTime",dtpStart.Value),
                  new SqlParameter("@EndTime",dtpEndTime.Value), 
                  new SqlParameter("@PostID",ide.Value), 
                  new SqlParameter("@OperatorID",ide.Key)
                };
                DataSet ds = SqlHelper.ExecuteDataset("GetAttendance",CommandType.StoredProcedure,pars);
                if (isFirst == true)
                {
                    isFirst = false;
                    dsCollect = ds.Clone();
                }
                if (dsCollect != null)
                {
                    dsCollect.Tables[0].ImportRow(ds.Tables[0].Rows[0]);
                }
            }
            if (dsCollect != null)
            {
                this.gridControl1.DataSource = dsCollect.Tables[0];
            }
            else
            {
                this.gridControl1.DataSource = null;
            }
        }    
        private void cboPost_Init()
        {
            string sqlPost = "select ID,Name from Post";
            DataSet ds = SqlHelper.ExecuteDataset(sqlPost);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);          
            cboPost.ValueMember = "ID";
            cboPost.DisplayMember = "Name";
            cboPost.DataSource = ds.Tables[0];
        }

        private void frmPersonStatistics2_Load(object sender, EventArgs e)
        {          
            cboPost_Init();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string sqlRoute = " select Employee_ID as Operator ,Employee.Name as Name from Employee,Post_Employee where Employee.ID = Post_Employee.Employee_ID and Post_Employee.post_id=" + cboPost.SelectedValue;
            DataSet ds = SqlHelper.ExecuteDataset(sqlRoute);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboOperator.ValueMember = "Operator";
            cboOperator.DisplayMember = "Name";
            cboOperator.DataSource = ds.Tables[0];
        }

    }
}
