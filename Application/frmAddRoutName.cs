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
    public partial class frmAddRoutName : Form
    {
        public TreeView tView;
        public frmAddRoutName(ref TreeView tr)
        {
            InitializeComponent();
            this.tView = tr;
        }

        private void frmAddRoutName_Load(object sender, EventArgs e)
        {
            DataSet ds = SqlHelper.ExecuteDataset("Select Id,Name From SiteArea");
            cboSiteArea.DataSource=ds.Tables[0];
            cboSiteArea.DisplayMember = "Name";
            cboSiteArea.ValueMember = "ID";
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            string str_insert = "Insert Into CheckRoute(Site_ID,[Name],Alias) Values(@id,@name,@alias)";
            SqlParameter[] pars = new SqlParameter[] { 
               new SqlParameter("@id",SqlDbType.BigInt),
               new SqlParameter("@name",this.tbRouteName.Text.Trim().ToString()),
               new SqlParameter("@alias",this.tbRouteAlias.Text.Trim().ToString())
            };
            pars[0].Value = cboSiteArea.SelectedValue.ToString();
            SqlHelper.ExecuteNonQuery(str_insert, pars);
            frmAddRoute.tvRouteInit(tView);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
