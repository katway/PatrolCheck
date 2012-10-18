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
        }

        private void frmAddRoute_Load(object sender, EventArgs e)
        {
            tvRouteInit(tvRoute);
            lstPointInit();
        }

        public static void tvRouteInit(TreeView tvRoute)
        {
            tvRoute.Nodes.Clear();
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

        private static TreeNode tvNodeAdd( TreeNode node,string comstr)
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
            if (index == 0)
            {
                MessageBox.Show("已经到顶");
                return;
            }
            object selobj = lstRoutePoint.SelectedItem;
            object upobj = lstRoutePoint.Items[index - 1];
            lstRoutePoint.Items[index] = upobj;
            lstRoutePoint.Items[index - 1] = selobj;

            lstRoutePoint.SelectedIndex = index - 1;
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            int index = lstRoutePoint.SelectedIndex;
            if (index == lstRoutePoint.Items.Count - 1)
            {
                MessageBox.Show("已经到底");
                return;
            }
            object selobj = lstRoutePoint.SelectedItem;
            object downobj=lstRoutePoint.Items[index+1];
            lstRoutePoint.Items[index] = downobj;
            lstRoutePoint.Items[index + 1] = selobj;

            lstRoutePoint.SelectedIndex = index + 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string route_id="";
            if (tvRoute.SelectedNode.Level == 2 && tvRoute.SelectedNode.Nodes.Count == 0)
            {
                route_id = tvRoute.SelectedNode.Tag.ToString();
            }
            else
            {
                MessageBox.Show("请选择要保存的路线");
                return;
            }
            string[] strSqls=null;
            if (lstRoutePoint.Items.Count > 0)
            {
                strSqls = new string[lstRoutePoint.Items.Count];
            }
            else
            {
                MessageBox.Show("请往路线中添加巡检点");
                return;
            }
            for (int i = 0; i < lstRoutePoint.Items.Count; i++)
            {
                BoxItem obj = (BoxItem)lstRoutePoint.Items[i];
                strSqls[i] = "Insert Into LogicalCheckPoint(Route_ID,PhysicalPoint_ID) values("+route_id+","+obj.Value+")";
            }
            try
            {
                int _ret = SqlHelper.ExecuteSqls(strSqls);
            }
            catch
            {
                MessageBox.Show("保存失败，请稍后再试");
            }
            
        }

        private void 新建路线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddRoutName rn = new frmAddRoutName(ref this.tvRoute);
            rn.Show();
        }

    }
}
