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
    public partial class frmCardEditDelete : Form
    {
        public frmCardEditDelete()
        {
            InitializeComponent();
        }
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=PatrolCheck;User ID=sa;Password=sa123";  
        private void button1_Click(object sender, EventArgs e)
        {
            string sql4 = "select Name,Alias,RFID,Meaning,(select meaning from codes where code=validstate and purpose='validstate') as ValidState from Rfid left join RfidPurpose on Rfid.Purpose = RfidPurpose.Code where ID=@id";
            SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", this.dgvCardDelete.GetRowCellValue(dgvCardDelete.FocusedRowHandle, "ID")) };
            SqlDataReader dr = SqlHelper.ExecuteReader(sqlConnectionStr, CommandType.Text, sql4, par);
            while (dr.Read())
            {
                this.txtName.Text = dr[0].ToString();
                this.txtAlias.Text = dr[1].ToString();
                this.txtCard.Text = dr[2].ToString();
                this.comboBox1.Text = dr[3].ToString();
                this.cboState.Text = dr[4].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string del = "";
            string delCard = "delete from  Rfid  where  ID in (";            
            for (int i = 0; i < dgvCardDelete.DataRowCount; i++)
            {
                object idCheck = dgvCardDelete.GetRowCellValue(i, gridColumn_Check);
                if (idCheck != null && (bool)idCheck == true)
                {
                    del += dgvCardDelete.GetRowCellValue(i,"ID").ToString() + ",";
                }                
            }
            if (del != "")
            {
                del = del.Substring(0, del.Length - 1);
                delCard += del+")";
                int i = SqlHelper.ExecuteNonQuery(delCard);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }             
            }
            else
            {
                MessageBox.Show("请选择要删除的项");
            }
            Bind();       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("卡片名称不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtName.Focus();
            }
            else if (txtAlias.Text == "")
            {
                MessageBox.Show("卡片别名不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtAlias.Focus();
            }
            else if (txtCard.Text == "")
            {
                MessageBox.Show("标签卡唯一码不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtCard.Focus();
            }
            else if (this.comboBox1.SelectedValue ==null)
            {
                MessageBox.Show("用途不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.comboBox1.Focus();
            }
            else
            {
                string sql5 = "update Rfid set Name=@name,Alias=@alias,RFID=@rfid,Purpose=@purpose,ValidState=@ValidState where ID=@id";
                SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", this.dgvCardDelete.GetRowCellValue(dgvCardDelete.FocusedRowHandle, "ID")),
                                                          new SqlParameter("@name", SqlDbType.NVarChar),
                                                          new SqlParameter("@alias", SqlDbType.NVarChar),
                                                          new SqlParameter("@rfid", SqlDbType.NVarChar),
                                                          new SqlParameter("@purpose", SqlDbType.Int),
                                                          new SqlParameter("@ValidState",SqlDbType.Int)};
                par[1].Value = this.txtName.Text.Trim();
                par[2].Value = this.txtAlias.Text.Trim();
                par[3].Value = this.txtCard.Text.Trim();
                par[4].Value = this.comboBox1.SelectedValue;
                par[5].Value = this.cboState.SelectedValue;
                int n = SqlHelper.ExecuteNonQuery(sql5, par);
                if (n > 0)
                {
                    MessageBox.Show("更新成功！");
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            Bind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Bind()
        {
            string sql2 = "select ID,Name,Alias,RFID,Meaning,(select meaning from codes where code=validstate and purpose='validstate') as ValidState from Rfid left join RfidPurpose on Rfid.Purpose = RfidPurpose.Code";
            DataSet ds = SqlHelper.ExecuteDataset(sql2);
            ds.Tables[0].Columns.Add(new DataColumn("Check",typeof(System.Boolean)));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["Check"] = false;
            }
            this.gridControl1.DataSource = ds.Tables[0];
        }
        private void frmCardEditDelete2_Load(object sender, EventArgs e)
        {
            string sql2 = "select * from RfidPurpose ";
            DataSet ds = SqlHelper.ExecuteDataset(sql2);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Meaning";
            comboBox1.ValueMember = "Code";

            string sql3 = "select Code,Meaning from Codes where Purpose='ValidState'";
            DataSet ds2 = SqlHelper.ExecuteDataset(sql3);
            cboState.DataSource = ds2.Tables[0];
            cboState.DisplayMember = "Meaning";
            cboState.ValueMember = "Code";    
            Bind();
        }
    }
}
