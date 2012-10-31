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
    public partial class frmEditOrDeleteCompany : Form
    {
        public frmEditOrDeleteCompany()
        {
            InitializeComponent();
        }
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=Patrol;User ID=sa;Password=sa123";         
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string updateCom = "update Company set Name=@name,Alias=@alias,Contact=@contact,Address=@address where ID=@id";
            SqlParameter[] par = new SqlParameter[]{ new SqlParameter("@id",this.dataGridView1.SelectedCells[0].Value),
                                                     new SqlParameter("@name",SqlDbType.NVarChar),
                                                     new SqlParameter("@alias",SqlDbType.NVarChar),
                                                     new SqlParameter("@contact",SqlDbType.NVarChar),
                                                     new SqlParameter("@address",SqlDbType.NVarChar)};
            par[1].Value = this.txtName.Text;
            par[2].Value = this.txtAlias.Text;
            par[3].Value = this.txtContact.Text;
            par[4].Value = this.txtAddress.Text;            
            int i = SqlHelper.ExecuteNonQuery(updateCom, par);
            if(i>0)
            {
                MessageBox.Show("更新成功！");
            }
            else 
            {
                MessageBox.Show("更新失败！");
            }
            BindCompany();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string SelectCom = "select Name,Alias,Contact,Address  from Company where ID=@id";
            SqlParameter[] par = new SqlParameter[] {new SqlParameter("@id",this.dataGridView1.SelectedCells[0].Value) };
            SqlDataReader dr = SqlHelper.ExecuteReader(sqlConnectionStr, CommandType.Text, SelectCom,par);
            while(dr.Read())
            {
                this.txtName.Text = dr[0].ToString();
                this.txtAlias.Text = dr[1].ToString();
                this.txtContact.Text = dr[2].ToString();
                this.txtAddress.Text = dr[3].ToString();
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string deleteCompany = "delete from Company where ID=@id";
            SqlParameter[] par = new SqlParameter[] {new SqlParameter("@id",this.dataGridView1.SelectedCells[0].Value)};
            int i = SqlHelper.ExecuteNonQuery(deleteCompany,par);
            if(i>0)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
            BindCompany();
        }

        private void frmEditOrDeleteCompany_Load(object sender, EventArgs e)
        {
            BindCompany();

        }
        public void BindCompany()
        {   string SelectCompany = "select * from Company";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, SelectCompany);
            this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
