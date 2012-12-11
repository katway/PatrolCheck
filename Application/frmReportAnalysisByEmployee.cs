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
    public partial class frmReportAnalysisByEmployee : Form
    {
        public frmReportAnalysisByEmployee()
        {
            InitializeComponent();
        }
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=PatrolCheck;User ID=sa;Password=sa123";         
        private void btnSearch_Click(object sender, EventArgs e)
        {
             SqlParameter[] par = new SqlParameter[]{
             new SqlParameter("@StartTime",this.dateTimePicker1.Value),
             new SqlParameter("@EndTime",this.dateTimePicker2.Value),
             new SqlParameter("@PostID",this.cboPost.SelectedValue),
             new SqlParameter("@OperatorID",this.cboPerson.SelectedValue),
             new SqlParameter("@RouteID",this.comboBox1.SelectedValue)
            };
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr,"GetAttendance",par);
            this.gridControl1.DataSource = ds.Tables[0];
        }
        private void cboRoute_Init()
        {

            string sqlRoute = "select ID,Name from CheckRoute";
            DataSet ds = SqlHelper.ExecuteDataset(sqlRoute);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = ds.Tables[0];

        }
        private void cboPost_Init()
        {
            //ring sqlPost = "select CheckTask.Post as ID,Post.Name as Name from Post,CheckTask where Post.ID=CheckTask.Post";
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
            cboRoute_Init();
            cboPost_Init();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPost == null) return;
            string sqlRoute = " select Employee_ID as Operator ,Employee.Name as Name from Employee,Post_Employee where Employee.ID = Post_Employee.Employee_ID and Post_Employee.ID=" + cboPost.SelectedValue;
            DataSet ds = SqlHelper.ExecuteDataset(sqlRoute);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboPerson.ValueMember = "Operator";
            cboPerson.DisplayMember = "Name";
            cboPerson.DataSource = ds.Tables[0];
        }

    }
}
