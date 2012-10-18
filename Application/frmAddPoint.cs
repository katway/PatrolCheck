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
    public partial class frmAddPoint : Form
    {
        public frmAddPoint()
        {
            InitializeComponent();
        }

        private void frmAddPoint_Load(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
            getDgvPoint();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlParameter[] pars = new SqlParameter[] { 
                    new SqlParameter("@name",SqlDbType.NVarChar),
                    new SqlParameter("@alias",SqlDbType.NVarChar),
                    new SqlParameter("@rfid",SqlDbType.Int)
            };
            pars[0].Value = this.txtName.Text.Trim();
            pars[1].Value = this.txtAlias.Text.Trim();

            string str_select = "Select ID From Rrid Where Name='"+this.txtRelation.Text.Trim()+"'";
            string str_rfid = (SqlHelper.ExecuteScalar("connectionstring",CommandType.Text,str_select)).ToString();
            pars[2].Value = str_rfid;

            string str_insert = "Insert Into PhysicalCheckPoint([Name],Alias,Rfid_Id) values(@name,@alias,@rfid)";

            Object obj_ret = SqlHelper.ExecuteNonQuery(str_insert);
            if (obj_ret.ToString() == "1")
            {
                MessageBox.Show("保存成功");
            }
            getDgvPoint();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

        private void getDgvPoint()
        {
            DataSet ds = SqlHelper.ExecuteDataset("Select P.ID as 编号,P.Name as 巡检名称,P.Alias as 别名,R.RFID as 关联标签卡 from PhysicalCheckPoint as P left  join  Rfid as R on P.Rfid_ID=R.ID");
            dgvPoint.DataSource=ds.Tables[0];
        }

        private void dgvPoint_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}
