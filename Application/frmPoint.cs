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
            getDgvPoint();
            getCboSite();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtRelation.Text == string.Empty)
            {
                MessageBox.Show("请确保没有空值！");
                return;
            }
            if ((int)SqlHelper.ExecuteScalar("Select Count(1) From PhysicalCheckPoint Where [Name]='" + this.txtName.Text.Trim() + "'") > 0)
            {
                MessageBox.Show("已存在巡检点名称.");
                this.txtName.Focus();
                return;
            }
            SqlParameter[] pars = new SqlParameter[] { 
                    new SqlParameter("@name",SqlDbType.NVarChar),
                    new SqlParameter("@alias",SqlDbType.NVarChar),
                    new SqlParameter("@rfid",SqlDbType.BigInt),
                    new SqlParameter("@siteid",SqlDbType.BigInt)
            };
            pars[0].Value = this.txtName.Text.Trim();
            pars[1].Value = this.txtAlias.Text.Trim();
            pars[3].Value = this.cboSite.SelectedValue;

            if ((int)SqlHelper.ExecuteScalar("Select Count(1) From Rfid Where Purpose=2 and Name='" + this.txtRelation.Text.Trim() + "'") == 1)
            {
                string str_select = "Select ID From Rfid Where Name='" + this.txtRelation.Text.Trim() + "'";
                string str_rfid = SqlHelper.ExecuteScalar(str_select).ToString();
                pars[2].Value = str_rfid;
            }
            else
            {
                MessageBox.Show("请确保有此标签卡");
                return;
            }
            string str_insert = "Insert Into PhysicalCheckPoint([Name],Alias,Rfid_Id,Site_ID) values(@name,@alias,@rfid,@siteid)";

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
            this.txtRelation.ReadOnly = false;
        }

        private void getDgvPoint()
        {
            DataSet ds = SqlHelper.ExecuteDataset("Select P.ID as 编号,P.Name as 巡检名称,P.Alias as 别名,R.Name as 关联标签卡,S.Name from PhysicalCheckPoint as P left  join  Rfid as R on P.Rfid_ID=R.ID Left Join Site S on P.Site_ID=S.ID");
            dgvPoint.DataSource=ds.Tables[0];
        }

        private void dgvPoint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            labID.Text = dgvPoint.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvPoint.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAlias.Text = dgvPoint.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRelation.Text = dgvPoint.Rows[e.RowIndex].Cells[4].Value.ToString();
            cboSite.Text = dgvPoint.Rows[e.RowIndex].Cells[5].Value.ToString();
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (labID.Text == "")
                return;
            if (txtName.Text == string.Empty || txtRelation.Text == string.Empty)
            {
                MessageBox.Show("请确保没有空值！");
                return;
            }
            if ((int)SqlHelper.ExecuteScalar("Select Count(1) From PhysicalCheckPoint Where ID!="+labID.Text.Trim()+" and [Name]='" + this.txtName.Text.Trim() + "'") > 0)
            {
                MessageBox.Show("已存在巡检点名称.");
                this.txtName.Focus();
                return;
            }
            SqlParameter[] pars = new SqlParameter[] { 
                    new SqlParameter("@name",SqlDbType.NVarChar),
                    new SqlParameter("@alias",SqlDbType.NVarChar),
                    new SqlParameter("@rfid",SqlDbType.BigInt),
                    new SqlParameter("@siteid",SqlDbType.BigInt)
            };
            pars[0].Value = this.txtName.Text.Trim();
            pars[1].Value = this.txtAlias.Text.Trim();
            pars[3].Value = this.cboSite.SelectedValue;

            if ((int)SqlHelper.ExecuteScalar("Select Count(1) From Rfid Where Purpose=2 and Name='" + this.txtRelation.Text.Trim() + "'") == 1)
            {
                string str_select = "Select ID From Rfid Where Name='" + this.txtRelation.Text.Trim() + "'";
                string str_rfid = SqlHelper.ExecuteScalar(str_select).ToString();
                pars[2].Value = str_rfid;
            }
            else
            {
                MessageBox.Show("请确保有此标签卡");
                return;
            }

            string str_insert = "Update PhysicalCheckPoint set [Name]=@name,Alias=@alias,Rfid_Id=@rfid,Site_ID=@siteid where ID="+labID.Text.Trim();

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

        private void txtRelation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.txtRelation.ReadOnly = false;
        }

        private void getCboSite()
        {
            DataSet dsSite = SqlHelper.ExecuteDataset("select ID,Name From Site");
            cboSite.DataSource=dsSite.Tables[0];
            cboSite.DisplayMember = "Name";
            cboSite.ValueMember = "ID";
            this.cboSite.SelectedIndex = cboSite.Items.Count > 0 ? 0 : -1;
            dsSite.Dispose();
        }
     
       
    }
}
