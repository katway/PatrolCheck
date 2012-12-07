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
            int empid = Convert.ToInt32(this.cboPerson.SelectedValue);
            int route = Convert.ToInt32(this.comboBox1.SelectedValue);
            int post =  Convert.ToInt32(this.cboPost.SelectedValue);
            string SelectTask = @"declare  @taskCount int         
                              select  @taskCount = count(*) from checktask 
                              where  StartTime>cast(('{2}') as datetime) and EndTime< cast(('{3}') as datetime) and Operator={0}
                              if( @taskCount <= 0)
	                          begin
		                      print 'false'
	                          end
                              else
                              begin
                              declare  @NewTask int;
                              declare  @DotTask int;
                              declare  @DtTask int;    
                              select   TaskState into #temp  from checktask where StartTime> cast(('{2}') as datetime) and EndTime< cast(('{3}') as datetime)  and Operator={0}
	                          select   @DotTask= count(*) from #temp where TaskState in(8)
	                          select   @DtTask= count(*) from #temp where  TaskState in(4) 
                              select   @NewTask= count(*) from #temp where  TaskState in(1) 	
	                          select distinct r.Name a,r.ID as RouteID,t.StartTime b,t.EndTime c ,e.Name d,
	                          @DtTask as e, @NewTask as f ,@DotTask as g,@NewTask+@DtTask+@DotTask as h,		
	                          cast( ( cast( @DtTask  as float  ) /@taskCount * 100 )  as nvarchar )+'%' as i,t.Post as Post	                          
	                          from CheckRoute r,RouteChecking rc,TaskChecking tc,Employee e,CheckTask t
	                          where t.StartTime> cast(('{2}') as datetime) and t.EndTime< cast(('{3}') as datetime) ";                       

                SelectTask = string.Format(SelectTask, new object[] { 
                empid, 
                route,
                this.dateTimePicker1.Value.ToString(),
                this.dateTimePicker2.Value.ToString(),
                post 
            });

            if(this.comboBox1.SelectedValue.ToString()!="-1")
            {
                SelectTask += " and r.ID="+this.comboBox1.SelectedValue;
            }
            if(this.cboPerson.SelectedValue.ToString()!="-1")
            {
                SelectTask += " and t.operator="+this.cboPerson.SelectedValue;
            }
            if(this.cboPost.SelectedValue.ToString()!="-1")
            {
                SelectTask += " and t.Post="+this.cboPost.SelectedValue;
            }
            SelectTask += @"  and t.ID = tc.Task_ID                              
                              and r.ID = rc.Route_ID and rc.Tas_ID = t.ID	
                              drop table #temp
                              end  ";
             DataSet ds = SqlHelper.ExecuteDataset(SelectTask);
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
            string sqlPost = "select CheckTask.Post as ID,Post.Name as Name from Post,CheckTask where Post.ID=CheckTask.Post";
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
            string sqlRoute = "select CheckTask.Operator,Employee.Name from Employee,CheckTask where Employee.ID=CheckTask.Operator and CheckTask.Post=" + cboPost.SelectedValue;
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
