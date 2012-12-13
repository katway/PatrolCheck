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
    public partial class frmSiteNew : WeifenLuo.WinFormsUI.Docking.DockContent
    {        
        public frmSiteNew()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 数据保存
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
             else if (this.cboCompany.SelectedValue ==null )
             {
                 MessageBox.Show("所属公司不能为空", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 this.cboCompany.Focus();
             }
             else
             {
                 string insertSite = "insert into Site(Name,Alias,Company_ID,ValidState) values(@name,@alias,@com_id,@ValidState)";
                 SqlParameter[] par = new SqlParameter[] { new SqlParameter("@name",SqlDbType.NVarChar),
                                                           new SqlParameter("@alias",SqlDbType.NVarChar),
                                                           new SqlParameter("@com_id",SqlDbType.Int),
                                                           new SqlParameter("@ValidState",SqlDbType.Int)};             
                 par[0].Value = this.txtName.Text;
                 par[1].Value = this.txtAlias.Text;
                 par[2].Value = this.cboCompany.SelectedValue;
                 par[3].Value = this.cboState.SelectedValue;
                 int i = SqlHelper.ExecuteNonQuery(insertSite, par);
                 if (i > 0)
                 {
                     MessageBox.Show("保存成功！");
                 }
                 else
                 {
                     MessageBox.Show("保存失败!");
                 }
             }
            SelectSiteBind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SiteNew_Load(object sender, EventArgs e)
        {           
            backgroundWorker1.RunWorkerAsync();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void SelectSiteBind()
        {
            string SelectSite = "select Site.ID, Site.Name,Site.Alias,Company.Name,(select meaning from codes where code=Site.validstate and purpose='validstate') as ValidState  from Site left join Company on Site.Company_ID=Company.ID";
            DataSet ds = SqlHelper.ExecuteDataset(SelectSite);         
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
        /// 线程
        /// </summary>
        DataSet dsSite = null;
        DataSet dsCompany = null;
        DataSet dsState = null;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string SelectCompanyName = "select * from  Company";
            dsSite = SqlHelper.ExecuteDataset(SelectCompanyName);
            string SelectSite = "select Site.ID, Site.Name,Site.Alias,Company.Name,(select meaning from codes where code=Site.validstate and purpose='validstate') as ValidState  from Site left join Company on Site.Company_ID=Company.ID";
            dsCompany = SqlHelper.ExecuteDataset(SelectSite);
            string selectState = "select Code,Meaning from Codes where Purpose='ValidState'";
            dsState = SqlHelper.ExecuteDataset(selectState);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cboCompany.DataSource = dsSite.Tables[0];
            cboCompany.DisplayMember = "Name";
            cboCompany.ValueMember = "ID";

            cboState.DataSource = dsState.Tables[0];
            cboState.DisplayMember = "Meaning";
            cboState.ValueMember = "Code";
            this.gridControl1.DataSource = dsCompany.Tables[0];
        }



        
    }
}
