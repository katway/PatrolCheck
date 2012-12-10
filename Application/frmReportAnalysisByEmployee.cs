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
    public partial class frmReportAnalysisByEmployee : Form
    {
        public frmReportAnalysisByEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlEmployee = "select employee_id from post_employee ";
            if (cboPost.SelectedValue != null && cboPost.SelectedValue.ToString() != "-1")
            {
                sqlEmployee += " where id=" + cboPost.SelectedValue;
            }
            DataSet dsOperators = SqlHelper.ExecuteDataset(sqlEmployee);
            string SelectTask;
            DataSet dsComo = null;
            bool isFirst = true;
            for (int i = 0; i < dsOperators.Tables[0].Rows.Count; i++)
            {
                int a = Convert.ToInt32(dsOperators.Tables[0].Rows[i]["employee_id"]);
                int empid = 0;
                int route = Convert.ToInt32(this.comboBox1.SelectedValue);
                int post = Convert.ToInt32(this.cboPost.SelectedValue);
                SelectTask = @"declare  @taskCount int         
                              select  @taskCount = count(*) from checktask 
                              where  StartTime>'{2}' and EndTime< '{3}' and Operator={5}
                              if( @taskCount > 0)	                         
                              begin
                              declare  @NewTask int;
                              declare  @DotTask int;
                              declare  @DtTask int;    
                              select   TaskState into #temp  from checktask where StartTime> '{2}' and EndTime< '{3}'  and Operator={5}
	                          select   @DotTask= count(*) from #temp where TaskState in(8)
	                          select   @DtTask= count(*) from #temp where  TaskState in(4) 
                              select   @NewTask= count(*) from #temp where  TaskState in(1) 	
	                          select distinct r.Name a,r.ID as RouteID,t.StartTime b,t.EndTime c ,e.Name d,
	                          @DtTask as e, @NewTask as f ,@DotTask as g,@NewTask+@DtTask+@DotTask as h,		
	                          cast( ( cast( @DtTask  as float  ) /@taskCount * 100 )  as nvarchar )+'%' as i,(select Post.Name from Post,CheckTask where Post.ID=CheckTask.Post and CheckTask.Post ={4}) Post              
	                          from CheckRoute r,RouteChecking rc,TaskChecking tc,Employee e,CheckTask t
	                          where t.StartTime> '{2}' and t.EndTime< '{3}'";

                SelectTask = string.Format(SelectTask, new object[] { 
                empid, 
                route,
                this.dateTimePicker1.Value,
                this.dateTimePicker2.Value, 
                post,
                a
            });
                if (this.comboBox1.SelectedValue.ToString() != "-1")
                {
                    SelectTask += " and r.ID=" + this.comboBox1.SelectedValue;
                }
                if (this.cboPerson.SelectedValue.ToString() != "-1")
                {
                    SelectTask += " and e.ID=" + this.cboPerson.SelectedValue;
                }
                if (this.cboPost.SelectedValue.ToString() != "-1")
                {
                    SelectTask += " and t.Post=" + this.cboPost.SelectedValue;
                }
                SelectTask += @"  
                              and t.ID = tc.Task_ID                              
                              and r.ID = rc.Route_ID and rc.Tas_ID = t.ID	
                              drop table #temp
                              end  ";

                DataSet ds = SqlHelper.ExecuteDataset(SelectTask);
                if (ds.Tables.Count == 1)
                {
                    if (isFirst == true)
                    {
                        dsComo = ds.Clone();
                        isFirst = false;
                    }
                    DataRow dr = dsComo.Tables[0].NewRow();
                    for (int n = 0; n < ds.Tables[0].Columns.Count; n++)
                    {
                        dr[n] = ds.Tables[0].Rows[0][n];
                    }
                    dsComo.Tables[0].Rows.InsertAt(dr, 0);
                }
                
                //else
                //{
                //    MessageBox.Show("找不到该数据，请稍后再试！");
                //    return;
                //}

            }
            if (dsComo != null && dsComo.Tables.Count == 1)
            {
                gridControl1.DataSource = dsComo.Tables[0];
            }
                  
        }
        private void cboRoute_Init()
        {

            string sqlRoute = "select ID,Name from CheckRoute";
            //string sqlRoute = "select CheckTask.Route_ID as ID,CheckRoute.Name as Name from CheckRoute,CheckTask where CheckRoute.ID=CheckTask.Route_ID ";
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
            //string sqlRoute = "select CheckTask.Operator,Employee.Name from Employee,CheckTask where Employee.ID=CheckTask.Operator and CheckTask.Post=" + cboPost.SelectedValue;
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
