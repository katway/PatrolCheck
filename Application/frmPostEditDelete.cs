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
    public partial class frmPostEditDelete : Form
    {
        public frmPostEditDelete()
        {
            InitializeComponent();
        }
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=Patrol;User ID=sa;Password=sa123";      
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("岗位名称不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtName.Focus();                
            }
            else if (txtalias.Text == "")
            {
                MessageBox.Show("岗位别名不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtalias.Focus();
            }
            else if (this.cboSite.SelectedValue.ToString() == "")
            {
                MessageBox.Show("所属厂区不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.cboSite.Focus();
            }
            else
            {
                string sql = "Update Post set Name=@name,Alias=@alias,Site_ID=@siteid where ID=@id";
                SqlParameter[] par = new SqlParameter[]{
                             new SqlParameter("@id",dataGridView1.SelectedCells[0].Value),
                             new SqlParameter("@name",SqlDbType.NVarChar),
                             new SqlParameter("@alias",SqlDbType.NVarChar),
                             new SqlParameter("@siteid",SqlDbType.Int)};          
                par[1].Value = this.txtName.Text;
                par[2].Value = this.txtalias.Text;
                par[3].Value = this.cboSite.SelectedValue;
                int i = SqlHelper.ExecuteNonQuery(sql, par);
                if (i > 0)
                {
                    MessageBox.Show("更新成功！");
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            BindPost();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "select Post.Name,Post.Alias,Site.Name from Post,Site where Post.Site_ID=Site.ID and Post.ID=@id";
            SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", dataGridView1.SelectedCells[0].Value) }; 
            SqlDataReader dr = SqlHelper.ExecuteReader(sqlConnectionStr, CommandType.Text,sql,par);
            while(dr.Read())
            {
                this.txtName.Text = dr[0].ToString();
                this.txtalias.Text = dr[1].ToString();
                this.cboSite.Text = dr[2].ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deletePost = "delete from Post where ID=@id";
            SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id",dataGridView1.SelectedCells[0].Value) };
            int i = SqlHelper.ExecuteNonQuery(deletePost,par);
            if(i>0)
            {
                MessageBox.Show("删除成功！");
            }
            else 
            {
                MessageBox.Show("删除失败！");
            }
            BindPost();
        }

        private void frmEditOrDeletePost_Load(object sender, EventArgs e)
        {
            string selectSite = "select * from Site";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, selectSite);
            cboSite.DataSource = ds.Tables[0];
            cboSite.DisplayMember = "Name";
            cboSite.ValueMember = "ID";
            BindPost();
        }
        public void BindPost()
        {
            string sql = "select Post.ID, Post.Name,Post.Alias,Site.Name from Post,Site where Post.Site_ID=Site.ID";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, sql);
            this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
