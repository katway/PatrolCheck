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
            else if (this.cboCard.SelectedValue == null)
            {
                MessageBox.Show("所属卡片不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.cboCard.Focus();
            }
            else if (this.cboPost.SelectedValue == null )
            {
                MessageBox.Show("所属岗位不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.cboPost.Focus();
            }
            else if(this.cboState.SelectedValue == null)
            {
                MessageBox.Show("有效状态不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

                else
                {
                    string insertEmpoyee = "insert into Employee(Name,Alias,Rfid_ID,ValidState) values(@name,@alias,@rfid_id,@ValidState);select  @@identity";
                    string insertEmpoyeePost = "insert into Post_Employee(Employee_ID,ID) values(@em_id,@id)";
                    SqlParameter[] par = new SqlParameter[]{ new SqlParameter("@name",SqlDbType.NVarChar),
                                                             new SqlParameter("@alias",SqlDbType.NVarChar),
                                                             new SqlParameter("@rfid_id",SqlDbType.Int), 
                                                             new  SqlParameter("@ValidState",SqlDbType.Int)};
                    par[0].Value = this.txtName.Text;
                    par[1].Value = this.txtAlias.Text;
                    par[2].Value = this.cboCard.SelectedValue.ToString();
                    par[3].Value = this.cboState.SelectedValue.ToString();
                  //  string id = SqlHelper.ExecuteScalar( CommandType.Text, insertEmpoyee, par).ToString();
                    int id = SqlHelper.ExecuteNonQuery(insertEmpoyee,par);
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
                    int i = SqlHelper.ExecuteNonQuery( insertEmpoyeePost, par1);
                }
            BindEmployee(); 
           
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void BindEmployee()
        {
            string selectEmployee = @"select 
 ID,Name as emName,Alias,
 (select name from rfid where id=Rfid_ID) as Name,
 (select name from post where id=(SELECT post_id from Post_Employee where Employee_ID=ID)) as postname,
 (select meaning from codes where code=Employee.validstate and purpose='validstate') as ValidState
from Employee";
            DataSet ds = SqlHelper.ExecuteDataset(selectEmployee);
            this.gridControl1.DataSource = ds.Tables[0];
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
            DataSet ds = SqlHelper.ExecuteDataset(selectPost);
            cboPost.DataSource = ds.Tables[0];
            cboPost.DisplayMember = "Name";
            cboPost.ValueMember = "ID";

            string selectCard = "select * from Rfid";
            DataSet dsd = SqlHelper.ExecuteDataset(selectCard);
            cboCard.DataSource = dsd.Tables[0];
            cboCard.DisplayMember = "Name";
            cboCard.ValueMember = "ID";

            string selectState = "select Code,Meaning from Codes where Purpose='ValidState' ";
            DataSet dse = SqlHelper.ExecuteDataset(selectState);
            cboState.DataSource = dse.Tables[0];
            cboState.DisplayMember = "Meaning";
            cboState.ValueMember = "Code";
            BindEmployee();
        }

        private void txtAlias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
