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
    public partial class frmTaskAssignment : Form
    {
        public frmTaskAssignment()
        {
            InitializeComponent();
        }

        private void frmTaskAssignment_Load(object sender, EventArgs e)
        {
            getDgvTask(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getDgvTask(null, null);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            bindCboPlan(dtpStart.Value, dtpEnd.Value);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            bindCboPlan(dtpStart.Value, dtpEnd.Value);
        }
        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPlan.SelectedValue != null && cboPlan.SelectedValue.ToString() != "-1")
            {
                bindCboTask(cboPlan.SelectedValue);
            }
            else
            {
                cboTask.DataSource = null;
            }
        }

        private void getDgvTask(object starttime, object endtime)
        {
            string sql = @"select 
                    t.ID,P.Name as PlanName,t.Name ,t.Alias,t.StartTime,
                    t.EndTime,t.Duration,t.TimeDeviation,
                    (select Name From Post where id=t.Post) as PostName,
                    t.Post as PostID,
                    (select Name from employee where id=t.operator) as OperatorName,
                     t.Operator as OperatorID,
                    (select Name from checkroute where id=t.route_id) as RouteName,
                     t.Interval,
                    (select Meaning from codes where code=t.Intervalunit and purpose='intervalunit') as IntervalUnit,
                    (select name from employee where validstate=1 and id=p.planner) as Planner,                           
                    p.EffectiveTime,p.IneffectiveTime
                    From checktask t left join checkplan p on t.plan_id=p.id Where p.planstate=8";
            if (cboPlan.SelectedValue != null && cboPlan.SelectedValue != "-1")
            {
                sql += " and t.plan_id=" + cboPlan.SelectedValue;
            }
            if (cboTask.SelectedValue != null && cboTask.SelectedValue != "-1")
            {
                sql += " and t.id=" + cboTask.SelectedValue;
            }
            if (starttime != null && endtime != null)
            {
                sql += " and p.EffectiveTime>" + starttime + " and p.IneffectiveTime<" + endtime;
            }
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            gridControlPlan.DataSource = ds.Tables[0];
        }

        private void bindCboPlan(object start, object end)
        {
            string sql = "Select ID,Name From CheckPlan where PlanState=4"; // 
            if (start != null && end != null)
            {
                sql += " and EffectiveTime>" + start + " and IneffectiveTime<" + end;
            }
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboPlan.DataSource = ds.Tables[0];
        }
        private void bindCboTask(object planID)
        {
            string sql = "select Name From CheckTask where plan_id=" + planID;
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboTask.DataSource = ds.Tables[0];
        }
    }
}
