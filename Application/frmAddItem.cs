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
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboMachine.SelectedValue == "")
            {
                MessageBox.Show("请选择所属机器");
                return;
            }
            if (cboPoint.SelectedValue == "")
            {
                MessageBox.Show("请选择所属地点");
                return;
            }

            string str_insert = "Insert into CheckItem([Name],Alias,Mac_id,ValueType,Che_ID,Comment) Values(@name,@alias,@machineid,@valuetype,@pointid,@comment)";
            SqlParameter[] pars = new SqlParameter[]{
                new SqlParameter("@name",SqlDbType.NVarChar),
                new SqlParameter("@alias",SqlDbType.NVarChar),
                new SqlParameter("@machineid",SqlDbType.Int),
                new SqlParameter("@valuetype",SqlDbType.Int),
                new SqlParameter("@pointid",SqlDbType.Int),
                new SqlParameter("@comment",SqlDbType.NText)
            };
            pars[0].Value = this.txtName.ToString().Trim();
            pars[1].Value = this.txtAlias.ToString().Trim();
            pars[2].Value = this.cboMachine.SelectedValue;
            pars[3].Value = this.cboValue.SelectedValue;
            pars[4].Value = this.cboPoint.SelectedValue;
            pars[5].Value = this.txtRemarks.Text;

            int _ret = SqlHelper.ExecuteNonQuery(str_insert);
            if (_ret == 1)
            {
                MessageBox.Show("保存成功");
            }
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
            //ComboBoxItem item = new ComboBoxItem();
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
    }
}
