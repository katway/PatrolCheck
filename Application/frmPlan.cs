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

namespace WorkStation
{
    public partial class frmPlan : Form
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
            this.labState.Text = (this.cboShow.SelectedItem as BoxItem).Value.ToString() == "" ? "0,1,2,4,6,8,16" : (this.cboShow.SelectedItem as BoxItem).Value.ToString();
            switch((this.cboShow.SelectedItem as BoxItem).Value.ToString())
            {
                case "":
                    {
                        this.btnNew.Enabled = false;
                        this.btnEdit.Enabled = false;
                        this.btnDel.Enabled = false;
                        this.btnSubmit.Enabled = false;
                        this.btnUnSub.Enabled = false;
                        break;
                    }
                case "0":
                    {
                        this.btnNew.Enabled = true;
                        this.btnEdit.Enabled = true;
                        this.btnDel.Enabled = true;
                        this.btnSubmit.Enabled = true;
                        this.btnUnSub.Enabled = false;
                        break;
                    }
                case "1":
                    {
                        this.btnNew.Enabled = false;
                        this.btnEdit.Enabled = false;
                        this.btnDel.Enabled = false;
                        this.btnSubmit.Enabled = false;
                        this.btnUnSub.Enabled = true;
                        break;
                    }
                case "2":
                    {
                        this.btnNew.Enabled = false;
                        this.btnEdit.Enabled = true;
                        this.btnDel.Enabled = true;
                        this.btnSubmit.Enabled = true;
                        this.btnUnSub.Enabled = false;
                        break;
                    }
                case"4":
                case"8":
                case"16":
                case "32":
                    {
                        this.btnNew.Enabled = false;
                        this.btnEdit.Enabled = false;
                        this.btnDel.Enabled = false;
                        this.btnSubmit.Enabled = false;
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
                strsql += Del + ") and PlanState=0";
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
            string strUpdae = "Update CheckPlan Set PlanState=1 where Id in(";
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
                strUpdae += update + ") and PlanState=0";
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
            string strUpdae = "Update CheckPlan Set PlanState=0 where Id in(";
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
                strUpdae += update + ") and PlanState=1";
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
            SqlDataReader dr = SqlHelper.ExecuteReader("Select Code,Meaning From Codes Where Purpose='PlanState'");
            BoxItem item = null;
            item = new BoxItem("全部", "");
            cboShow.Items.Add(item);
            while (dr.Read())
            {
                item = new BoxItem();
                item.Text = dr["Meaning"].ToString();
                item.Value = dr["Code"].ToString();
                cboShow.Items.Add(item);
            }
            dr.Dispose();
            cboShow.SelectedIndex = cboShow.Items.Count > 0 ? 0 : -1;
        }

    }
}
