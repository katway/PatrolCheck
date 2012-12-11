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
    public partial class frmPoint : Form
    {
        public frmPoint()
        {
            InitializeComponent();
        }

        private void frmAddPoint_Load(object sender, EventArgs e)
        {
            this.labID.Text = "";
            this.btnSave.Enabled = false;
            getDgvPoint();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SqlHelper.ExecuteNonQuery("Select Count(1) From PhysicalCheckPoint Where [Name]='" + this.txtName.Text.Trim() + "'") > 0)
            {
                MessageBox.Show("已存在巡检点名称，");
                this.txtName.Focus();
                return;
            }
            SqlParameter[] pars = new SqlParameter[] { 
                    new SqlParameter("@name",SqlDbType.NVarChar),
                    new SqlParameter("@alias",SqlDbType.NVarChar),
                    new SqlParameter("@rfid",SqlDbType.BigInt)
            };
            pars[0].Value = this.txtName.Text.Trim();
            pars[1].Value = this.txtAlias.Text.Trim();
            string str_select = "Select ID From Rfid Where Name='"+this.txtRelation.Text.Trim()+"'";
            string str_rfid = (SqlHelper.ExecuteScalar("connectionstring",CommandType.Text,str_select)).ToString();
            pars[2].Value = str_rfid;
            string str_insert = "Insert Into PhysicalCheckPoint([Name],Alias,Rfid_Id) values(@name,@alias,@rfid)";
            Object obj_ret = SqlHelper.ExecuteNonQuery(str_insert,pars);
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
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 0)
            {
                if ((bool)dgvPoint.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
                {
                    dgvPoint.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgvPoint.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
            else
            {
                labID.Text = dgvPoint.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dgvPoint.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAlias.Text = dgvPoint.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRelation.Text = dgvPoint.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (labID.Text == "")
                return;
            SqlParameter[] pars = new SqlParameter[] { 
                    new SqlParameter("@name",SqlDbType.NVarChar),
                    new SqlParameter("@alias",SqlDbType.NVarChar),
                    new SqlParameter("@rfid",SqlDbType.BigInt)
            };
            pars[0].Value = this.txtName.Text.Trim();
            pars[1].Value = this.txtAlias.Text.Trim();
            string str_select = "Select ID From Rfid Where Name='" + this.txtRelation.Text.Trim() + "'";
            string str_rfid = (SqlHelper.ExecuteScalar("connectionstring", CommandType.Text, str_select)).ToString();
            pars[2].Value = str_rfid;
            string str_insert = "Update PhysicalCheckPoint set [Name]=@name,Alias=@alias,Rfid_Id=@rfid where ID="+labID.Text.Trim();
            Object obj_ret = SqlHelper.ExecuteNonQuery(str_insert,pars);
            if (obj_ret.ToString() == "1")
            {
                MessageBox.Show("修改成功");
            }
            getDgvPoint();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string Del = "";
            string strsql = "Delete From PhysicalCheckPoint Where ID in(";
            for (int i = 0; i < dgvPoint.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvPoint.Rows[i].Cells[0].Value == true)
                    {
                        Del += dgvPoint.Rows[i].Cells[1].Value.ToString() + ",";
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
                getDgvPoint();
            }
            else
            {
                MessageBox.Show("请选择要删除的项。");
            }            
        }
       
    }
}
