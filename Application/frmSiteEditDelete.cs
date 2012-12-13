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
    public partial class frmSiteEditDelete : WeifenLuo.WinFormsUI.Docking.DockContent
    {
       // private static string sqlConnectionStr = "Data Source=192.168.1.221;Initial Catalog=PatrolCheck;User ID=sa;Password=sa123";         
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
             if (this.txtName.Text == "")
             {
                 MessageBox.Show("厂区名称不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 this.txtName.Focus();
             }
             else if (txtAlias.Text == "")
             {
                MessageBox.Show("厂区别名不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtAlias.Focus();
             }
              else if (this.cboCompany.SelectedValue == null)
              {
                  MessageBox.Show("所属公司不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                  this.cboCompany.Focus();
              }
              else
              {
                  string b = "update Site set Site.Name=@name,Site.Alias=@alias,Site.Company_ID=@comid,ValidState=@ValidState where Site.ID=@id";
                  SqlParameter[] par = new SqlParameter[] { new  SqlParameter("@id",this.dgvSiteDel.GetRowCellValue(this.dgvSiteDel.FocusedRowHandle,"ID")),
                                                            new  SqlParameter("@name",SqlDbType.NVarChar),
                                                            new  SqlParameter("@alias",SqlDbType.NVarChar),
                                                            new  SqlParameter("@comid",SqlDbType.Int),
                                                            new  SqlParameter("@ValidState",SqlDbType.Int) };                                                   
                  par[1].Value = this.txtName.Text.Trim();
                  par[2].Value = this.txtAlias.Text.Trim();
                  par[3].Value = this.cboCompany.SelectedValue;
                  par[4].Value = this.cboState.SelectedValue;
                  int i = SqlHelper.ExecuteNonQuery(b, par);
                  if (i > 0)
                  {
                      MessageBox.Show("更新成功！");
                  }
                  else
                  {
                      MessageBox.Show("更新失败！");
                  }
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
            string a = "select Site.Name,Site.Alias,Company.Name,(select meaning from codes where code=Site.validstate and purpose='validstate') as ValidState from Site left join Company on  Site.Company_ID=Company.ID where  Site.ID=@id";
            SqlParameter[] par = new SqlParameter[] { new SqlParameter("@id", this.dgvSiteDel.GetRowCellValue(this.dgvSiteDel.FocusedRowHandle, "ID")) };
            //SqlDataReader dr = SqlHelper.ExecuteReader(sqlConnectionStr,CommandType.Text,a,par);
            SqlDataReader dr = SqlHelper.ExecuteReader(a, par);
            while (dr.Read())
            {
                this.txtName.Text = dr[0].ToString();
                this.txtAlias.Text = dr[1].ToString();
                this.cboCompany.Text= dr[2].ToString();
                this.cboState.Text = dr[3].ToString();
            }
            
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string del = "";
            string delCard = "delete from  Site  where  ID in (";
            for (int i = 0; i < dgvSiteDel.DataRowCount; i++)
            {
                object idCheck = dgvSiteDel.GetRowCellValue(i, gridColumn_check);
                if (idCheck != null && (bool)idCheck == true)
                {
                    del += dgvSiteDel.GetRowCellValue(i, "ID").ToString() + ",";
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
            SelectSiteBind();           

        }
        /// <summary>
        /// 加载时数据绑定
        /// </summary>
        public void SelectSiteBind()
        {
            string SelectSite = "select Site.ID, Site.Name,Site.Alias,Company.Name Name1,(select meaning from codes where code=Site.validstate and purpose='validstate') as ValidState  from Site,Company where Site.Company_ID=Company.ID";
            DataSet ds = SqlHelper.ExecuteDataset(SelectSite);
            ds.Tables[0].Columns.Add(new DataColumn("check", typeof(System.Boolean)));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["check"] = false;
            }
            this.gridControl1.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SiteEditDelete_Load(object sender, EventArgs e)
        {
            string SelectCompanyName = "select * from  Company";
            DataSet ds = SqlHelper.ExecuteDataset(SelectCompanyName);
            cboCompany.DataSource = ds.Tables[0];
            cboCompany.DisplayMember = "Name";
            cboCompany.ValueMember = "ID";

            string selectState = "select Code,Meaning from Codes where Purpose='ValidState'";
            DataSet dse = SqlHelper.ExecuteDataset(selectState);
            cboState.DataSource = dse.Tables[0];
            cboState.DisplayMember = "Meaning";
            cboState.ValueMember = "Code";
            SelectSiteBind();
        }
    }
}
