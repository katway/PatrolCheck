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
    public partial class frmAddPlan_Add : Form
    {
        public frmAddPlan_Add()
        {
            InitializeComponent();
        }
        public DataGridView dgv = null;
        public string planName, planAlias, planRoute, planPost, planInterval, planUnit;
        public DateTime dtStart, dtEnd, dtEffect, dtIneffect;
        public bool isEdit = false;
        public string state = "",planID="";
        private void frmAddPlan_Add_Load(object sender, EventArgs e)
        {
            this.cboInit();
            if (isEdit)
            {
                this.txtName.Text = planName;
                this.txtAlias.Text = planAlias;
                this.txtInterval.Text = planInterval;
                this.cboPost.SelectedText = planPost;
                this.cboRoute.SelectedText = planRoute;
                this.cboUnit.SelectedText = planUnit;
                this.dtpStart.Value = dtStart;
                this.dtpEnd.Value = dtEnd;
                this.dtpEffect.Value = dtEffect;
                this.dtpIneffect.Value = dtIneffect;

                this.Text = "修改计划";
                this.btnSave.Text = "修改";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtInterval.Text.Trim() == "")
            {
                MessageBox.Show("请确保没有空值");
                return;
            }
            if (SqlHelper.ExecuteScalar("Select count(1) From CheckPlan Where Name='" + this.txtName.Text.Trim() + "'").ToString() != "0")
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
            else
            {
                if (dgv != null)
                {
                    frmAddPlan.getDgvPlan(dgv,state);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboInit()
        {
            DataSet ds = SqlHelper.ExecuteDataset("Select Code,Meaning From Codes Where Purpose='IntervalUnit'");
            cboUnit.DataSource = ds.Tables[0];
            cboUnit.DisplayMember = "Meaning";
            cboUnit.ValueMember = "Code";
            cboUnit.SelectedIndex = cboUnit.Items.Count > 0 ? 0 : -1;

            ds.Dispose();
            ds = SqlHelper.ExecuteDataset("Select ID,Site_ID,Name From Post");
            cboPost.DataSource = ds.Tables[0];
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
        }
    }
}
