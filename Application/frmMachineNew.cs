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
    public delegate void ParameterizedThreadStart(Object obj);
    public partial class frmMachineNew : Form
    {
        public frmMachineNew()
        {
            InitializeComponent();
        }
        private void frmAddSiteArea_Load(object sender, EventArgs e)
        {
            getArea();
            bindDgvMachine();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlParameter[] pars = new SqlParameter[] { 
                       new SqlParameter("@name",this.tbName.Text.Trim().ToString()),
                       new SqlParameter("@alias",this.tbAlias.Text.Trim().ToString()),
                       new SqlParameter("@site_id",SqlDbType.BigInt)
            };
            pars[2].Value = cboArea.SelectedValue;

             string strSql = "insert into machine([Name],Alias,Site_ID) values(@name,@alias,@site_id)";

            if (SqlHelper.ExecuteNonQuery(strSql, pars) == 1)
            {
                MessageBox.Show("保存成功");
                bindDgvMachine();
            }

        }

        private void getArea()
        {
            DataSet ds = SqlHelper.ExecuteDataset("select ID,Name From Site");
            this.cboArea.DataSource = ds.Tables[0];
            this.cboArea.DisplayMember = "Name";
            this.cboArea.ValueMember = "ID";
            this.cboArea.SelectedIndex = cboArea.Items.Count > 0 ? 0 : -1;
        }

        private void bindDgvMachine()
        {
            string str_select = @"select 
                                  m.id as 编号,
                                  m.name as 设备名称,
                                  m.alias as 别名,
                                  s.name as 厂区
                                  from machine m,site s 
                                  where m.site_id=s.id";
            DataSet ds = SqlHelper.ExecuteDataset(str_select);
            this.dgvMachine.DataSource=ds.Tables[0];
        }

        private void dgvMachine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 0)
            {
                if ((bool)dgvMachine.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
                {
                    dgvMachine.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgvMachine.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
            else
            {
                labID.Text = dgvMachine.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbName.Text = dgvMachine.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbAlias.Text = dgvMachine.Rows[e.RowIndex].Cells[3].Value.ToString();
                cboArea.Text = dgvMachine.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string Del = "";
            string strsql = "Delete From Machine Where ID in(";
            for (int i = 0; i < dgvMachine.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvMachine.Rows[i].Cells[0].Value == true)
                    {
                        Del += dgvMachine.Rows[i].Cells[1].Value.ToString() + ",";
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
                bindDgvMachine();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlParameter[] pars = new SqlParameter[] { 
                       new SqlParameter("@name",this.tbName.Text.Trim().ToString()),
                       new SqlParameter("@alias",this.tbAlias.Text.Trim().ToString()),
                       new SqlParameter("@site_id",SqlDbType.BigInt)
            };
            pars[2].Value = cboArea.SelectedValue;
            string strSql = "Update machine set [Name]=@name,Alias=@alias,Site_ID=@site_id where id=" + labID.Text;
            if (SqlHelper.ExecuteNonQuery(strSql,pars) == 1)
            {
                MessageBox.Show("修改成功");
                bindDgvMachine();
            }
        }


    }
}
