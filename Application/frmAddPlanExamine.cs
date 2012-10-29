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
    public partial class frmAddPlanExamine : Form
    {
        public frmAddPlanExamine()
        {
            InitializeComponent();
        }

        private void frmAddPlanExamine_Load(object sender, EventArgs e)
        {
            cboInit();
            this.labState.Text = (this.cboState.SelectedItem as BoxItem).Value.ToString() == "" ? "0,1,2,4" : (this.cboState.SelectedItem as BoxItem).Value.ToString();
            getDgvPlan();
        }

        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 0)
            {
                if ((bool)dgvPlan.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
                {
                    dgvPlan.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgvPlan.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            string id = "";
            string update = "Update checkplan set planstate=4 where id in (";
            for (int i = 0; i < dgvPlan.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvPlan.Rows[i].Cells[0].Value == true)
                    {
                        id += dgvPlan.Rows[i].Cells[1].Value+",";
                    }
                }
                catch
                {
                    continue;
                }
            }

            if (id != "")
            {
                id = id.Substring(0, id.Length - 1);
                update += id + ") and planstate=1";
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
            string update = "Update checkplan set planstate=2 where id in (";
            for (int i = 0; i < dgvPlan.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvPlan.Rows[i].Cells[0].Value == true)
                    {
                        id += dgvPlan.Rows[i].Cells[1].Value + ",";
                    }
                }
                catch
                {
                    continue;
                }
            }

            if (id != "")
            {
                id = id.Substring(0, id.Length - 1);
                update += id + ") and planstate=1";
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

        private void getDgvPlan()
        {
            DataSet ds = SqlHelper.ExecuteDataset(@"Select 
                                                    c.ID as 计划编号,
                                                    c.Name as 计划名称,
                                                    c.Alias as 别名,
                                                    c.StartTime as 计划开始时间,  
                                                    c.Duration as 持续时间,
                                                    c.EndTime as 计划结束时间,
                                                    p.Name as 指派岗位,
                                                    r.Name as 路线, 
                                                    c.Interval as 周期,
                                                    (select meaning from codes where code= IntervalUnit and purpose='intervalunit') as 周期单位,
                                                    c.EffectiveTime as 计划生效时间,
                                                    c.IneffectiveTime as 计划失效时间,
                                                    c.Planner as 计划制定人,
                                                    (select meaning from codes where code= planstate and purpose='planstate') as 状态 
                                                     From Checkplan as  c left join CheckRoute  as r on c.route_id=r.id 
                                                              left join Post p on c.post=p.id 
                                                              where c.PlanState in (" + this.labState.Text + ")");
            dgvPlan.DataSource = ds.Tables[0];
        }

        private void cboInit()
        {
            cboState.Items.Add(new BoxItem("全部", ""));
            cboState.Items.Add(new BoxItem("已提交", "1"));
            cboState.Items.Add(new BoxItem("已审核", "4"));
            cboState.Items.Add(new BoxItem("未通过", "2"));
            cboState.SelectedIndex = 0;
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labState.Text = (this.cboState.SelectedItem as BoxItem).Value.ToString() == "" ? "0,1,2,4" : (this.cboState.SelectedItem as BoxItem).Value.ToString();
            switch ((cboState.SelectedItem as BoxItem).Value.ToString())
            {
                case "":
                case "2":
                case "4":
                    {
                        this.btnPass.Enabled = false;
                        this.btnUnpass.Enabled = false;
                        break;
                    }
                case "1":
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
