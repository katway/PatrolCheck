using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WorkStation;
using System.Configuration;
namespace WorkStation
{
    public partial class frmCardNew : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmCardNew()
        {
            InitializeComponent();
        }
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=Patrol;User ID=sa;Password=sa123";         
        /// <summary>
        /// datagridview的显示
        /// </summary>
        public void Bind()
        {
            string sql2 = "select ID,Name,Alias,RFID,Meaning from Rfid,RfidPurpose where Rfid.Purpose = RfidPurpose.Code";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, sql2);
            dataGridView1.DataSource = ds.Tables[0];
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
            else if (this.comboBox1.SelectedValue.ToString()=="")
            {
                MessageBox.Show("用途不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.comboBox1.Focus();
            }
            else
            {
                string sql = "insert into Rfid([Name],Alias,RFID,Purpose) values(@name,@alias,@rFID,@RfidPurpose)";
                SqlParameter[] pars = new SqlParameter[] { 
                new SqlParameter("@name", SqlDbType.NVarChar),
                new SqlParameter("@alias", SqlDbType.NVarChar),
                new SqlParameter("@rFID", SqlDbType.NVarChar),  
                new SqlParameter("@RfidPurpose", SqlDbType.Int) };
                pars[0].Value = this.txtName.Text.Trim();
                pars[1].Value = this.txtAlias.Text.Trim();
                pars[2].Value = this.txtCard.Text.Trim();
                pars[3].Value = this.comboBox1.SelectedValue;
                int n = SqlHelper.ExecuteNonQuery(sql, pars);
                if (n > 0)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }          
            Bind();
        }

       
        private void frmAddCard_Load(object sender, EventArgs e)
        {         
           bwkLoadData.RunWorkerAsync();
        }       
        DataSet dsRfidPurpose = null;
        DataSet dsRfid = null;
        private void bwkLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            string sql2 = "select * from RfidPurpose ";
            dsRfidPurpose = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, sql2);
            sql2 = "select ID,Name,Alias,RFID,Meaning from Rfid,RfidPurpose where Rfid.Purpose = RfidPurpose.Code";
            dsRfid = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, sql2);
        }

        private void bwkLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            comboBox1.DataSource = dsRfidPurpose.Tables[0];
            comboBox1.DisplayMember ="Meaning";
            comboBox1.ValueMember = "Code";
            dataGridView1.DataSource = dsRfid.Tables[0]; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
