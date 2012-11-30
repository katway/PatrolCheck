using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WorkStation
{
    public partial class ReportSearchByPlan : DevExpress.XtraReports.UI.XtraReport
    {
        
        public ReportSearchByPlan(DataSet ds)
        {
            InitializeComponent();
            reportSearchByPoint1.SetTable(ds);
        }
        const string sShowDetail = "显示巡检项信息";
        const string sHideDetail = "隐藏巡检项信息";

        ArrayList expandedValues = new ArrayList();

        bool ShouldShowDetail(int catID)
        {
            return expandedValues.Contains(catID);
        }

        private void ShowDetail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = (XRLabel)sender;
            if (ShouldShowDetail((int)label.Tag))
            {
                label.Text = sHideDetail;
            }
            else
            {
                label.Text = sShowDetail;
            }

        }

        private void ShowDetail_PreviewMouseMove(object sender, PreviewMouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void ShowDetail_PreviewClick(object sender, PreviewMouseEventArgs e)
        {
            int index = (int)e.Brick.Value;

            bool showDetail = ShouldShowDetail(index);
            if (showDetail)
            {
                expandedValues.Remove(index);
            }
            else
            {
                expandedValues.Add(index);
            }
            CreateDocument();

        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = !ShouldShowDetail((int)GetCurrentColumnValue("CategoryID"));
        }

    }
}
