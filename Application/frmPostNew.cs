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
    public partial class frmPostNew : Form
    {
        public frmPostNew()
        {
            InitializeComponent();
        }      
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
            else if (this.cboSite.SelectedValue == null)
            {
                MessageBox.Show("所属厂区不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.cboSite.Focus();
            }
            else if(this.cboState.SelectedValue == null)
            {
                MessageBox.Show("有效状态不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.cboState.Focus();
            }
            else
            {
                string selectPost = "insert into Post(Name,Alias,Site_ID,ValidState) values(@name,@alias,@site_id,@ValidState)";
                SqlParameter[] par = new SqlParameter[]{  new SqlParameter("@name",SqlDbType.Text),
                                                          new SqlParameter("@alias",SqlDbType.Text),
                                                          new SqlParameter("@site_id",SqlDbType.Int),
                                                          new SqlParameter("@ValidState",SqlDbType.Int) };               
                par[0].Value = this.txtName.Text;
                par[1].Value = this.txtalias.Text;
                par[2].Value = this.cboSite.SelectedValue;
                par[3].Value = this.cboState.SelectedValue;
                int i = SqlHelper.ExecuteNonQuery(selectPost, par);
                if (i > 0)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
            BindPost();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddPost_Load(object sender, EventArgs e)
        {           
            string selectSite = "select * from Site";
            DataSet ds = SqlHelper.ExecuteDataset(selectSite);
            cboSite.DataSource = ds.Tables[0];
            cboSite.DisplayMember = "Name";
            cboSite.ValueMember = "ID";

            string selectState = "select Code,Meaning from Codes where Purpose='ValidState'";
            DataSet dse = SqlHelper.ExecuteDataset(selectState);
            cboState.DataSource = dse.Tables[0];
            cboState.DisplayMember = "Meaning";
            cboState.ValueMember = "Code";
            BindPost();
        }
        public void BindPost()
        {
            string sql = "select Post.ID, Post.Name,Post.Alias,Site.Name Name1,(select meaning from codes where code=Post.validstate and purpose='validstate') as ValidState from Post left join Site on Post.Site_ID=Site.ID";
            DataSet ds = SqlHelper.ExecuteDataset(sql);           
            this.gridControl1.DataSource = ds.Tables[0];
        }
    }
}
