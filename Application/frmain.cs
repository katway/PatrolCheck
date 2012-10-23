﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkStation
{
    public partial class frmain : Form
    {
        public frmain()
        {
            InitializeComponent();
        }
        private void Application_Load(object sender, EventArgs e)
        {
            btnItem_Click(sender, e);
        }
        private void ShowProject(int CurrentRow)
        {
            for (int i = 0; i < this.tableLayoutPanel1.RowStyles.Count; i++)
            {
                if (i == CurrentRow)
                {
                    this.tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Percent;
                    this.tableLayoutPanel1.RowStyles[i].Height = 1;
                }
                else
                {
                    this.tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Absolute;
                    this.tableLayoutPanel1.RowStyles[i].Height = 25;
                }
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            this.ShowProject(0);

            this.treeView1.Nodes.Clear();

            TreeNode root1 = new TreeNode("巡检项模版");
            this.treeView1.Nodes.Add(root1);

            TreeNode type_Build = new TreeNode("新建");
            root1.Nodes.Add(type_Build);

            TreeNode type_Edit = new TreeNode("编辑");
            root1.Nodes.Add(type_Edit);

            TreeNode type_Delete = new TreeNode("删除");
            root1.Nodes.Add(type_Delete);   
            root1.Toggle();           
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            this.ShowProject(1);
            this.treeView2.Nodes.Clear();

            TreeNode root1 = new TreeNode("任务管理");
            this.treeView2.Nodes.Add(root1);

            TreeNode type_Buld = new TreeNode("新建");
            root1.Nodes.Add(type_Buld);

            TreeNode type_Edit = new TreeNode("编辑");
            root1.Nodes.Add(type_Edit);

            TreeNode type_Delete = new TreeNode("删除");
            root1.Nodes.Add(type_Delete);

            TreeNode type_shenhe1= new TreeNode("审核");
            root1.Nodes.Add(type_shenhe1);

            TreeNode type_xiafa= new TreeNode("下发");
            root1.Nodes.Add(type_xiafa);

            TreeNode type_Exits = new TreeNode("退出");
            root1.Nodes.Add(type_Exits);                    

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.ShowProject(2);
            this.treeView3.Nodes.Clear();

            TreeNode root1 = new TreeNode("统计报表");
            this.treeView3.Nodes.Add(root1);

            TreeNode type_renyuan = new TreeNode("人员出勤统计");
            root1.Nodes.Add(type_renyuan);

            TreeNode type_xunjianxiang = new TreeNode("巡检项统计");
            root1.Nodes.Add(type_xunjianxiang);

            TreeNode type_chuqin = new TreeNode("出勤异常统计");
            root1.Nodes.Add(type_chuqin);

            TreeNode type_dianjian = new TreeNode("点检异常统计");
            root1.Nodes.Add(type_dianjian); 

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.ShowProject(3);
            this.treeView5.Nodes.Clear();

            TreeNode root1 = new TreeNode("巡检信息");
            this.treeView5.Nodes.Add(root1);

            TreeNode type_xunjianluxian = new TreeNode("巡检路线管理");
            root1.Nodes.Add(type_xunjianluxian);

            TreeNode type_xunjiandian = new TreeNode("巡检点管理");
            root1.Nodes.Add(type_xunjiandian);

            TreeNode type_xunjianxiang = new TreeNode("巡检项管理");
            root1.Nodes.Add(type_xunjianxiang);

            TreeNode type_shebeixunjianxiang = new TreeNode("设备巡检项管理");
            root1.Nodes.Add(type_shebeixunjianxiang);

        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            this.ShowProject(4);
            this.treeView6.Nodes.Clear();

            TreeNode root1 = new TreeNode("基础信息");
            this.treeView6.Nodes.Add(root1);

            TreeNode type_Name = new TreeNode("公司名称");
            root1.Nodes.Add(type_Name);

            TreeNode type_changqu = new TreeNode("厂区管理");
            root1.Nodes.Add(type_changqu);

            TreeNode type_chejian = new TreeNode("车间管理");
            root1.Nodes.Add(type_chejian);

            TreeNode type_gangwei = new TreeNode("岗位管理");
            root1.Nodes.Add(type_gangwei);

            TreeNode type_renyuan = new TreeNode("人员管理");
            root1.Nodes.Add(type_renyuan);

            TreeNode type_banci = new TreeNode("班次管理");
            root1.Nodes.Add(type_banci);

        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            this.ShowProject(5);
            this.treeView7.Nodes.Clear();

            TreeNode root1 = new TreeNode("卡片管理");
            this.treeView7.Nodes.Add(root1);

            TreeNode type_xinka = new TreeNode("录入新卡");
            root1.Nodes.Add(type_xinka);

            TreeNode type_yongtu = new TreeNode("编辑用途");
            root1.Nodes.Add(type_yongtu);

            TreeNode type_zhuxiaokapian = new TreeNode("注销卡片");
            root1.Nodes.Add(type_zhuxiaokapian);           

        }

      

       
    }
}
