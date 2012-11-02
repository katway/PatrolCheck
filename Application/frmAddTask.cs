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
    public partial class frmAddTask : Form
    {
        public frmAddTask()
        {
            InitializeComponent();
        }

        private void frmAddTask_Load(object sender, EventArgs e)
        {
            this.labPlanID.Text = "";
            this.labState.Text = "";
            cboinit();
            
            this.labState.Text = (this.cboShow.SelectedItem as BoxItem).Value.ToString() == "" ? "0,1,2,4,6,8,16" : (this.cboShow.SelectedItem as BoxItem).Value.ToString();
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
            else
            {
                labPlanID.Text = dgvPlan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dgvPlan.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAlias.Text = dgvPlan.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpStart.Value = Convert.ToDateTime(dgvPlan.Rows[e.RowIndex].Cells[4].Value.ToString());
                dtpEnd.Value = Convert.ToDateTime(dgvPlan.Rows[e.RowIndex].Cells[6].Value.ToString());
                cboPost.SelectedText = dgvPlan.Rows[e.RowIndex].Cells[7].Value.ToString();
                cboRoute.SelectedText = dgvPlan.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtInterval.Text = dgvPlan.Rows[e.RowIndex].Cells[9].Value.ToString();
                cboUnit.SelectedText = dgvPlan.Rows[e.RowIndex].Cells[10].Value.ToString();
                dtpEffect.Value = Convert.ToDateTime(dgvPlan.Rows[e.RowIndex].Cells[11].Value.ToString());
                dtpIneffect.Value = Convert.ToDateTime(dgvPlan.Rows[e.RowIndex].Cells[12].Value.ToString());

            }
        }

        private void cboinit()
        {
            DataSet ds=SqlHelper.ExecuteDataset("Select Code,Meaning From Codes Where Purpose='IntervalUnit'");
            cboUnit.DataSource=ds.Tables[0];
            cboUnit.DisplayMember = "Meaning";
            cboUnit.ValueMember = "Code";
            cboUnit.SelectedIndex = cboUnit.Items.Count > 0 ? 0 : -1;

            ds.Dispose();
            ds = SqlHelper.ExecuteDataset("Select ID,Site_ID,Name From Post");
            cboPost.DataSource=ds.Tables[0];
            cboPost.DisplayMember = "Name";
            cboPost.ValueMember = "ID";
            cboPost.SelectedIndex = cboPost.Items.Count > 0 ? 0 : -1;

            ds.Dispose();
            ds = SqlHelper.ExecuteDataset("Select ID,Name From CheckRoute");
            cboRoute.DataSource = ds.Tables[0];
            cboRoute.DisplayMember = "Name";
            cboRoute.ValueMember = "ID";
            cboRoute.SelectedIndex = cboRoute.Items.Count > 0 ? 0 : -1;

            ds.Dispose();

            SqlDataReader dr = SqlHelper.ExecuteReader("Select Code,Meaning From Codes Where Purpose='PlanState'");
            BoxItem item = null;
            item = new BoxItem("全部","");
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
                                                    co.code as 周期单位,
                                                    c.EffectiveTime as 计划生效时间,
                                                    c.IneffectiveTime as 计划失效时间,
                                                    c.Planner as 计划制定人,
                                                    case c.PlanState  when 0 then '新建'
                                                                      when 1 then '已提交'
                                                                      when 2 then '已审核' 
                                                                      when 4 then '已下发' 
                                                                      when 8 then '过期' 
                                                                      when  '16' then '丢弃' end as 状态
                                                     From Checkplan as  c left join CheckRoute  as r on c.route_id=r.id 
                                                              left join Post p on c.post=p.id 
                                                              left join Codes co on c.IntervalUnit=co.purpose where c.PlanState in ("+labState.Text+")");
            dgvPlan.DataSource=ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtInterval.Text.Trim() == "")
            {
                MessageBox.Show("请确保没有空值");
                return;
            }
            if (SqlHelper.ExecuteScalar("Select count(1) From CheckPlan Where Name='" + this.txtName.Text.Trim() + "'").ToString()!="0")
            {
                MessageBox.Show("请确保计划名称的唯一性");
                return;
            }
            string strInsert = @"Insert into CheckPlan(Name,Alias,StartTime,Duration,EndTime,Post,Route_ID,Interval,IntervalUnit,EffectiveTime,IneffectiveTime,Planner,PlanState) values
                                                      (@Name,@Alias,@StartTime,@Duration,@EndTime,@Post,@Route_ID,@Interval,@IntervalUnit,@EffectiveTime,@IneffectiveTime,@Planner,@PlanState)";
            SqlParameter[] pars = new SqlParameter[] { 
                new SqlParameter("@Name",SqlDbType.VarChar),
                new SqlParameter("@Alias",SqlDbType.VarChar),
                new SqlParameter("@StartTime",SqlDbType.DateTime),
                new SqlParameter("@Duration",SqlDbType.DateTime),
                new SqlParameter("@EndTime",SqlDbType.DateTime),
                new SqlParameter("@Post",SqlDbType.BigInt),
                new SqlParameter("@Route_ID",SqlDbType.BigInt),
                new SqlParameter("@Interval",SqlDbType.Int),
                new SqlParameter("@IntervalUnit",SqlDbType.Char),
                new SqlParameter("@EffectiveTime",SqlDbType.DateTime),
                new SqlParameter("@IneffectiveTime",SqlDbType.DateTime),
                new SqlParameter("@Planner",SqlDbType.Float),
                new SqlParameter("@PlanState",SqlDbType.Int)
            };
            pars[0].Value = this.txtName.Text.Trim();
            pars[1].Value = this.txtAlias.Text.Trim();
            pars[2].Value = this.dtpStart.Value;
            pars[3].Value = this.dtpStart.Value;
            pars[4].Value = this.dtpEnd.Value;
            pars[5].Value = this.cboPost.SelectedValue;
            pars[6].Value = this.cboRoute.SelectedValue;
            pars[7].Value = this.txtInterval.Text.Trim();
            pars[8].Value = this.cboUnit.SelectedValue;
            pars[9].Value = this.dtpEffect.Value;
            pars[10].Value = this.dtpIneffect.Value;
            pars[11].Value = 88888888;
            pars[12].Value = 0;
            if (SqlHelper.ExecuteNonQuery(strInsert, pars) != 1)
            {
                MessageBox.Show("保存失败，请稍后再试！");
            }
            getDgvPlan();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (labPlanID.Text.Trim() == "")
            {
                MessageBox.Show("请选择要修改的项");
                return;
            }
            if (txtName.Text.Trim() == "" || txtInterval.Text.Trim() == "")
            {
                MessageBox.Show("请确保没有空值");
                return;
            }
            if (SqlHelper.ExecuteScalar("Select count(1) From CheckPlan Where Name='" + this.txtName.Text.Trim() + "' and id !="+labPlanID.Text.Trim()).ToString() != "0")
            {
                MessageBox.Show("请确保计划名称的唯一性");
                return;
            }
            string strInsert = "Update CheckPlan Set Name=@Name,Alias=@Alias,StartTime=@StartTime,Duration=@Duration,EndTime=@EndTime,Post=@Post,Route_ID=@Route_ID,Interval=@Interval,IntervalUnit=@IntervalUnit,EffectiveTime=@EffectiveTime,IneffectiveTime=@IneffectiveTime,Planner=@Planner Where ID=@ID and PlanState =0";
            SqlParameter[] pars = new SqlParameter[] { 
                new SqlParameter("@Name",SqlDbType.VarChar),
                new SqlParameter("@Alias",SqlDbType.VarChar),
                new SqlParameter("@StartTime",SqlDbType.DateTime),
                new SqlParameter("@Duration",SqlDbType.DateTime),
                new SqlParameter("@EndTime",SqlDbType.DateTime),
                new SqlParameter("@Post",SqlDbType.BigInt),
                new SqlParameter("@Route_ID",SqlDbType.BigInt),
                new SqlParameter("@Interval",SqlDbType.Int),
                new SqlParameter("@IntervalUnit",SqlDbType.Char),
                new SqlParameter("@EffectiveTime",SqlDbType.DateTime),
                new SqlParameter("@IneffectiveTime",SqlDbType.DateTime),
                new SqlParameter("Planner",SqlDbType.BigInt),
                new SqlParameter("ID",SqlDbType.BigInt)
            };
            pars[0].Value = this.txtName.Text.Trim();
            pars[1].Value = this.txtAlias.Text.Trim();
            pars[2].Value = this.dtpStart.Value;
            pars[3].Value = this.dtpStart.Value;
            pars[4].Value = this.dtpEnd.Value;
            pars[5].Value = this.cboPost.SelectedValue;
            pars[6].Value = this.cboRoute.SelectedValue;
            pars[7].Value = this.txtInterval.Text.Trim();
            pars[8].Value = this.cboUnit.SelectedValue;
            pars[9].Value = this.dtpEffect.Value;
            pars[10].Value = this.dtpIneffect.Value;
            pars[11].Value = 88888888;
            pars[12].Value = this.labPlanID.Text.Trim();
            if (SqlHelper.ExecuteNonQuery(strInsert, pars) != 1)
            {
                MessageBox.Show("保存失败，请稍后再试！");
            }
            getDgvPlan();
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
                getDgvPlan();
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
                getDgvPlan();
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
                getDgvPlan();
            }
            else
            {
                MessageBox.Show("请选择要撤销提交的项");
            }
        }

        private void cboShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labState.Text = (this.cboShow.SelectedItem as BoxItem).Value.ToString() == "" ? "0,1,2,4,6,8,16" : (this.cboShow.SelectedItem as BoxItem).Value.ToString();
            getDgvPlan();
        }

       
    }
}
