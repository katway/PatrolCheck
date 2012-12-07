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
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=PatrolCheck;User ID=sa;Password=sa123";      
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
            else
            {
                string sql = "Update Post set Name=@name,Alias=@alias,Site_ID=@siteid,ValidState=@ValidState where ID=@id";
                SqlParameter[] par = new SqlParameter[]{
                             new SqlParameter("@id",dgvPostDel.GetRowCellValue(dgvPostDel.FocusedRowHandle,"ID")),
                             new SqlParameter("@name",SqlDbType.NVarChar),
                             new SqlParameter("@alias",SqlDbType.NVarChar),
                             new SqlParameter("@siteid",SqlDbType.Int),
                             new SqlParameter("@ValidState",SqlDbType.Int) };         
                par[1].Value = this.txtName.Text;
                par[2].Value = this.txtalias.Text;
                par[3].Value = this.cboSite.SelectedValue;
                par[4].Value = this.cboState.SelectedValue;
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
            string sql = "select Post.Name,Post.Alias,Site.Name,(select meaning from codes where code=Post.validstate and purpose='validstate') as ValidState from Post,Site where Post.Site_ID=Site.ID and Post.ID=@id";
            SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", dgvPostDel.GetRowCellValue(dgvPostDel.FocusedRowHandle, "ID")) }; 
            SqlDataReader dr = SqlHelper.ExecuteReader(sqlConnectionStr, CommandType.Text,sql,par);
            while(dr.Read())
            {
                this.txtName.Text = dr[0].ToString();
                this.txtalias.Text = dr[1].ToString();
                this.cboSite.Text = dr[2].ToString();
                this.cboState.Text = dr[3].ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string del = "";
            string delCard = "delete from  Post  where  ID in (";
            for (int i = 0; i < dgvPostDel.DataRowCount; i++)
            {
                object idCheck = dgvPostDel.GetRowCellValue(i, gridColumn_check);
                if (idCheck != null && (bool)idCheck == true)
                {
                    del += dgvPostDel.GetRowCellValue(i, "ID").ToString() + ",";
                }
            }
            if (del != "")
            {
                del = del.Substring(0, del.Length - 1);
                delCard += del + ")";
                int i = SqlHelper.ExecuteNonQuery(delCard);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的项");
            }           
            BindPost();
        }

        private void frmEditOrDeletePost_Load(object sender, EventArgs e)
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
            string sql = "select Post.ID, Post.Name,Post.Alias,Site.Name Name1,(select meaning from codes where code=Post.validstate and purpose='validstate') as ValidState from Post,Site where Post.Site_ID=Site.ID";
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            ds.Tables[0].Columns.Add(new DataColumn("check", typeof(System.Boolean)));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["check"] = false;
            }
            this.gridControl1.DataSource = ds.Tables[0];
        }
    }
}
