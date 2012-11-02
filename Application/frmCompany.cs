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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=Patrol;User ID=sa;Password=sa123";         
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string insertCompany = "insert into Company(Name,Alias,Contact,Address)values(@name,@alias,@contact,@address)";
            SqlParameter[] par = new SqlParameter[]{ new SqlParameter("@name",SqlDbType.NVarChar),
                                                     new SqlParameter("@alias",SqlDbType.NVarChar),
                                                     new SqlParameter("@contact",SqlDbType.NVarChar),
                                                     new SqlParameter("@address",SqlDbType.NVarChar)  };
            par[0].Value = this.txtName.Text.Trim();
            par[1].Value = this.txtAlias.Text.Trim();
            par[2].Value = this.txtContact.Text.Trim();
            par[3].Value = this.txtAddress.Text.Trim();
            int i = SqlHelper.ExecuteNonQuery(insertCompany, par);
            if(i>0)
            {
                MessageBox.Show("保存成功！");
            }
            else 
            {
                MessageBox.Show("保存失败！");
            }
            BindCompany();
               
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void BindCompany()
        {
            string SelectCompany = "select * from Company";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, SelectCompany);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void frmAddCompany_Load(object sender, EventArgs e)
        {
            BindCompany();
        }
    }
}
