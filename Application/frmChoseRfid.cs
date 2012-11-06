using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkStation
{
    public partial class frmChoseRfid : Form
    {
        public frmChoseRfid()
        {
            InitializeComponent();
        }

        private void frmChoseRfid_Load(object sender, EventArgs e)
        {
            Cbo_Init();
            getDgvRfid();
        }

        private void getDgvRfid()
        {
            DataSet ds = SqlHelper.ExecuteDataset(@"select R.ID as 标签卡ID,R.Rfid as RFID,
                                 (select meaning from codes where code= R.Purpose and purpose='rfidpurpose') as 用途,
                                  P.Name as 巡检点,
                                  E.Name as 巡检人员 
                                  from rfid R left join physicalcheckpoint P on R.ID=P.Rfid_id
                                            left join employee E on R.ID=E.Rfid_id");
            dgvRfid.DataSource=ds.Tables[0];
        }

        private void Cbo_Init()
        {
            BoxItem item = new BoxItem("全部","1");
            cboItem.Items.AddRange(new Object[]{ new BoxItem("全部","1"),new BoxItem("地点","2"), new BoxItem("人员","3")
            });
            cboItem.SelectedIndex = 0;
        }
    }
}
