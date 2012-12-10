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
            getDgvPlan(this.dgvPlan,this.labState.Text);
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
                case"4" :
                case"8" :
                case"16":
                case"32":
                    {
                        this.btnNew.Enabled = false;
                        this.btnEdit.Enabled = false;
                        this.btnDel.Enabled = false;
                        this.btnSubmit.Enabled = false;
                        this.btnUnSub.Enabled = false;
                        break;
                    }

            }
            getDgvPlan(this.dgvPlan,this.labState.Text);
        }      

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmPlanAdd add = new frmPlanAdd(); 
            add.Left = this.Left + (this.Width - add.Width) / 2;
            add.Top = this.Top +(this.Height - add.Height) / 2;
            add.dgv = this.dgvPlan;
            add.state = this.labState.Text;
            add.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int count = 0,rowindex=0;
            for (int i = 0; i < dgvPlan.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvPlan.Rows[i].Cells[0].Value == true)
                    {
                        count++;
                        rowindex = i;
                    }
                }
                catch
                {
                    continue;
                }
            }
            if (count !=1)
            {
                MessageBox.Show("请选择一个要编辑的计划"); return;                             
            }
            frmPlanAdd add = new frmPlanAdd();
            add.Left = this.Left + (this.Width - add.Width) / 2;
            add.Top = this.Top + (this.Height - add.Height) / 2;
            add.isEdit = true;
            add.dgv = this.dgvPlan;
            add.state = this.labState.Text;
            add.planID = dgvPlan.Rows[rowindex].Cells[1].Value.ToString();
            add.planName = dgvPlan.Rows[rowindex].Cells[2].Value.ToString();
            add.planAlias = dgvPlan.Rows[rowindex].Cells[3].Value.ToString();
            add.dtStart = Convert.ToDateTime(dgvPlan.Rows[rowindex].Cells[4].Value);
            add.dtEnd = Convert.ToDateTime(dgvPlan.Rows[rowindex].Cells[6].Value);
            add.planPost = dgvPlan.Rows[rowindex].Cells[7].Value.ToString();
            add.planRoute = dgvPlan.Rows[rowindex].Cells[8].Value.ToString();
            add.planInterval = dgvPlan.Rows[rowindex].Cells[9].Value.ToString();
            add.planUnit = dgvPlan.Rows[rowindex].Cells[10].Value.ToString();
            add.dtEffect = Convert.ToDateTime(dgvPlan.Rows[rowindex].Cells[11].Value);
            add.dtIneffect = Convert.ToDateTime(dgvPlan.Rows[rowindex].Cells[12].Value);
            add.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string Del = "";
            string strsql = "Delete From CheckPlan Where ID in(";
            for (int i = 0; i < dgvPlan.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvPlan.Rows[i].Cells[0].Value == true)
                    {
                        Del += dgvPlan.Rows[i].Cells[1].Value.ToString() + ",";
                    }
                }
                catch
                {                
                    continue;
                }
            }
            if (Del != "")
            {
                Del = Del.Substring(0, Del.Length - 1);
                strsql += Del + ") and PlanState=0";
                SqlHelper.ExecuteNonQuery(strsql);
                getDgvPlan(dgvPlan,this.labState.Text);
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
            for (int i = 0; i < dgvPlan.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvPlan.Rows[i].Cells[0].Value == true)
                    {
                        update += dgvPlan.Rows[i].Cells[1].Value.ToString() + ",";
                    }
                }
                catch
                {
                    continue;
                }
            }
            if (update != "")
            {
                update = update.Substring(0, update.Length - 1);
                strUpdae += update + ") and PlanState=0";
                SqlHelper.ExecuteNonQuery(strUpdae);
                getDgvPlan(dgvPlan, this.labState.Text);
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
            for (int i = 0; i < dgvPlan.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvPlan.Rows[i].Cells[0].Value == true)
                    {
                        update += dgvPlan.Rows[i].Cells[1].Value.ToString() + ",";
                    }
                }
                catch
                {
                    continue;
                }
            }
            if (update != "")
            {
                update = update.Substring(0, update.Length - 1);
                strUpdae += update + ") and PlanState=1";
                SqlHelper.ExecuteNonQuery(strUpdae);
                getDgvPlan(dgvPlan, this.labState.Text);
            }
            else
            {
                MessageBox.Show("请选择要撤销提交的项");
            }
        }

        public static void getDgvPlan(DataGridView dgv, string labState)
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
                                                              where c.PlanState in (" + labState + ")");
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

        private void btnControl()
        {
 
        }
        private void dgvPlan_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex<0||btnEdit.Enabled==false) return;
            frmPlanAdd add = new frmPlanAdd();
            add.Left = this.Left + (this.Width - add.Width) / 2;
            add.Top = this.Top + (this.Height - add.Height) / 2;
            add.isEdit = true;
            add.dgv = this.dgvPlan;
            add.state = this.labState.Text;
            add.planID = dgvPlan.Rows[e.RowIndex].Cells[1].Value.ToString();
            add.planName = dgvPlan.Rows[e.RowIndex].Cells[2].Value.ToString();
            add.planAlias = dgvPlan.Rows[e.RowIndex].Cells[3].Value.ToString();
            add.dtStart = Convert.ToDateTime(dgvPlan.Rows[e.RowIndex].Cells[4].Value);
            add.dtEnd = Convert.ToDateTime(dgvPlan.Rows[e.RowIndex].Cells[6].Value);
            add.planPost = dgvPlan.Rows[e.RowIndex].Cells[7].Value.ToString();
            add.planRoute = dgvPlan.Rows[e.RowIndex].Cells[8].Value.ToString();
            add.planInterval = dgvPlan.Rows[e.RowIndex].Cells[9].Value.ToString();
            add.planUnit = dgvPlan.Rows[e.RowIndex].Cells[10].Value.ToString();
            add.dtEffect = Convert.ToDateTime(dgvPlan.Rows[e.RowIndex].Cells[11].Value);
            add.dtIneffect = Convert.ToDateTime(dgvPlan.Rows[e.RowIndex].Cells[12].Value);   
            add.ShowDialog();
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
    }
}
