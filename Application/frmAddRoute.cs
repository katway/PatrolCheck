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
    public partial class frmAddRoute : Form
    {
        public frmAddRoute()
        {
            InitializeComponent();
            lstPointInit();
        }

        private void frmAddRoute_Load(object sender, EventArgs e)
        {
            tvRouteInit();
        }

        private void tvRouteInit()
        {
            SqlDataReader dr= SqlHelper.ExecuteReader("Select ID,Name From Company");
            if(dr==null)
            {
                return;
            }
            while (dr.Read())
            {
                TreeNode tnode = new TreeNode();
                tnode.Text = dr["Name"].ToString();
                tnode.Tag = dr["ID"].ToString();
                tnode= tvNodeAdd(tnode, "select ID,Name from site where com_id='" + dr["ID"].ToString() + "'");
                for (int i = 0; i < tnode.Nodes.Count; i++)
                {
                    (tnode.Nodes)[i]= tvNodeAdd((tnode.Nodes)[i],"Select ID,Name from CheckRoute Where sit_id="+(tnode.Nodes)[i].Tag);
                }
                tvRoute.Nodes.Add(tnode);
            }
            dr.Close();
            
        }

        private TreeNode tvNodeAdd( TreeNode node,string comstr)
        {
            SqlDataReader dr = SqlHelper.ExecuteReader(comstr);
            if (dr == null)
            {
                dr.Dispose();
                return null;
            }
            while (dr.Read())
            {
                TreeNode tn = new TreeNode();
                tn.Text = dr["Name"].ToString();
                tn.Tag = dr["ID"];
                node.Nodes.Add(tn);
            }
            dr.Close();
            return node;
        }

        private void lstPointInit()
        {
            DataSet ds = SqlHelper.ExecuteDataset("Select ID,Name From PhysicalCheckPoint");
            lstPoint.DataSource=ds.Tables[0];
            lstPoint.DisplayMember = "Name";
            lstPoint.ValueMember = "ID";
        }

        private void lstRoutePiontInit(string route_id)
        {
            DataSet ds = SqlHelper.ExecuteDataset("Select ID,Name From LogicalCheckPoint where route_ID="+route_id);
            lstRoutePoint.DataSource=ds.Tables[0];
            lstRoutePoint.DisplayMember = "Name";
            lstRoutePoint.ValueMember = "ID";
        }

        private void tvRoute_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvRoute.SelectedNode.Nodes.Count == 0&&tvRoute.SelectedNode.Level==2)
            {
                lstRoutePiontInit(tvRoute.SelectedNode.Tag.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstPoint.SelectedItems.Count; i++)
            {
                lstRoutePoint.Items.Add(lstPoint.SelectedItems[i]);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstRoutePoint.SelectedItems.Count; i++)
            {
                lstRoutePoint.Items.Remove(lstRoutePoint.SelectedItems[i]);
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            int index=lstRoutePoint.SelectedIndex;
            object selobj = lstRoutePoint.SelectedItem;
            object upobj = lstRoutePoint.Items[index - 1];

               
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            lstRoutePoint.SelectedIndex = lstRoutePoint.SelectedIndex -1;
        }

    }
}
