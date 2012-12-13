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
    public partial class frmEmployeeNew : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmEmployeeNew()
        {
            InitializeComponent();
        }
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=Patrol;User ID=sa;Password=sa123";      
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {    
       
            if (this.txtName.Text == "")
            {
                MessageBox.Show("人员名称不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtName.Focus();
            }
            else if (txtAlias.Text == "")
            {
                MessageBox.Show("人员别名不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtAlias.Focus();
            }
            else if (this.cboCard.SelectedValue.ToString() == "")
            {
                MessageBox.Show("所属卡片不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.cboCard.Focus();
            }
            else if (this.cboPost.SelectedValue.ToString() == "")
            {
                MessageBox.Show("所属岗位不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.cboPost.Focus();
            }
           
                else
                {
                    string insertEmpoyee = "insert into Employee(Name,Alias,Rfid_ID) values(@name,@alias,@rfid_id);select  @@identity";
                    string insertEmpoyeePost = "insert into Post_Employee(Employee_ID,ID) values(@em_id,@id)";
                    SqlParameter[] par = new SqlParameter[]{ new SqlParameter("@name",SqlDbType.NVarChar),
                                                     new SqlParameter("@alias",SqlDbType.NVarChar),
                                                     new SqlParameter("@rfid_id",SqlDbType.Int) };
                    par[0].Value = this.txtName.Text;
                    par[1].Value = this.txtAlias.Text;
                    par[2].Value = this.cboCard.SelectedValue.ToString();
                    string id = SqlHelper.ExecuteScalar(sqlConnectionStr, CommandType.Text, insertEmpoyee, par).ToString();
                    if (id != null)
                    {
                        MessageBox.Show("保存成功！");
                    }
                    else
                    {
                        MessageBox.Show("保存失败！");
                    }
                    SqlParameter[] par1 = new SqlParameter[]{ new SqlParameter("@em_id",SqlDbType.Int),             
                                                      new SqlParameter("@id",SqlDbType.Int) };

                    par1[0].Value = id;
                    par1[1].Value = this.cboPost.SelectedValue.ToString();
                    int i = SqlHelper.ExecuteNonQuery(sqlConnectionStr, CommandType.Text, insertEmpoyeePost, par1);
                }
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
        private void frmAddEmployee_Load(object sender, EventArgs e)
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

        private void txtAlias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
