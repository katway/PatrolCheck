﻿using System;
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
    public partial class frmReportSearchByPoint : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public frmReportSearchByPoint()
        {
            InitializeComponent();
        }

        private void frmReportSearchByOperator_Load(object sender, EventArgs e)
        {
            bindSite();
            bindPost();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlPoint = @"select 
                                   p.ID ,
                                   (select name from PhysicalCheckPoint where  id=l.physicalPoint_id) as PointName,
                                   p.StartTime,p.EndTime,p.Duration,
                                   (select name from checkroute where id=l.route_id) as RouteName,
                                   (select name from checktask where id=r.task_id) as TaskName,
                                   (select name from checkplan where id=(select plan_id from checktask where id=r.task_id)) as PlanName 
                           From PointChecking p 
                           left join LogicalCheckPoint l on p.LogicPoint_ID=l.id
                           left join Routechecking r on p.routechecking_id=r.id where p.StartTime>='"+dtpStart.Value+"' and p.EndTime<='"+dtpEndTime.Value+"'";
            if (cboSite.SelectedValue.ToString() != "-1")
            {
                sqlPoint += " and p.LogicPoint_ID in (select id from LogicalCheckPoint where physicalpoint_id in(select id from physicalcheckpoint where site_id=" + cboSite.SelectedValue + "))";
            }
            if (cboPoint.SelectedValue.ToString() != "-1")
            {
                sqlPoint += " and p.LogicPoint_ID =(select id from logicalcheckpoint where physicalpoint_id=" + cboPoint.SelectedValue + ")";
            }
            if (cboOperator.SelectedValue.ToString() != "-1")
            {
                sqlPoint += " and r.Employee_id="+cboOperator.SelectedValue;
            }
            
            string sqlItem = @"select 
                                 P.ID,i.ID as ItemCheckingID,c.name as ItemName,
                                 i.BooleanValue,i.NumericalValue,i.TextValue,i.PictureFile 
                               from itemchecking i 
                                    left join pointchecking p  on i.pointchecking_id=p.id
                                    left join checkitem c on i.item_id=c.id where p.StartTime>='" + dtpStart.Value + "' and p.EndTime<='" + dtpEndTime.Value + "'";
            if (cboItem.SelectedValue.ToString() != "-1")
            {
                sqlItem += " and i.item_id="+cboItem.SelectedValue;
            }
            DataSet dsTables = SqlHelper.ExecuteDataset(sqlPoint+";"+sqlItem);
            dsTables.Relations.Add(new DataRelation("PointToItem",dsTables.Tables[0].Columns["ID"],dsTables.Tables[1].Columns["ID"]));
            gridControl1.DataSource = dsTables.Tables[0];
        }

        private void bindPost()
        {
            string sql = "select ID,Name From Post where validstate=1";
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = -1; dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboPost.DisplayMember = "Name";
            cboPost.ValueMember = "ID";
            cboPost.DataSource = ds.Tables[0];
        }
        private void bindSite()
        {
            string sql = "select ID,Name From Site where validstate=1";
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr,0);
            cboSite.DisplayMember = "Name";
            cboSite.ValueMember = "ID";
            cboSite.DataSource=ds.Tables[0];
        }
        private void bindPoint(object siteid)
        {
            string sql = "select ID,Name From PhysicalCheckPoint where site_id="+siteid;
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr,0);
            cboPoint.ValueMember = "ID";
            cboPoint.DisplayMember = "Name";
            cboPoint.DataSource=ds.Tables[0];
        }
        private void bindItem(object pointid)
        {
            string sql = "select ID,Name From CheckItem where phy_id="+pointid;
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboItem.ValueMember = "ID";
            cboItem.DisplayMember = "Name";
            cboItem.DataSource = ds.Tables[0];
        }

        private void cboSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSite.SelectedValue == null) return;
            bindPoint(cboSite.SelectedValue);
        }
        private void cboPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPoint.SelectedValue == null) return;
            bindItem(cboPoint.SelectedValue);
        }
        private void cboPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPost.SelectedValue == null) return;
            string sql = "select e.ID,e.Name from Employee e left join post_employee pe on e.id=pe.employee_id where pe.post_id="+cboPost.SelectedValue;
            DataSet ds = SqlHelper.ExecuteDataset(sql);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = "-1";
            dr[1] = "全部";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cboOperator.DisplayMember = "Name";
            cboOperator.ValueMember = "ID";
            cboOperator.DataSource = ds.Tables[0];
            ds.Dispose();
        }
    }
}