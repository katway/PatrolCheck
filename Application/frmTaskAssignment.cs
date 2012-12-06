using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;

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
            bindCboPlan(null,null);
            SqlDataReader dr = SqlHelper.ExecuteReader("select e.name as OperatorName,e.id as OperatorID from post_employee pe left join employee e on pe.employee_id=e.id where e.validstate=1" );
            while (dr.Read())
            {
                repositoryItemImageComboBox1.Items.Add(new ImageComboBoxItem(dr["OperatorName"].ToString(), dr["OperatorID"], 0));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getDgvTask(dtpStart.Value, dtpEnd.Value);
        }
       
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            bindCboPlan(null, null);
            getDgvTask(null, null);
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
                cboTask.Items.Clear();
                cboTask.Items.Add("全部");
                cboTask.SelectedIndex = 0;
            }
        }

        DataSet dsGvSource=null;
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
                    From checktask t left join checkplan p on t.plan_id=p.id Where p.planstate=16";
            if (cboPlan.SelectedValue != null && cboPlan.SelectedValue.ToString() != "-1")
            {
                sql += " and t.plan_id=" + cboPlan.SelectedValue;
            }
            if (cboTask.SelectedValue != null && cboTask.SelectedValue.ToString() != "-1")
            {
                sql += " and t.id=" + cboTask.SelectedValue;
            }
            if (starttime != null && endtime != null)
            {
                sql += " and p.EffectiveTime>'" + starttime + "' and p.IneffectiveTime<'" + endtime+"'";
            }
            dsGvSource=new DataSet ();
            dsGvSource = SqlHelper.ExecuteDataset(sql);
            gridControlPlan.DataSource = dsGvSource.Tables[0];
        }

        private void bindCboPlan(object start, object end)
        {
            string sql = "Select ID,Name From CheckPlan where PlanState=16"; // 
            if (start != null && end != null)
            {
                sql += " and EffectiveTime>'" + start + "' and IneffectiveTime<'" + end+"'";
            }
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboPlan.ValueMember = "ID";
            cboPlan.DisplayMember = "Name";
            cboPlan.DataSource = ds.Tables[0];
        }
        private void bindCboTask(object planID)
        {
            string sql = "select ID,Name From CheckTask where plan_id=" + planID;
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1;
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboTask.ValueMember = "ID";
            cboTask.DisplayMember = "Name";
            cboTask.DataSource = ds.Tables[0];
        }

        private void gvPlan_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "OperatorID")
            {
                object postid = gvPlan.GetRowCellValue(1, "PostID");
                SqlDataReader dr = SqlHelper.ExecuteReader("select e.name as OperatorName,e.id as OperatorID from post_employee pe left join employee e on pe.employee_id=e.id where pe.post_id=" + postid);
                repositoryItemImageComboBox2_Edit.Items.Clear();
                while (dr.Read())
                {
                    repositoryItemImageComboBox2_Edit.Items.Add(new ImageComboBoxItem(dr["OperatorName"].ToString(), dr["OperatorID"], 0));
                }
                e.RepositoryItem= repositoryItemImageComboBox2_Edit;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable tbChange = dsGvSource.Tables[0].GetChanges();
            if (tbChange == null)
                return;
            string[] strSqls=new string[tbChange.Rows.Count];
            for (int i = 0; i < tbChange.Rows.Count; i++)
            {
                strSqls[i] = "Update CheckTask Set Operator="+tbChange.Rows[i]["OperatorID"] +" Where ID="+tbChange.Rows[i]["ID"];
            }
            int _ret =SqlHelper.ExecuteSqls(strSqls);
            if (_ret != 0)
            {
                MessageBox.Show("保存成功");
            }
            dsGvSource.AcceptChanges();
        }
    }
}
