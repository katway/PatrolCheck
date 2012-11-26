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
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=Patrol;User ID=sa;Password=sa123";  
        public frmCardEditDelete()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            else if (this.comboBox1.SelectedValue.ToString() == "")
            {
                MessageBox.Show("用途不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.comboBox1.Focus();
            }
            else
            {
                string sql5 = "update Rfid set Name=@name,Alias=@alias,RFID=@rfid,Purpose=@purpose where ID=@id";
                SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", dataGridView1.SelectedCells[0].Value),
                                                          new SqlParameter("@name", SqlDbType.NVarChar),
                                                          new SqlParameter("@alias", SqlDbType.NVarChar),
                                                          new SqlParameter("@rfid", SqlDbType.NVarChar),
                                                          new SqlParameter("@purpose", SqlDbType.Int) };
                par[1].Value = this.txtName.Text.Trim();
                par[2].Value = this.txtAlias.Text.Trim();
                par[3].Value = this.txtCard.Text.Trim();
                par[4].Value = this.comboBox1.SelectedValue;
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
        /// <summary>
        /// 编辑操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string sql4 = "select Name,Alias,RFID,Meaning from Rfid,RfidPurpose where Rfid.Purpose = RfidPurpose.Code and ID=@id";
            SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", dataGridView1.SelectedCells[0].Value) };
            SqlDataReader dr = SqlHelper.ExecuteReader(sqlConnectionStr, CommandType.Text, sql4, par);
            while(dr.Read())
            {
                this.txtName.Text = dr[0].ToString();
                this.txtAlias.Text = dr[1].ToString();
                this.txtCard.Text = dr[2].ToString();
                this.comboBox1.Text = dr[3].ToString();
            }

        }    
        private void Bind()
        {
            string sql2 = "select ID,Name,Alias,RFID,Meaning from Rfid,RfidPurpose where Rfid.Purpose = RfidPurpose.Code";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, sql2);
            dataGridView1.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您真要删除所选记录吗?", "友情提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {              
                string delCard = "delete from  Rfid  where  ID=@id";
                SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", dataGridView1.SelectedCells[0].Value) };
                int i = SqlHelper.ExecuteNonQuery(sqlConnectionStr, CommandType.Text, delCard, par);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                Bind();
            }
        }       
        private void frmEditAndDeleteCard_Load(object sender, EventArgs e)
        {
            string sql2 = "select * from RfidPurpose ";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, sql2);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Meaning";
            comboBox1.ValueMember = "Code";   
            Bind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {

        }         
    }
}
