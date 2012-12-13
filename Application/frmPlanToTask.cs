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
    public partial class frmPlanToTask : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmPlanToTask()
        {
            InitializeComponent();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            string strIDs = "";
            for (int i = 0; i < gvPlan.RowCount; i++)
            {
                object isCheck = gvPlan.GetRowCellValue(i,"isCheck");
                if (isCheck != null && (bool)isCheck == true)
                {
                    strIDs += gvPlan.GetRowCellValue(i,"ID")+",";
                }
            }
            if (strIDs == "")
            {
                MessageBox.Show("请选择要下发的计划");
                return;
            }
            SqlParameter[] pars = new SqlParameter[] { 
                 new SqlParameter("@PlanIDs",strIDs)
            };
            SqlHelper.ExecuteNonQuery("CreateTask", CommandType.StoredProcedure, pars);
            getDgvPlan();
        }

        private void cboInit()
        {
            cboState.Items.Add(new BoxItem("全部", "8,16"));
            cboState.Items.Add(new BoxItem("未下发", "8"));
            cboState.Items.Add(new BoxItem("已下发", "16"));
            cboState.SelectedIndex = 0;
        }

        private void getDgvPlan()
        {
            DataSet ds = SqlHelper.ExecuteDataset(@"Select 
                                                    c.ID,
                                                    c.Name,
                                                    c.Alias,
                                                    c.StartTime,  
                                                    c.Duration,
                                                    c.EndTime,
                                                    p.Name as PostName,
                                                    p.ID as PostID,
                                                    r.Name as RouteName, 
                                                    r.ID as RouteID,
                                                    (select name from employee where id=c.operator) as OperatorName,
                                                    c.operator as OperatorID,
                                                    c.Interval,
                                                    c.TimeDeviation,
                                                    (select meaning from codes where code= IntervalUnit and purpose='intervalunit') as IntervalUnit,
                                                    c.intervalunit as IntervalUnitID,
                                                    c.EffectiveTime,
                                                    c.IneffectiveTime,
                                                    c.Planner,
                                                    (select meaning from codes where code= planstate and purpose='planstate') as 状态 
                                                     From Checkplan as  c left join CheckRoute  as r on c.route_id=r.id 
                                                              left join Post p on c.post=p.id 
                                                              where c.PlanState in (" + labState.Text + ")");
            ds.Tables[0].Columns.Add(new DataColumn("isCheck", typeof(System.Boolean)));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["isCheck"] = false;
            }
            gridControlPlan.DataSource = ds.Tables[0];
        }

        private void getDgvTask(string planid)
        {
            DataSet ds = SqlHelper.ExecuteDataset(@"Select 
                                                    c.ID as 任务编号,
                                                    c.Name as 任务名称,
                                                    c.Alias as 别名,
                                                    c.StartTime as 任务开始时间,  
                                                    c.Duration as 持续时间,
                                                    c.EndTime as 任务结束时间,
                                                    p.Name as 指派岗位,
                                                    r.Name as 路线, 
                                                    c.Interval as 周期,
                                                    (select meaning from codes where code= c.IntervalUnit and purpose='intervalunit') as 周期单位,
                                                    c.EffectiveTime as 任务生效时间,
                                                    c.IneffectiveTime as 任务失效时间 
                                                     From Checktask as  c left join CheckRoute  as r on c.route_id=r.id 
                                                              left join Post p on c.post=p.id 
                                                              left join checkplan pn on c.plan_id=pn.id 
                                                              where c.plan_id="+planid);
            gridControlTask.DataSource = ds.Tables[0];
        }

        private void frmAddPlanToTask_Load(object sender, EventArgs e)
        {
            this.labState.Visible = false;
            cboInit();
            getDgvPlan();
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            labState.Text = (cboState.SelectedItem as BoxItem).Value.ToString();
            switch ((cboState.SelectedItem as BoxItem).Value.ToString())
            {
                case "8,16":
                case "8":
                    {
                        this.btnDown.Enabled = true;
                        break;
                    }
                case "16":
                    {
                        this.btnDown.Enabled = false;
                        break;
                    }
            }
            getDgvPlan();
        }

        private void gvPlan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            getDgvTask(gvPlan.GetRowCellValue(e.RowHandle,"ID").ToString());
        }

      
    }
}
