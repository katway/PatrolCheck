using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using WeifenLuo.WinFormsUI.Docking;

namespace WorkStation
{
    public partial class frmPlan : DockContent
    {
        public frmPlan()
        {
            InitializeComponent();
        }

        private void frmAddPlan_Load(object sender, EventArgs e)
        {
            this.labState.Text = "";
            cboInit();
            getDgvPlan(this.gridControlPlan,this.labState.Text);
        }
        private void cboShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShow.SelectedValue == null) return;
            this.labState.Text = cboShow.SelectedValue.ToString() == "-1" ? "1,2,4,6,8,16,32" : cboShow.SelectedValue.ToString();
            switch(this.cboShow.SelectedValue.ToString())
            {
                case "-1":
                case "8"://通过
                case "16"://已下发
                case "32"://丢弃
                    {
                        this.btnNew.Enabled = false;
                        this.btnEdit.Enabled = false;
                        this.btnDel.Enabled = false;
                        this.btnSubmit.Enabled = false;
                        this.btnUnSub.Enabled = false;
                        break;
                    }
                case "1": //新建
                    {
                        this.btnNew.Enabled = true;
                        this.btnEdit.Enabled = true;
                        this.btnDel.Enabled = true;
                        this.btnSubmit.Enabled = true;
                        this.btnUnSub.Enabled = false;
                        break;
                    }
                case "2"://提交 请求审核
                    {
                        this.btnNew.Enabled = false;
                        this.btnEdit.Enabled = false;
                        this.btnDel.Enabled = false;
                        this.btnSubmit.Enabled = false;
                        this.btnUnSub.Enabled = true;
                        break;
                    }
                case "4": //未通过 否决
                    {
                        this.btnNew.Enabled = false;
                        this.btnEdit.Enabled = true;
                        this.btnDel.Enabled = true;
                        this.btnSubmit.Enabled = true;
                        this.btnUnSub.Enabled = false;
                        break;
                    }

            }
            getDgvPlan(gridControlPlan, this.labState.Text);
        }      

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmPlanAdd add = new frmPlanAdd();
            add.Left = this.Left + (this.Width - add.Width) / 2;
            add.Top = this.Top +(this.Height - add.Height) / 2;
            add.dgv = this.gridControlPlan;
            add.state = this.labState.Text;
            add.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowindex = gvPlan.FocusedRowHandle;
            if ( rowindex < 0)
            {
                MessageBox.Show("请选择一个要编辑的计划");
                return;
            }
            frmPlanAdd add = new frmPlanAdd();
            add.Left = this.Left + (this.Width - add.Width) / 2;
            add.Top = this.Top + (this.Height - add.Height) / 2;
            add.isEdit = true;
            add.dgv = this.gridControlPlan;
            add.state = this.labState.Text;

            add.planID = gvPlan.GetRowCellValue(rowindex, "ID").ToString();
            add.planName = gvPlan.GetRowCellValue(rowindex, "Name").ToString();
            add.planAlias = gvPlan.GetRowCellValue(rowindex, "Alias").ToString();
            add.dtStart = Convert.ToDateTime(gvPlan.GetRowCellValue(rowindex, "StartTime"));
            add.planDuration = gvPlan.GetRowCellValue(rowindex, "Duration").ToString();
            add.planTimeDeviation = gvPlan.GetRowCellValue(rowindex, "TimeDeviation").ToString();
            add.dtEnd = Convert.ToDateTime(gvPlan.GetRowCellValue(rowindex, "EndTime"));
            add.planPostID = gvPlan.GetRowCellValue(rowindex, "PostID").ToString();
            add.planOperatorID = gvPlan.GetRowCellValue(rowindex, "OperatorID").ToString();
            add.planRouteID = gvPlan.GetRowCellValue(rowindex, "RouteID").ToString();
            add.planInterval = gvPlan.GetRowCellValue(rowindex, "Interval").ToString();
            add.planIntervalUnitID = gvPlan.GetRowCellValue(rowindex, "IntervalUnitID").ToString();
            add.dtEffect = Convert.ToDateTime(gvPlan.GetRowCellValue(rowindex, "EffectiveTime"));
            add.dtIneffect = Convert.ToDateTime(gvPlan.GetRowCellValue(rowindex, "IneffectiveTime"));      

            add.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string Del = "";
            string strsql = "Delete From CheckPlan Where ID in(";
            for (int i = 0; i < gvPlan.RowCount; i++)
            {
                object isCheck = gvPlan.GetRowCellValue(i,"isCheck");
                if ((bool)isCheck == true)
                {
                    Del += gvPlan.GetRowCellValue(i,"ID")+",";
                }
            }
            if (Del != "")
            {
                Del = Del.Substring(0, Del.Length - 1);
                strsql += Del + ") and PlanState in (1,4)";//状态为1和4的可以删除
                SqlHelper.ExecuteNonQuery(strsql);
                getDgvPlan(gridControlPlan, this.labState.Text);
            }
            else
            {
                MessageBox.Show("请选择要删除的项。");
            }            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string update = "";
            string strUpdae = "Update CheckPlan Set PlanState=2 where Id in(";
            for (int i = 0; i < gvPlan.RowCount; i++)
            {
                object isCheck = gvPlan.GetRowCellValue(i, "isCheck");
                if ((bool)isCheck == true)
                {
                    update += gvPlan.GetRowCellValue(i,"ID")+",";
                }
            }
            if (update != "")
            {
                update = update.Substring(0, update.Length - 1);
                strUpdae += update + ") and PlanState in (1,4)";//状态为1.新建4.否决的可以提交
                SqlHelper.ExecuteNonQuery(strUpdae);
                getDgvPlan(gridControlPlan, this.labState.Text);
            }
            else
            {
                MessageBox.Show("请选择要提交的项");
            }
        }

        private void btnUnSub_Click(object sender, EventArgs e)
        {
            string update = "";
            string strUpdae = "Update CheckPlan Set PlanState=1 where Id in(";
            for (int i = 0; i < gvPlan.RowCount; i++)
            {
                object isCheck = gvPlan.GetRowCellValue(i, "isCheck");
                if ((bool)isCheck == true)
                {
                    update += gvPlan.GetRowCellValue(i, "ID") + ",";
                }
            }
            if (update != "")
            {
                update = update.Substring(0, update.Length - 1);
                strUpdae += update + ") and PlanState=2";
                SqlHelper.ExecuteNonQuery(strUpdae);
                getDgvPlan(gridControlPlan, this.labState.Text);
            }
            else
            {
                MessageBox.Show("请选择要撤销提交的项");
            }
        }

        public static void getDgvPlan(GridControl dgv, string labState)
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
                                                              where c.PlanState in (" + labState + ")");
            ds.Tables[0].Columns.Add(new DataColumn("isCheck",typeof(System.Boolean)));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["isCheck"] = false;
            }
            dgv.DataSource = ds.Tables[0];
        }

        private void cboInit()
        {
            DataSet ds = SqlHelper.ExecuteDataset("Select Code,Meaning From Codes Where Purpose='PlanState'");
            DataRow dr=ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr,0);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["Code"].ToString() == "0")
                {
                    ds.Tables[0].Rows.RemoveAt(i);
                    break;
                }
            }
            
            cboShow.DisplayMember = "Meaning";
            cboShow.ValueMember = "Code";
            cboShow.DataSource=ds.Tables[0];
        }


    }
}
