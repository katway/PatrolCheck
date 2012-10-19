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

        Boolean isRoute = false;//是否选中了路线
        List<TreeNode> listPhy = new List<TreeNode>();
        List<TreeNode> listLogical = new List<TreeNode>();
        private void frmAddRoute_Load(object sender, EventArgs e)
        {
            tvRouteInit(tvRoute);
            tvRoute.ExpandAll();
            if (isRoute == true&&tbRoute.Text!="")
            {
                getTvLogicalPoint(tbRoute.Text.Trim());
            }
            getTvPhysicalPoint();
        }

        private void tvRoute_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvRoute.SelectedNode.Nodes.Count == 0&&tvRoute.SelectedNode.Level==2)
            {
                getTvLogicalPoint(tvRoute.SelectedNode.Tag.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in listPhy)
            {
                if (node.Parent != null) //node有上级
                {
                    bool isExit = false;
                    foreach (TreeNode no in tvLogicalPoint.Nodes)
                    {
                        if (no.Parent == null && no.Tag == node.Parent.Tag) //如果存在node的上级
                        {
                            bool isChild = false;
                            foreach (TreeNode t in no.Nodes)
                            {
                                if (t.Tag == node.Tag && t.Text == node.Text)
                                {
                                    isChild = true; break;
                                }
                            }
                            if (isChild == false)
                            {
                                no.Nodes.Add((TreeNode)node.Clone());
                            }
                            isExit = true;
                            break;
                        }
                    }
                    if (isExit == false)//不存在，则新建node的上级
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = node.Parent.Text;
                        tn.Tag = node.Parent.Tag;
                        tn.Nodes.Add((TreeNode)node.Clone());
                        tvLogicalPoint.Nodes.Add(tn);
                    }
                }
                else //node没有上级
                {
                    bool isExitNode = false;
                    foreach (TreeNode no in tvLogicalPoint.Nodes)
                    {
                        if (no.Parent == null && no.Tag == node.Tag)
                        {
                            isExitNode = true;
                            break;
                        }
                    }
                    if (isExitNode == false)
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = node.Text;
                        tn.Tag = node.Tag;
                        tvLogicalPoint.Nodes.Add(tn);
                    }
                }
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in listLogical)
            {
                tvLogicalPoint.Nodes.Remove(node);
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            TreeNode selnode = tvLogicalPoint.SelectedNode;
            if (selnode.Parent != null)
            {
                selnode = selnode.Parent;
            }
            TreeNode prenode = selnode.PrevNode;
            TreeNode newnode = selnode.Clone() as TreeNode;
            if (prenode != null)
            {
                tvLogicalPoint.Nodes.Insert(prenode.Index, newnode);
                selnode.Remove();
                tvLogicalPoint.SelectedNode = newnode;
            }
            else
            {
                MessageBox.Show("已经到顶"); return;
            }
            
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            TreeNode selnode = tvLogicalPoint.SelectedNode;
            if (selnode.Parent != null)
            {
                selnode = selnode.Parent;
            }
            TreeNode nextnode = selnode.NextNode;
            TreeNode newnode = selnode.Clone() as TreeNode;
            if (nextnode != null)
            {
                tvLogicalPoint.Nodes.Insert(nextnode.Index, newnode);
                selnode.Remove();
                tvLogicalPoint.SelectedNode = newnode;
            }
            else
            {
                MessageBox.Show("已经到底"); return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string route_id="";
            //if (tvRoute.SelectedNode.Level == 2 && tvRoute.SelectedNode.Nodes.Count == 0)
            //{
            //    route_id = tvRoute.SelectedNode.Tag.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("请选择要保存的路线");
            //    return;
            //}
            //string[] strSqls=null;
            //if (lstRoutePoint.Items.Count > 0)
            //{
            //    strSqls = new string[lstRoutePoint.Items.Count];
            //}
            //else
            //{
            //    MessageBox.Show("请往路线中添加巡检点");
            //    return;
            //}
            //for (int i = 0; i < lstRoutePoint.Items.Count; i++)
            //{
            //    BoxItem obj = (BoxItem)lstRoutePoint.Items[i];
            //    strSqls[i] = "Insert Into LogicalCheckPoint(Route_ID,PhysicalPoint_ID) values("+route_id+","+obj.Value+")";
            //}
            //try
            //{
            //    int _ret = SqlHelper.ExecuteSqls(strSqls);
            //}
            //catch
            //{
            //    MessageBox.Show("保存失败，请稍后再试");
            //}
            
        }

        private void 新建路线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddRoutName rn = new frmAddRoutName(ref this.tvRoute);
            rn.Show();
        }

        //获取路线上的逻辑巡检点
        private void getTvLogicalPoint(string route_id)
        {
            tvLogicalPoint.Nodes.Clear();
            SqlDataReader dr = SqlHelper.ExecuteReader("Select ID,Name From LogicalCheckPoint where route_ID=" + route_id);
            if (dr == null) return;
            while (dr.Read())
            {
                TreeNode tnode = new TreeNode();
                tnode.Text = dr["Name"].ToString();
                tnode.Tag = dr["ID"].ToString();
                tnode = tvNodeAdd(tnode, "select l.ID,c.[Name] from LogicalPoint_Item  l ,CheckItem c where l.Item_ID=c.ID and l.ID="+dr["ID"].ToString().Trim());
                tvLogicalPoint.Nodes.Add(tnode);
            }

        }
        //获取物理巡检点
        private void getTvPhysicalPoint()
        {
            SqlDataReader dr = SqlHelper.ExecuteReader("Select ID,Name From PhysicalCheckPoint");
            if (dr == null) { dr.Dispose(); return; }
            while (dr.Read())
            {
                TreeNode tnode = new TreeNode();
                tnode.Text = dr["Name"].ToString();
                tnode.Tag = dr["ID"].ToString();
                tnode = tvNodeAdd(tnode, "Select ID,Name From CheckItem Where Phy_ID="+dr["ID"].ToString().Trim());
                tvPhysicalPoint.Nodes.Add(tnode);
            }
            dr.Close();
        }

        public static void tvRouteInit(TreeView tvRoute)
        {
            tvRoute.Nodes.Clear();
            SqlDataReader dr = SqlHelper.ExecuteReader("Select ID,Name From Company");
            if (dr == null){  dr.Dispose(); return; }
            while (dr.Read())
            {
                TreeNode tnode = new TreeNode();
                tnode.Text = dr["Name"].ToString();
                tnode.Tag = dr["ID"].ToString();
                tnode = tvNodeAdd(tnode, "select ID,Name from SiteArea where Company_ID='" + dr["ID"].ToString() + "'");
                for (int i = 0; i < tnode.Nodes.Count; i++)
                {
                    (tnode.Nodes)[i] = tvNodeAdd((tnode.Nodes)[i], "Select ID,Name from CheckRoute Where site_id=" + (tnode.Nodes)[i].Tag);
                }
                tvRoute.Nodes.Add(tnode);
            }
            dr.Close();

        }

        private static TreeNode tvNodeAdd(TreeNode node, string comstr)
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

        private void tvPhysicalPoint_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                if (listPhy.Contains(e.Node))
                {
                    listPhy.Remove(e.Node);
                }
                else
                {
                    listPhy.Add(e.Node);
                }
            }
            else
            {
                listPhy.Clear();
                listPhy.Add(e.Node);
            }
            PaintSelectedNode(tvPhysicalPoint, listPhy);
            e.Cancel = true;
        }

        private void tvLogicalPoint_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                if (listLogical.Contains(e.Node))
                {
                    listLogical.Remove(e.Node);
                }
                else
                {
                    listLogical.Add(e.Node);
                }
            }
            else
            {
                listLogical.Clear();
                listLogical.Add(e.Node);
            }
            PaintSelectedNode(tvLogicalPoint, listLogical);
            e.Cancel = true;
        }

        public void PaintSelectedNode(TreeView tv,List<TreeNode> listNodes)
        {
            foreach (TreeNode trNode in tv.Nodes)
            {
                trNode.BackColor = tv.BackColor;
                trNode.ForeColor = tv.ForeColor;
                ClearSelectedNode(tv,trNode);
            }
            foreach (TreeNode node in listNodes)
            {
                node.BackColor = SystemColors.Highlight;
                node.ForeColor = SystemColors.HighlightText;
            }
        }

        public void ClearSelectedNode(TreeView tv,TreeNode tr)
        {
            foreach (TreeNode node in tr.Nodes)
            {
                node.BackColor = tv.BackColor;
                node.ForeColor = tv.ForeColor;
                ClearSelectedNode(tv,node);
            }
        }

        private void tvLogicalPoint_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
