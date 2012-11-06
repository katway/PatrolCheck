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
    public partial class frmSiteEditDelete : Form
    {
        private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=Patrol;User ID=sa;Password=sa123";         
        public frmSiteEditDelete()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 更新`
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string b = "update Site set Site.Name=@name,Site.Alias=@alias,Site.Company_ID=@comid where Site.ID=@id";
            SqlParameter[] par = new SqlParameter[] { new  SqlParameter("@id",dgvSite.SelectedCells[0].Value),
                                                      new  SqlParameter("@name",SqlDbType.NVarChar),
                                                      new  SqlParameter("@alias",SqlDbType.NVarChar),
                                                      new  SqlParameter("@comid",SqlDbType.Int) };
            par[1].Value = this.txtName.Text.Trim();
            par[2].Value = this.txtAlias.Text.Trim();
            par[3].Value = this.cboCompany.SelectedValue;
            int i = SqlHelper.ExecuteNonQuery(sqlConnectionStr,CommandType.Text,b,par);
            if(i>0)
            {
                MessageBox.Show("更新成功！");
            }
            else 
            {
                MessageBox.Show("更新失败！");
            }
            SelectSiteBind();

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
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string a = "select Site.Name,Site.Alias,Company.Name from Site,Company where Site.Company_ID=Company.ID and  Site.ID=@id";
            SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", dgvSite.SelectedCells[0].Value) };
            SqlDataReader dr = SqlHelper.ExecuteReader(sqlConnectionStr,CommandType.Text,a,par);
            while (dr.Read())
            {
                this.txtName.Text = dr[0].ToString();
                this.txtAlias.Text = dr[1].ToString();
                this.cboCompany.Text= dr[2].ToString();
            }
            
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delSite = "delete  from Site where ID=@id";
            SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", dgvSite.SelectedCells[0].Value) };
            int i = SqlHelper.ExecuteNonQuery(sqlConnectionStr, CommandType.Text, delSite,par);
            if (i > 0)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");

            }
            SelectSiteBind();

        }
        /// <summary>
        /// 加载时数据绑定
        /// </summary>
        public void SelectSiteBind()
        {
            string SelectSite = "select Site.ID, Site.Name,Site.Alias,Company.Name from Site,Company where Site.Company_ID=Company.ID";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, SelectSite);
            this.dgvSite.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SiteEditDelete_Load(object sender, EventArgs e)
        {
            string SelectCompanyName = "select * from  Company";
            DataSet ds = SqlHelper.ExecuteDataset(sqlConnectionStr, CommandType.Text, SelectCompanyName);
            cboCompany.DataSource = ds.Tables[0];
            cboCompany.DisplayMember = "Name";
            cboCompany.ValueMember = "ID";
            SelectSiteBind();
        }
    }
}
