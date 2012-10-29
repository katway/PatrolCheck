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
    public partial class frmEditOrDeleteEmployee : Form
    {
        public frmEditOrDeleteEmployee()
        {
            InitializeComponent();
        }
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=Patrol;User ID=sa;Password=sa123";  
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string selectEmpoyee = "select Employee.Name emName,Employee.Alias,Rfid.Name,Post.Name  postName from Employee,Rfid,Post,Post_Employee where Employee.ID=Post_Employee.Employee_ID and Employee.Rfid_ID=Rfid.ID and Post_Employee.ID=Post.ID and Employee.ID=@id";
            SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", dataGridView1.SelectedCells[0].Value) };
            SqlDataReader dr = SqlHelper.ExecuteReader(sqlConnectionStr, CommandType.Text, selectEmpoyee,par);
            while(dr.Read())
            {
                this.txtName.Text = dr[0].ToString();
                this.txtAlias.Text = dr[1].ToString();
                this.cboPost.Text = dr[2].ToString();
                this.cboCard.Text = dr[3].ToString();
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string deleteEmployee = "delete from Employee where ID=@id";
            SqlParameter[] par = new SqlParameter[] {new SqlParameter("@id",dataGridView1.SelectedCells[0].Value) };
            int i = SqlHelper.ExecuteNonQuery(deleteEmployee,par);
            if (i > 0)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
            BindEmployee();
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string UpdateEmployee = "update Employee set Employee.Name=@name,Employee.Alias=@alias,Rfid_ID=@rfid_id where Employee.ID=@id;select  @@identity";
            SqlParameter[] par = new SqlParameter[]{ new SqlParameter("@id",dataGridView1.SelectedCells[0].Value),
                                                     new SqlParameter("@name",SqlDbType.NVarChar),
                                                     new SqlParameter("@alias",SqlDbType.NVarChar),
                                                     new SqlParameter("@rfid_id",SqlDbType.Int)


            };
            par[1].Value = this.txtName.Text;
            par[2].Value = this.txtAlias.Text;
            par[3].Value = this.cboCard.SelectedValue;
            string a = SqlHelper.ExecuteScalar(sqlConnectionStr,CommandType.Text, UpdateEmployee,par).ToString();
            if(a!=null)
            {
                MessageBox.Show("更新成功！");
            }
            else 
            {
                MessageBox.Show("更新失败！");
            }
            string UpdateEmPost = "update Post_Employee set ID=@id where Employee_ID=@emID";
            SqlParameter[] par2 = new SqlParameter[]
            {
                new SqlParameter("@emID",SqlDbType.Int),
                new SqlParameter("@id",SqlDbType.Int)
            };
            par2[0].Value = dataGridView1.SelectedCells[0].Value;
            par2[1].Value = cboPost.SelectedValue.ToString() ;
            int i = SqlHelper.ExecuteNonQuery(UpdateEmPost,par2);
            BindEmployee();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEditOrDeleteEmployee_Load(object sender, EventArgs e)
        {
            string selectPost = "select * from Post";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, selectPost);
            cboPost.DataSource = ds.Tables[0];
            cboPost.DisplayMember = "Name";
            cboPost.ValueMember = "ID";

            string selectCard = "select * from Rfid";
            DataSet dsd = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, selectCard);
            cboCard.DataSource = dsd.Tables[0];
            cboCard.DisplayMember = "Name";
            cboCard.ValueMember = "ID";
            BindEmployee();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void BindEmployee()
        {
            string selectEmployee = "select Employee.ID,Employee.Name emName,Employee.Alias,Rfid.Name,Post.Name  postName from Employee,Rfid,Post,Post_Employee where Employee.ID=Post_Employee.Employee_ID and Employee.Rfid_ID=Rfid.ID and Post_Employee.ID=Post.ID";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, selectEmployee);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
