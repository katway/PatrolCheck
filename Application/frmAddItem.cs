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
            getMachine();
            getValueType();
            getPoint();
            bindDgvItems();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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

            string str_insert = "Insert into CheckItem([Name],Alias,Machine_ID,ValueType,LogicalPoint_ID,Comment) Values(@name,@alias,@machineid,@valuetype,@pointid,@comment)";
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
            pars[3].Value = ((BoxItem)this.cboValue.SelectedItem).Value;
            pars[4].Value = this.cboPoint.SelectedValue;
            pars[5].Value = this.txtRemarks.Text;

            int _ret = SqlHelper.ExecuteNonQuery(str_insert,pars);
            if (_ret == 1)
            {
                MessageBox.Show("保存成功");
            }
            bindDgvItems();
        }
        
        private void getMachine()
        {
            DataSet ds= SqlHelper.ExecuteDataset("select ID,Name From Machine");
            this.cboMachine.DataSource=ds.Tables[0];
            this.cboMachine.DisplayMember = "Name";
            this.cboMachine.ValueMember = "ID";
            this.cboMachine.SelectedIndex = cboMachine.Items.Count>0?0:-1;
        }
        private void getValueType()
        {
            BoxItem bi1 = new BoxItem();
            bi1.Text = "正常/不正常";
            bi1.Value = "0";
            this.cboValue.Items.Add(bi1);
            BoxItem bi2 = new BoxItem();
            bi2.Text = "数值";
            bi2.Value = "1";
            this.cboValue.Items.Add(bi2);
            this.cboValue.SelectedIndex = cboMachine.Items.Count > 0 ? 0 : -1;
        }
        private void getPoint()
        {
            DataSet ds = SqlHelper.ExecuteDataset("select ID,Name From PhysicalCheckPoint");
            this.cboPoint.DataSource=ds.Tables[0];
            this.cboPoint.DisplayMember = "Name";
            this.cboPoint.ValueMember = "ID";
            this.cboPoint.SelectedIndex = cboMachine.Items.Count > 0 ? 0 : -1;
        }

        private void bindDgvItems()
        {
            string str_select =@"select 
                        c.ID as 编号,
                        c.name as 名称,
                        c.alias as 别名,
                        (case c.ValueType when  0 then '正常/不正常' when 1 then '数值' end) as 值类型,
                        m.name as 所属机器,
                        l.name as 所属巡检点,
                        c.comment as 备注 
                        from checkitem c,Machine m,LogicalCheckPoint l 
                        where c.machine_id=m.id and c.LogicalPoint_ID=l.id ";
            DataSet ds = SqlHelper.ExecuteDataset(str_select);
            dgvItems.DataSource=ds.Tables[0];
        }
    }
}
