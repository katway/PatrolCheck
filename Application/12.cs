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
    public partial class _12 : Form
    {
        public _12()
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
            DataSet dsComo = null;
            bool isFirst = true;
            for (int i = 0; i < dsOperators.Tables[0].Rows.Count; i++)
            {
                int a = Convert.ToInt32(dsOperators.Tables[0].Rows[i]["employee_id"]);
                int empid = 0;
                int route = Convert.ToInt32(this.comboBox1.SelectedValue);
                int post = Convert.ToInt32(this.cboPost.SelectedValue);
                string SelectTask = @"declare  @taskCount int         
             select  @taskCount = count(*) from checktask 
             where  StartTime>'{2}' and EndTime< '{3}' and Operator={5}
             if( @taskCount > 0)	                         
             begin
             declare  @NewTask int;
             declare  @MissingTask  int; 
             declare  @completedTask int;    
             select   TaskState into #temp  from checktask where StartTime> '{2}' and EndTime< '{3}' and Operator={5}
             select   @MissingTask= count(*) from #temp where TaskState in(8)
             select   @completedTask= count(*) from #temp where  TaskState in(4) 
             select   @NewTask= count(*) from #temp where  TaskState in(1) 
             select 
             (select name from checkroute where id=t.route_id) as a,
             t.route_id as RouteID,
             t.StartTime as b,
             t.EndTime as c,
             (select name from employee where id=t.operator) as d,
             @completedTask as e,
             @NewTask as f,
             @MissingTask g,
             @completedTask+@NewTask+@MissingTask as h, 
             cast( ( cast( @completedTask  as float  ) /@taskCount * 100 )  as nvarchar )+'%' as i,
             (select name from post where id=t.post) as Post
             from  checktask t 
             left join checkroute r on t.route_id=r.id
             where t.StartTime> '{2}' and t.EndTime< '{3}'";
                SelectTask = string.Format(SelectTask, new object[] { empid, route, this.dateTimePicker1.Value, this.dateTimePicker2.Value, post, a });
                // SelectTask += " and t.operator="+a;
                if (this.cboPerson.SelectedValue.ToString() != "-1")
                {
                    //SelectTask += " and t.operator=" + this.cboPerson.SelectedValue;
                    SelectTask += " and t.operator=" + a;
                }
                if (this.comboBox1.SelectedValue.ToString() != "-1")
                {
                    SelectTask += " and r.ID=" + this.comboBox1.SelectedValue;
                }
                if (this.cboPost.SelectedValue.ToString() != "-1")
                {
                    SelectTask += " and t.Post=" + this.cboPost.SelectedValue;
                }
                SelectTask += @"                             
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

                if (dsComo != null && dsComo.Tables.Count == 1)
                {
                    gridControl1.DataSource = dsComo.Tables[0];
                }
            }
        }
    }
}
