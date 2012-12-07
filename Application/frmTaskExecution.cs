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
    public partial class frmTaskExecution : Form
    {
        public frmTaskExecution()
        {
            InitializeComponent();
        }

        private void frmTaskExecution_Load(object sender, EventArgs e)
        {
            showToDay();
            bindRoute();
            bindPost();
            getGvData();
        }

        private void btnShowToDay_Click(object sender, EventArgs e)
        {
            showToDay();
        }

        private void showToDay()
        {
            this.dtpStart.Value = DateTime.Parse((DateTime.Now.ToShortDateString() + " 00:00"));
            this.dtpEnd.Value = DateTime.Parse((DateTime.Now.ToShortDateString() + " 23:59"));
        }
        private void bindRoute()
        {
            DataSet ds = SqlHelper.ExecuteDataset("select ID,Name From CheckRoute where validstate=1");
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboRoute.DisplayMember = "Name";
            cboRoute.ValueMember = "ID";
            cboRoute.DataSource = ds.Tables[0];
            ds.Dispose();
        }
        private void bindPlan(object routeid, DateTime start, DateTime end)
        {
            string sql = "Select ID,Name from checkplan where  (effectivetime<='" + start + "' and ineffectivetime>='" + end + "') or (effectivetime>'" + start + "' and effectivetime<'" + end + "') or (ineffectivetime>'" + start + "' and ineffectivetime<'" + end + "') and PlanState=16";
            if (routeid.ToString() != "-1")
            {
                sql += " and route_Id=" + routeid;
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
        private void bindTask(object planid, DateTime start, DateTime end)
        {
            string sql = "Select ID,Name From CheckTask Where StartTime>='" + start + "' and EndTime<='" + end + "' and plan_id=" + planid;
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

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoute.SelectedValue == null) return;
            bindPlan(cboRoute.SelectedValue, dtpStart.Value, dtpEnd.Value);
        }
        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPlan.SelectedValue == null) return;
            bindTask(cboPlan.SelectedValue, dtpStart.Value, dtpEnd.Value);
            object postid = SqlHelper.ExecuteScalar("Select post from checkplan where id=" + cboPlan.SelectedValue);
            cboPost.SelectedValue = postid == null ? "-1" : postid;
        }
        private void cboPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPost.SelectedValue != null)
            {
                bindEmployee(cboPost.SelectedValue);
            }
        }
        private void dateTimeValueChanged(object sender, EventArgs e)
        {
            if (cboRoute.SelectedValue == null) return;
            bindPlan(cboRoute.SelectedValue,dtpStart.Value,dtpEnd.Value);
        }

        private void getGvData()
        {
            string sqlPlan = @"select ID as PlanID,Name,Alias,EffectiveTime,IneffectiveTime,TimeDeviation,
                               (select Name from checkroute where id=route_id) as RouteName,
                               (select Name From post where id=post) as PostName,
                               (select Name From employee where id=operator) as OperatorName,
                               (select Name From employee where id=planner) as Planner,
                               (select Meaning from codes where code=planstate and purpose='planstate') as PlanState
                             from checkplan where (effectivetime<='" + dtpStart.Value + "' and ineffectivetime>='" + dtpEnd.Value + "') or (effectivetime>'" + dtpStart.Value + "' and effectivetime<'" + dtpEnd.Value + "') or (ineffectivetime>'" + dtpStart.Value + "' and ineffectivetime<'" + dtpEnd.Value + "') and PlanState=16";
            string sqlTask = @"select ID,Plan_ID as PlanID,Name,StartTime,EndTime,TimeDeviation, Interval,
                               (select Name from post where id=post) as PostName,
                               (select Name From employee where id=operator) as OperatorName,
                               (select meaning from codes where code=intervalunit and purpose='intervalunit') as Intervalunit,
                               (select Meaning from codes where code=taskstate and purpose='taskstate') as TaskState
                             from checktask where StartTime>='" + dtpStart.Value + "' and EndTime<='" + dtpEnd.Value + "'";
            if (cboRoute.SelectedValue != null && cboRoute.SelectedValue.ToString() != "-1")
            {
                sqlPlan += " and route_id=" + cboRoute.SelectedValue;
            }
            if (cboPlan.SelectedValue != null && cboPlan.SelectedValue.ToString() != "-1")
            {
                sqlPlan += " and id="+cboPlan.SelectedValue;
                sqlTask += " and plan_id="+cboPlan.SelectedValue;
            }
            if (cboTask.SelectedValue != null && cboTask.SelectedValue.ToString() != "-1")
            {
                sqlTask += " and id=" + cboTask.SelectedValue;
            }
            if (cboPost.SelectedValue != null && cboPost.SelectedValue.ToString() != "-1")
            {
                sqlTask += " and post="+cboPost.SelectedValue;
                sqlPlan += " and post="+cboPost.SelectedValue;
            }
            if (cboOperator.SelectedValue != null && cboOperator.SelectedValue.ToString() != "-1")
            {
                sqlTask += " and operator="+cboOperator.SelectedValue;
            }

            DataSet ds = SqlHelper.ExecuteDataset(sqlPlan+";"+sqlTask);
            ds.Relations.Add("巡检任务", ds.Tables[0].Columns["PlanID"], ds.Tables[1].Columns["PlanID"]);
            gridControl1.DataSource=ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getGvData();
        }

       
    }
}
