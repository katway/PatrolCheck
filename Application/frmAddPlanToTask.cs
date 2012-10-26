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
    public partial class frmAddPlanToTask : Form
    {
        public frmAddPlanToTask()
        {
            InitializeComponent();
        }


        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnDown_Click(object sender, EventArgs e)
        {
            string strIDs = "";
            for (int i = 0; i < dgvPlan.Rows.Count; i++)
            {
                if ((bool)dgvPlan.Rows[i].Cells[0].Value == true)
                {
                    strIDs += dgvPlan.Rows[i].Cells[1].Value.ToString() + ",";     
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
            cboState.Items.Add(new BoxItem("全部", ""));
            cboState.Items.Add(new BoxItem("未下发", "4"));
            cboState.Items.Add(new BoxItem("已下发", "8"));
            cboState.SelectedIndex = 0;
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
                                                              where c.PlanState in (" + 4 + ")");
            dgvPlan.DataSource = ds.Tables[0];
        }
        private void getDgvTask()
        {
 
        }

        private void frmAddPlanToTask_Load(object sender, EventArgs e)
        {
            getDgvPlan();
        }
    }
}
