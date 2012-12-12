using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace WorkStation
{
    public partial class frmPlanExamine : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmPlanExamine()
        {
            InitializeComponent();
        }

        private void frmAddPlanExamine_Load(object sender, EventArgs e)
        {
            cboInit();
            this.labState.Text = (this.cboState.SelectedItem as BoxItem).Value.ToString() == "" ? "1,2,4" : (this.cboState.SelectedItem as BoxItem).Value.ToString();
            getDgvPlan();
        }
        private void btnPass_Click(object sender, EventArgs e)
        {
            string id = "";
            string update = "Update checkplan set planstate=8 where id in (";
            for (int i = 0; i < gvPlan.RowCount; i++)
            {
                object isCheck = gvPlan.GetRowCellValue(i, "isCheck");
                if (isCheck != null && (bool)isCheck == true)
                {
                    id += gvPlan.GetRowCellValue(i, "ID") + ",";
                }
            }

            if (id != "")
            {
                id = id.Substring(0, id.Length - 1);
                update += id + ") and planstate=2";
                if (SqlHelper.ExecuteNonQuery(update) == 0)
                {
                    MessageBox.Show("审核失败");
                }
            }
            else
            {
                MessageBox.Show("请选择要审核的项");
            }
            getDgvPlan();
        }

        private void btnUnpass_Click(object sender, EventArgs e)
        {
            string id = "";
            string update = "Update checkplan set planstate=4 where id in (";
            for (int i = 0; i < gvPlan.RowCount; i++)
            {
                object isCheck = gvPlan.GetRowCellValue(i, "isCheck");
                if (isCheck!=null&&(bool)isCheck == true)
                {
                    id += gvPlan.GetRowCellValue(i,"ID")+",";
                }
            }

            if (id != "")
            {
                id = id.Substring(0, id.Length - 1);
                update += id + ") and planstate=2";
                if (SqlHelper.ExecuteNonQuery(update) == 0)
                {
                    MessageBox.Show("审核失败");
                }
            }
            else
            {
                MessageBox.Show("请选择要审核的项");
            }
            getDgvPlan();
        }

        public  void getDgvPlan()
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

        private void cboInit()
        {
            cboState.Items.Add(new BoxItem("全部", "2,4,8"));
            cboState.Items.Add(new BoxItem("请求审核", "2"));
            cboState.Items.Add(new BoxItem("审核通过", "8"));
            cboState.Items.Add(new BoxItem("否决", "4"));
            cboState.SelectedIndex = 0;
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            labState.Text = (cboState.SelectedItem as BoxItem).Value.ToString();
            switch ((cboState.SelectedItem as BoxItem).Value.ToString())
            {
                case "2,4,8":
                case "4":
                case "8":
                    {
                        this.btnPass.Enabled = false;
                        this.btnUnpass.Enabled = false;
                        break;
                    }
                case "2":
                    {
                        this.btnPass.Enabled = true;
                        this.btnUnpass.Enabled = true;
                        break;
                    }
            }
            getDgvPlan();
        }
    }
}
