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
    public partial class frmCompany : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmCompany()
        {
            InitializeComponent();
        }      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("公司名称不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtName.Focus();
            }
            else if (txtAlias.Text == "")
            {
                MessageBox.Show("公司别名不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtAlias.Focus();
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("联系方式不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtContact.Focus();
            }
            else if (this.txtAddress.Text == "")
            {
                MessageBox.Show("地址不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtAddress.Focus();
            }
            else
            {
                string insertCompany = "insert into Company(Name,Alias,Contact,Address)values(@name,@alias,@contact,@address)";
                SqlParameter[] par = new SqlParameter[]{ new SqlParameter("@name",SqlDbType.NVarChar),
                                                         new SqlParameter("@alias",SqlDbType.NVarChar),
                                                         new SqlParameter("@contact",SqlDbType.NVarChar),
                                                         new SqlParameter("@address",SqlDbType.NVarChar)};
                par[0].Value = this.txtName.Text.Trim();
                par[1].Value = this.txtAlias.Text.Trim();
                par[2].Value = this.txtContact.Text.Trim();
                par[3].Value = this.txtAddress.Text.Trim();
                int i = SqlHelper.ExecuteNonQuery(insertCompany, par);
                if (i > 0)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }         
               
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
        private void frmAddCompany_Load(object sender, EventArgs e)
        {
           
        }       
       
    }
}
