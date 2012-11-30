using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

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
            this.BeginInvoke((Action)delegate
            {
                bindRoute();
            });
            bindEmployee();
        }

        private void bindRoute()
        {
            DataSet ds = SqlHelper.ExecuteDataset("select ID,Name From CheckRoute");
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboRoute.DataSource = ds.Tables[0];        
            ds.Dispose();

        }
        private void bindEmployee()
        {
            string sql = "select ID,Name from Employee";
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboOperator.DisplayMember = "Name";
            cboOperator.ValueMember = "ID";
            cboOperator.DataSource = ds.Tables[0];
            ds.Dispose(); 
        }

        private void bindPlan(object routeid,DateTime start,DateTime end)
        {
            string sql = "Select ID,Name from checkplan where  StartTime>='" + start+"' and StartTime<='"+end +"' and PlanState=4";
            if (routeid.ToString() != "-1")
            {
                sql += " and route_Id=" + routeid ;
            }
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboPlan.DisplayMember = "Name";
            cboPlan.ValueMember = "ID";
            cboPlan.DataSource = ds.Tables[0];
            ds.Dispose();
        }

        private void bindTask(object planid,DateTime start,DateTime end)
        {
            string sql = "Select ID,Name From CheckTask Where StartTime>='"+start+"' and EndTime<='"+end+"' and Plan_ID="+planid;
            if (planid.ToString() != "-1")
            {
                sql += " and PlanID="+planid;
            }
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboTask.DisplayMember = "Name";
            cboTask.ValueMember = "ID";
            cboTask.DataSource = ds.Tables[0];
            ds.Dispose();
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindPlan(cboRoute.SelectedValue,dtpStart.Value,dtpEndTime.Value);
        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindTask(cboPlan.SelectedValue, dtpStart.Value, dtpEndTime.Value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlTask = @"select 
                       r.id as ID,
                       c.name as TaskName,
                       (select name from checkroute where id=c.route_id) as RouteName,
                       (select name from checkplan where id=c.plan_id) as PlanName,
                       c.StartTime ,c.EndTime ,r.starttime as ActualStartTime,r.endtime as ActualEndTime,
                       r.PercentComplete as PercentComplete,
                       (select Name From Employee where id=c.operator) as Operator
                       From routechecking r,checktask c where r.tas_id=c.id and r.starttime>= '"+dtpStart.Value+
                       "' and r.endtime<='"+dtpEndTime.Value+"'";
            string sqlPoint = @"select 
                                   R.ID,p.ID as PointID,
                                  (select name from PhysicalCheckPoint where  id=l.physicalPoint_id) as PointName,
                                   p.StartTime,p.EndTime,p.Duration
                              From PointChecking p 
                                   left join LogicalCheckPoint l on p.LogicPoint_ID=l.id
                                   left join Routechecking r on p.route_id=r.id 
                              where p.StartTime>='" + dtpStart.Value + "' and p.EndTime<='" + dtpEndTime.Value+"'";
            string sqlItem = @"select 
                                 P.ID,i.ID as ItemID,c.name as ItemName,
                                 i.BooleanValue,i.NumericalValue,i.TextValue,i.PictureFile 
                               from itemchecking i 
                                    left join pointchecking p  on i.pointchecking_id=p.id
                                    left join checkitem c on i.item_id=c.id where p.StartTime>='" + dtpStart.Value + "' and p.EndTime<='" + dtpEndTime.Value+"'";
            if (cboRoute.SelectedValue.ToString() != "-1")
            {
                sqlTask += " and c.route_id=" + cboRoute.SelectedValue;
            }
            if (cboPlan.SelectedValue.ToString() != "-1")
            {
                sqlTask += " and c.plan_id=" + cboPlan.SelectedValue;
            }
            if (cboRoute.SelectedValue.ToString() != "-1")
            {
                sqlTask += " and r.id=" + cboTask.SelectedValue;
            }
            if (cboOperator.SelectedValue.ToString() != "-1")
            {
                sqlTask += " and c.Operator="+cboOperator.SelectedValue;
            }
            DataSet dsTables = new DataSet();
            dsTables = SqlHelper.ExecuteDataset(sqlTask+";"+sqlPoint+";"+sqlItem);
           
            dsTables.Relations.Add(new DataRelation("TaskToPoint", dsTables.Tables[0].Columns["ID"], dsTables.Tables[1].Columns["ID"]));
            dsTables.Relations.Add(new DataRelation("PointToItem", dsTables.Tables[1].Columns["ID"], dsTables.Tables[2].Columns["ID"]));
            gridControl1.DataSource = dsTables.Tables[0];
        }
    }
}
