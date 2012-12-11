using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace WorkStation
{
    public partial class frmRoute : Form
    {
        public frmRoute()
        {
            InitializeComponent();
        }
        WorkStation.Properties.Settings wset = new Properties.Settings();

        List<TreeNode> listPhy = new List<TreeNode>();
        List<TreeNode> listLogical = new List<TreeNode>();
        private void frmAddRoute_Load(object sender, EventArgs e)
        {
            //tvRouteInit(this.tvRoute);
            Thread th1 = new Thread(tvRouteInit);
            th1.Start(this.tvRoute);
            //Thread th2 = new Thread(new ThreadStart(getTvPhysicalPoint));
            //th2.Start();
            //Thread th3 = new Thread(FM_Init);
            //th3.Start();  

            //chkRoute.Checked = wset.tvRoute;
            //chkLogicalPoint.Checked = wset.tvLogicalPoint;
            //chkPhysicalPoint.Checked = wset.tvPhysicalPoint;

            //if (wset.tvRoute) tvRoute.ExpandAll(); else tvRoute.CollapseAll();
            //if (wset.tvPhysicalPoint) tvPhysicalPoint.ExpandAll(); else tvPhysicalPoint.CollapseAll();
            //if (wset.tvLogicalPoint) tvLogicalPoint.ExpandAll(); else tvLogicalPoint.CollapseAll();
                  
        }

        private void FM_Init()
        {
            this.BeginInvoke((Action)delegate 
            {
                chkRoute.Checked = wset.tvRoute;
                chkLogicalPoint.Checked = wset.tvLogicalPoint;
                chkPhysicalPoint.Checked = wset.tvPhysicalPoint;

                if (wset.tvRoute) tvRoute.ExpandAll(); else tvRoute.CollapseAll();
                if (wset.tvPhysicalPoint) tvPhysicalPoint.ExpandAll(); else tvPhysicalPoint.CollapseAll();
                if (wset.tvLogicalPoint) tvLogicalPoint.ExpandAll(); else tvLogicalPoint.CollapseAll();
            });
           
        }

        private void tvRoute_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvRoute.SelectedNode.Nodes.Count == 0 && tvRoute.SelectedNode.Level == 2)
            {
                getTvLogicalPoint(tvRoute.SelectedNode.Tag.ToString());
                getTvPhysicalPoint(tvRoute.SelectedNode.Parent.Tag.ToString());
                tbRoute.ForeColor = tvRoute.SelectedNode.ForeColor;
                tbRoute.Text = tvRoute.SelectedNode.Text;
                labRouteID.Text = tvRoute.SelectedNode.Tag.ToString();
            }
            else if (tvRoute.SelectedNode.Level == 1)
            {
                getTvPhysicalPoint(tvRoute.SelectedNode.Tag.ToString());
            }
            else
            {
                tbRoute.Text = "";
                labRouteID.Text = "";
                tvLogicalPoint.Nodes.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listLogical = listPhy;
            if (labRouteID.Text == "" && tbRoute.Text == "")
            {
                MessageBox.Show("请选择路线");
                return;
            }
            foreach (TreeNode node in listPhy)
            {
                if (node.Parent != null) //node有上级
                {
                    bool isExit = false;
                    foreach (TreeNode no in tvLogicalPoint.Nodes)
                    {
                        if (no.Parent == null && no.Tag.ToString() == node.Parent.Tag.ToString()) //如果存在node的上级
                        {
                            bool isChild = false;
                            foreach (TreeNode t in no.Nodes)
                            {
                                if (t.Tag.ToString() == node.Tag.ToString() && t.Text == node.Text)
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
                        if (no.Parent == null && no.Tag.ToString() == node.Tag.ToString())
                        {
                            isExitNode = true;
                            break;
                        }
                    }
                    if (isExitNode == false)
                    {
                        //TreeNode tn = new TreeNode();
                        //tn.Text = node.Text;
                        //tn.Tag = node.Tag;
                        tvLogicalPoint.Nodes.Add((TreeNode)(node.Clone()));
                    }
                }
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in listLogical)
            {            
                if (node.Parent == null)
                {
                    Object obj_ID = SqlHelper.ExecuteScalar("Select ID From LogicalCheckPoint Where Route_ID=" + labRouteID.Text + " and PhysicalPoint_ID=" + node.Tag);
                    if (obj_ID != null)
                    {
                        SqlHelper.ExecuteNonQuery("Delete From LogicalCheckPoint  where ID=" + obj_ID.ToString());
                        if (node.Nodes.Count > 0)
                        {
                            foreach (TreeNode de in node.Nodes)
                            {
                                SqlHelper.ExecuteNonQuery("Delete From LogicalPoint_Item Where ID=" + obj_ID.ToString());
                            }
                        }
                    }
                }
                tvLogicalPoint.Nodes.Remove(node);
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (listLogical.Count == 0) return;
            TreeNode selnode = listLogical[0];
            TreeNode prenode = selnode.PrevNode;
            TreeNode newnode = selnode.Clone() as TreeNode;
            if (prenode != null)
            {
                if (selnode.Parent != null)
                {
                    selnode.Parent.Nodes.Insert(prenode.Index, newnode);
                }
                else
                {
                    tvLogicalPoint.Nodes.Insert(prenode.Index, newnode);
                }
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
            TreeNode selnode = listLogical[0];
            TreeNode nextnode = selnode.NextNode;
            TreeNode newnode = selnode.Clone() as TreeNode;
            if (nextnode != null)
            {
                if (selnode.Parent != null)
                {
                    selnode.Parent.Nodes.Insert(nextnode.Index + 1, newnode);
                }
                else
                {
                    tvLogicalPoint.Nodes.Insert(nextnode.Index + 1, newnode);
                }
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
            foreach (TreeNode node in tvLogicalPoint.Nodes)
            {
                if (node.Level == 0 && node.Nodes.Count == 0)
                {
                    MessageBox.Show("请确保每个巡检点下有巡检项");
                    return;
                }
            }
            string route_id = "";
            if (labRouteID.Text != "")
            {
                route_id = tvRoute.SelectedNode.Tag.ToString();
            }
            else
            {
                MessageBox.Show("请选择要保存的路线");
                return;
            }
            for (int i = 0; i < tvLogicalPoint.Nodes.Count; i++)
            {
                if (tvLogicalPoint.Nodes[i].Level == 0)
                {
                    SqlParameter[] pars = new SqlParameter[] { 
                    new SqlParameter("@Route_ID",SqlDbType.BigInt),
                    new SqlParameter("@PhysicalPoint_ID",SqlDbType.BigInt),
                    new SqlParameter("@Name",SqlDbType.VarChar),
                    new SqlParameter("@Alias",SqlDbType.VarChar),
                    new SqlParameter("@ItemsID",SqlDbType.VarChar),
                    new SqlParameter("@ItemsIndex",SqlDbType.VarChar),
                    new SqlParameter("@OrderNumber",SqlDbType.Int)
                          };
                    pars[0].Value = labRouteID.Text;
                    pars[1].Value = tvLogicalPoint.Nodes[i].Tag;
                    pars[2].Value = tvLogicalPoint.Nodes[i].Text;
                    pars[3].Value = "";

                    string parValue = "",parIndex="";
                    foreach (TreeNode node in tvLogicalPoint.Nodes[i].Nodes)
                    {
                        parValue += node.Tag + ",";
                        parIndex += node.Index + ",";
                    }
                    pars[4].Value = parValue;
                    pars[5].Value = parIndex;
                    pars[6].Value = tvLogicalPoint.Nodes[i].Index;

                    int _ret = SqlHelper.ExecuteNonQuery("LogicalPointItemControl",CommandType.StoredProcedure,pars);
                }

            }
            getTvLogicalPoint(labRouteID.Text.Trim());

        }

        private void 新建路线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRouteNew rn = new frmRouteNew();
            rn.Left=this.Left+(this.Width-rn.Width)/2;
            rn.Top=this.Top+(this.Height-rn.Height)/2;
            rn.tView = this.tvRoute;
            rn.Show();
        }

        //获取路线上的逻辑巡检点
        private void getTvLogicalPoint(string route_id)
        {
            tvLogicalPoint.Nodes.Clear();
            SqlDataReader dr = SqlHelper.ExecuteReader("Select PhysicalPoint_ID,Name,ID From LogicalCheckPoint where route_ID=" + route_id +" order by ordernumber");
            if (dr == null) return;
            while (dr.Read())
            {
                TreeNode tnode = new TreeNode();
                tnode.Text = dr["Name"].ToString();
                tnode.Tag = dr["PhysicalPoint_ID"].ToString();
                tnode = tvNodeAdd(tnode, "select l.LogicPoint_ID as LIID,c.[Name],c.ID ,'' as Sequence from LogicalPoint_Item  l ,CheckItem c where l.Item_ID=c.ID and l.LogicPoint_ID=" + dr["ID"].ToString().Trim() + " order by l.inorder");
                tvLogicalPoint.Nodes.Add(tnode);
            }
            if (chkLogicalPoint.Checked)
                tvLogicalPoint.ExpandAll();
        }
        //获取物理巡检点
        private void getTvPhysicalPoint(string siteID)
        {
            tvPhysicalPoint.Nodes.Clear(); 
            SqlDataReader dr = SqlHelper.ExecuteReader("Select ID,Name From PhysicalCheckPoint Where Site_ID="+siteID);
            if (dr == null) { dr.Dispose(); return; }
            while (dr.Read())
            {
                TreeNode tnode = new TreeNode();
                tnode.Text = dr["Name"].ToString();
                tnode.Tag = dr["ID"].ToString();
                tnode = tvNodeAdd(tnode, "Select ID,Name,'' AS Sequence From CheckItem Where Phy_ID=" + dr["ID"].ToString().Trim());
                this.BeginInvoke((Action)delegate
                {
                   tvPhysicalPoint.Nodes.Add(tnode);
                });
                
            }
            dr.Close();
        }

        //获取路线
        public static void tvRouteInit(Object tvRoute)
        {
            ((TreeView)tvRoute).Nodes.Clear();
            SqlDataReader dr = SqlHelper.ExecuteReader("Select ID,Name From Company");
            while (dr.Read())
            {
                TreeNode tnode = new TreeNode();
                tnode.Text = dr["Name"].ToString();
                tnode.Tag = dr["ID"].ToString();
                tnode = tvNodeAdd(tnode, "select ID,Name,''AS Sequence from Site where Company_ID='" + dr["ID"].ToString() + "'");
                for (int i = 0; i < tnode.Nodes.Count; i++)
                {
                    (tnode.Nodes)[i] = tvNodeAdd((tnode.Nodes)[i], "Select ID,Name,Sequence as Sequence from CheckRoute Where site_id=" + (tnode.Nodes)[i].Tag);
                }
                ((TreeView)tvRoute).BeginInvoke((Action)delegate 
                {
                    ((TreeView)tvRoute).Nodes.Add(tnode);
                });
                
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
                if (dr["Sequence"].ToString() == "1")
                {
                    tn.ForeColor = Color.Red;
                }
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

        public void PaintSelectedNode(TreeView tv, List<TreeNode> listNodes)
        {
            foreach (TreeNode trNode in tv.Nodes)
            {
                trNode.BackColor = tv.BackColor;
                trNode.ForeColor = tv.ForeColor;
                ClearSelectedNode(tv, trNode);
            }
            foreach (TreeNode node in listNodes)
            {
                node.BackColor = SystemColors.Highlight;
                node.ForeColor = SystemColors.HighlightText;
            }
        }

        public void ClearSelectedNode(TreeView tv, TreeNode tr)
        {
            foreach (TreeNode node in tr.Nodes)
            {
                node.BackColor = tv.BackColor;
                node.ForeColor = tv.ForeColor;
                ClearSelectedNode(tv, node);
            }
        }

        private void tvLogicalPoint_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.Index.ToString());
            listLogical.Clear();
            listLogical.Add(e.Node);
            PaintSelectedNode(tvLogicalPoint, listLogical);
        }

        private void tvPhysicalPoint_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
            listPhy.Clear();
            listPhy.Add(e.Node);
            PaintSelectedNode(tvPhysicalPoint, listPhy);
        }

        private void 删除路线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labRouteID.Text=="")
            {
                MessageBox.Show("请选择具体路线");
                return;
            }
            string[] strsDel=new string[3];
            strsDel[0]="Delete From LogicalPoint_Item Where ID in (Select ID From LogicalCheckPoint Where Route_ID=" + labRouteID.Text + ")";
            strsDel[1] = "Delete From LogicalCheckPoint Where Route_ID=" + labRouteID.Text;
            strsDel[2] = "Delete From CheckRoute Where ID=" + labRouteID.Text;

            try
            {
                SqlHelper.ExecuteSqls(strsDel);
            }
            catch
            {
                MessageBox.Show("删除失败。请稍后再试");
            }
            finally
            {
                tvRouteInit(tvRoute);
                if (chkRoute.Checked) tvRoute.ExpandAll();
            }
        }

        private void chkRoute_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRoute.Checked == true) tvRoute.ExpandAll(); else tvRoute.CollapseAll();
        }

        private void chkLogicalPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLogicalPoint.Checked)
                tvLogicalPoint.ExpandAll();
            else
                tvLogicalPoint.CollapseAll();
        }

        private void chkPhysicalPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhysicalPoint.Checked)
                tvPhysicalPoint.ExpandAll();
            else
                tvPhysicalPoint.CollapseAll();
        }

        private void frmAddRoute_FormClosing(object sender, FormClosingEventArgs e)
        {
            wset.tvLogicalPoint = chkLogicalPoint.Checked;
            wset.tvPhysicalPoint = chkPhysicalPoint.Checked;
            wset.tvRoute = chkRoute.Checked;
            wset.Save();
        }

        private void tvRoute_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                frmRouteNew fn = new frmRouteNew();
                fn.Left=this.Left+(this.Width-fn.Width)/2;
                fn.Top = this.Top + (this.Height - fn.Height) / 2;
                fn.tView = tvRoute;
                fn.isEdit = true;
                fn.routeID = e.Node.Tag;
                fn.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tvRoute.SelectedNode!=null&& tvRoute.SelectedNode.Level == 2)
            {
                frmRouteNew fn = new frmRouteNew();
                fn.tView = tvRoute;
                fn.Left=this.Left+(this.Width-fn.Width)/2;
                fn.Top = this.Top + (this.Height - fn.Height) / 2;
                fn.isEdit = true;
                fn.routeID = tvRoute.SelectedNode.Tag;
                fn.Show();
            }
        }

    }
}
