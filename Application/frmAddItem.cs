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
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            this.labID.Text = "";
            bkwItem.RunWorkerAsync();
            bindDgvItems();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboMachine.SelectedValue.ToString() == "")
            {
                MessageBox.Show("请选择所属机器");
                return;
            }
            if (cboPoint.SelectedValue==null)
            {
                MessageBox.Show("请选择所属地点");
                return;
            }
            if (SqlHelper.ExecuteScalar("Select count(1) From CheckItem Where Name='" + this.txtName.Text.Trim() + "'").ToString() != "0")
            {
                MessageBox.Show("请确保名称的唯一性");
                return;
            }
            string str_insert = "Insert into CheckItem([Name],Alias,Machine_ID,ValueType,Phy_ID,Comment) Values(@name,@alias,@machineid,@valuetype,@pointid,@comment)";
            SqlParameter[] pars = new SqlParameter[]{
                new SqlParameter("@name",SqlDbType.NVarChar),
                new SqlParameter("@alias",SqlDbType.NVarChar),
                new SqlParameter("@machineid",SqlDbType.Int),
                new SqlParameter("@valuetype",SqlDbType.Int),
                new SqlParameter("@pointid",SqlDbType.Int),
                new SqlParameter("@comment",SqlDbType.NText)
            };
            pars[0].Value = this.txtName.Text.ToString().Trim();
            pars[1].Value = this.txtAlias.Text.ToString().Trim();
            pars[2].Value = this.cboMachine.SelectedValue;
            pars[3].Value = this.cboValue.SelectedValue;
            pars[4].Value = this.cboPoint.SelectedValue;
            pars[5].Value = this.txtRemarks.Text;

            int _ret = SqlHelper.ExecuteNonQuery(str_insert,pars);
            if (_ret == 1)
            {
                MessageBox.Show("保存成功");
            }
            bindDgvItems();
        }   

        private void bindDgvItems()
        {
            string str_select = @"select 
                        c.ID as 编号,
                        c.name as 名称,
                        c.alias as 别名,
                        (select meaning from codes where code=c.valuetype and purpose='valuetype') as 值类型,
                        m.name as 所属机器,
                        p.name as 所属巡检点,
                        c.comment as 备注 
                        from checkitem c,Machine m,PhysicalCheckPoint p 
                        where c.machine_id=m.id and c.Phy_ID=p.id ";
            DataSet ds = SqlHelper.ExecuteDataset(str_select);
            dgvItems.DataSource=ds.Tables[0];
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            labID.Text = dgvItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvItems.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAlias.Text = dgvItems.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboValue.Text = dgvItems.Rows[e.RowIndex].Cells[4].Value.ToString();
            cboMachine.Text = dgvItems.Rows[e.RowIndex].Cells[5].Value.ToString();
            cboPoint.Text = dgvItems.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtRemarks.Text = dgvItems.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                if ((bool)dgvItems.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
                {
                    dgvItems.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (labID.Text == "")
            {
                return;
            }
            if (cboMachine.SelectedValue.ToString() == "")
            {
                MessageBox.Show("请选择所属机器");
                return;
            }
            if (cboPoint.SelectedValue.ToString() == "")
            {
                MessageBox.Show("请选择所属地点");
                return;
            }
            if (SqlHelper.ExecuteScalar("Select count(1) From CheckItem Where id!=" + labID.Text.Trim() + " and name='" + this.txtName.Text.Trim() + "'").ToString() != "0")
            {
                MessageBox.Show("请确保名称的唯一性" );
                return;
            }
            string str_insert = "Update CheckItem set [Name]=@name,Alias=@alias,Machine_ID=@machineid,ValueType=@valuetype,Phy_ID=@phyid,Comment=@comment where ID=" + labID.Text.Trim();
            SqlParameter[] pars = new SqlParameter[]{
                new SqlParameter("@name",SqlDbType.NVarChar),
                new SqlParameter("@alias",SqlDbType.NVarChar),
                new SqlParameter("@machineid",SqlDbType.Int),
                new SqlParameter("@valuetype",SqlDbType.Int),
                new SqlParameter("@phyid",SqlDbType.Int),
                new SqlParameter("@comment",SqlDbType.NText)
            };
            pars[0].Value = this.txtName.Text.ToString().Trim();
            pars[1].Value = this.txtAlias.Text.ToString().Trim();
            pars[2].Value = this.cboMachine.SelectedValue;
            pars[3].Value = this.cboValue.SelectedValue ;
            pars[4].Value = this.cboPoint.SelectedValue;
            pars[5].Value = this.txtRemarks.Text;

            int _ret = SqlHelper.ExecuteNonQuery(str_insert, pars);
            if (_ret == 1)
            {
                MessageBox.Show("保存成功");
            }
            bindDgvItems();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {   
            string Del = "";
            string strsql = "Delete From CheckItem Where ID in(";
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvItems.Rows[i].Cells[0].Value == true)
                    {
                        Del += dgvItems.Rows[i].Cells[1].Value.ToString() + ",";
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
                strsql += Del + ")";
                SqlHelper.ExecuteNonQuery(strsql);
                bindDgvItems();
            }
            else
            {
                MessageBox.Show("请选择要删除的项");
            }
        }

        DataSet dsMachine, dsValueType, dsPoint;
        private void bkwItem_DoWork(object sender, DoWorkEventArgs e)
        {
            dsMachine = SqlHelper.ExecuteDataset("select ID,Name From Machine");
            dsValueType = SqlHelper.ExecuteDataset("Select Code,Meaning From Codes where Purpose='ValueType'");
            dsPoint = SqlHelper.ExecuteDataset("select ID,Name From PhysicalCheckPoint");
        }

        private void bkwItem_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.cboMachine.DataSource = dsMachine.Tables[0];
            this.cboMachine.DisplayMember = "Name";
            this.cboMachine.ValueMember = "ID";
            this.cboMachine.SelectedIndex = cboMachine.Items.Count > 0 ? 0 : -1;
            dsMachine.Dispose();

            this.cboPoint.DataSource = dsPoint.Tables[0];
            this.cboPoint.DisplayMember = "Name";
            this.cboPoint.ValueMember = "ID";
            this.cboPoint.SelectedIndex = cboPoint.Items.Count > 0 ? 0 : -1;
            dsPoint.Dispose();

            this.cboValue.DataSource = dsValueType.Tables[0];
            this.cboValue.DisplayMember = "Meaning";
            this.cboValue.ValueMember = "Code";
            this.cboValue.SelectedIndex = cboMachine.Items.Count > 0 ? 0 : -1;
            dsValueType.Dispose();
        }
    }
}
