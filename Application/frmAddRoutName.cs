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
        public Boolean isEdit=false;
        public object routeID;
        public string routeName, routeAlias, routeArea;
        public TreeView tView;
        public frmAddRoutName()
        {
            InitializeComponent();
        }

        private void frmAddRoutName_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.btnTrue.Text = "修改";
                this.Text = "修改巡检路线";
                SqlDataReader dr = SqlHelper.ExecuteReader("Select Site_ID,Name,Alias From CheckRoute Where ID="+routeID.ToString());
                if (dr == null) return;
                while (dr.Read())
                {
                    this.cboSiteArea.SelectedValue = dr["Site_ID"];
                    this.tbRouteName.Text = dr["Name"].ToString();
                    this.tbRouteAlias.Text = dr["Alias"].ToString();
                }
                dr.Dispose();
            }
            DataSet ds = SqlHelper.ExecuteDataset("Select Id,Name From Site");
            cboSiteArea.DataSource=ds.Tables[0];
            cboSiteArea.DisplayMember = "Name";
            cboSiteArea.ValueMember = "ID";
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            string strsql = "";
            SqlParameter[] pars = new SqlParameter[] { 
               new SqlParameter("@id",SqlDbType.BigInt),
               new SqlParameter("@name",this.tbRouteName.Text.Trim().ToString()),
               new SqlParameter("@alias",this.tbRouteAlias.Text.Trim().ToString()),
               new SqlParameter("@routeid",SqlDbType.BigInt)
            };
            if (isEdit)
            {
                strsql = "Update CheckRoute Set Site_ID=@id,[Name]=@name,Alias=@alias Where ID=@routeid";                
            }
            else
            {
                strsql = "Insert Into CheckRoute(Site_ID,[Name],Alias) Values(@id,@name,@alias)";
                
            }           
            pars[0].Value = cboSiteArea.SelectedValue.ToString();
            pars[3].Value = routeID;
            SqlHelper.ExecuteNonQuery(strsql, pars);
            frmAddRoute.tvRouteInit(tView);
            tView.ExpandAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
