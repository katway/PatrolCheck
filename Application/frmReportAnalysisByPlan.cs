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
    public partial class frmReportAnalysisByPlan : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmReportAnalysisByPlan()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(this.cboPlanName.SelectedValue);
            string str = @"declare  @taskCount int      
                              select  @taskCount = count(*) from checktask 
                              where  Plan_ID in(select ID from CheckPlan where CheckPlan.StartTime> cast(('{0}') as datetime) and CheckPlan.EndTime< cast(('{1}') as datetime) and PlanState=8)
                              if( @taskCount <= 0)
	                          begin
		                      print 'false'
	                          end
                              else
                              begin
                              declare @NewTask int;
                              declare @DotTask int;
                              declare @DtTask  int;    
                              select  TaskState into #temp1  from  checktask where Plan_ID in(select ID from CheckPlan where CheckPlan.StartTime> cast(('{0}') as datetime) and CheckPlan.EndTime< cast(('{1}') as datetime) and PlanState=8)
	                          select  @DotTask= count(*) from  #temp1  where  TaskState in(8)
	                          select  @DtTask=  count(*) from  #temp1  where  TaskState in(4) 
                              select  @NewTask=  count(*) from #temp1  where  TaskState in(1) 	
	                          select distinct p.Name a,p.ID as PlanID ,p.StartTime b,p.EndTime c ,
	                          @DtTask as d, @NewTask as e ,@DotTask as f,(@NewTask+@DtTask+@DotTask) as g,		
	                          cast( ( cast( @DtTask as float ) /@taskCount * 100 )  as nvarchar )+'%' as h                          
	                          from CheckTask t,CheckPlan p
	                          where p.StartTime> cast(('{0}') as datetime) and p.EndTime< cast(('{1}') as datetime) ";
            if (cboPlanName.SelectedValue != null && cboPlanName.SelectedValue.ToString() != "-1")
            {
                str += " and p.ID=" + cboPlanName.SelectedValue;
            }

            str += @"  and p.ID = t.Plan_ID                              
                            drop table #temp1
                              end ";

            str = string.Format(str, new object[]{
              this.dateTimePicker1.Value.ToString(),
              this.dateTimePicker2.Value.ToString()
            });
            string SelectTask = "select Plan_ID as PlanID,Name,Alias,StartTime,EndTime,(select name from checkroute where id=route_id) as route_name,(select meaning from codes where code=taskstate and purpose='taskstate') as TaskState  from CheckTask  where StartTime> cast(('{0}') as datetime) and EndTime< cast(('{1}') as datetime)";
            SelectTask = string.Format(SelectTask, new object[] {  this.dateTimePicker1.Value.ToString(),
            this.dateTimePicker2.Value.ToString()
            });          
            DataSet ds2 = new DataSet();
            ds2 = SqlHelper.ExecuteDataset(str + ";" + SelectTask);
            //ds2 = SqlHelper.ExecuteDataset(str);  
            ds2.Relations.Add(new DataRelation("PlanToTask", ds2.Tables[0].Columns["PlanID"], ds2.Tables[1].Columns["PlanID"]));
            this.gridControl1.DataSource = ds2.Tables[0];          

        }


        private void datetimepicker_valuechanged(object sender, EventArgs e)
        {
            cboPlan_Init(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void cboPlan_Init(DateTime dt1, DateTime dt2)
        {
            if (dt1 > dt2)
            {
                return;
            }
            else
            {
                string sqlPlan = "select ID,Name from CheckPlan where StartTime>'" + dt1 + "' and EndTime<'" + dt2 + "' and PlanState=8";
                DataSet ds = SqlHelper.ExecuteDataset(sqlPlan);
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = "-1";
                dr[1] = "全部";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cboPlanName.ValueMember = "ID";
                cboPlanName.DisplayMember = "Name";
                cboPlanName.DataSource = ds.Tables[0];
            }
        }

        private void frmReportAnalysisByPlan_Load(object sender, EventArgs e)
        {


        }


    }
}
