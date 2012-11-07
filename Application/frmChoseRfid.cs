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
            string strSql = null;
            if (cboItem.SelectedValue.ToString() == "1")
            {
                strSql = @"select R.ID as 标签卡ID,R.Rfid as RFID,
                                 (select meaning from codes where code= R.Purpose and purpose='rfidpurpose') as 用途,
                                  P.Name as 巡检点,
                                  E.Name as 巡检人员 
                                  from rfid R left join physicalcheckpoint P on R.ID=P.Rfid_id
                                            left join employee E on R.ID=E.Rfid_id";
            }
            else if (cboItem.SelectedValue.ToString() == "2")
            {
                strSql = @"select R.ID as 标签卡ID,R.Rfid as RFID,
                                 (select meaning from codes where code= R.Purpose and purpose='rfidpurpose') as 用途,
                                  P.Name as 巡检点,
                                  E.Name as 巡检人员 
                                  from rfid R left join physicalcheckpoint P on R.ID=P.Rfid_id
                                            left join employee E on R.ID=E.Rfid_id where R.Purpose=2";
            }
            else if (cboItem.SelectedValue.ToString() == "3")
            { }
            DataSet ds = SqlHelper.ExecuteDataset(strSql);
            dgvRfid.DataSource=ds.Tables[0];
        }

        private void Cbo_Init()
        {
            BoxItem item = new BoxItem("全部","1");
            cboItem.Items.AddRange(new Object[]{ new BoxItem("全部","-1"),new BoxItem("地点","2"), new BoxItem("人员","1")
            });
            cboItem.SelectedIndex = 0;
        }

        private void dgvRfid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if ((bool)dgvRfid.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
                {
                    dgvRfid.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgvRfid.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }            
        }

        private void btnChose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
