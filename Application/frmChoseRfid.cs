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
        public string RFID_ID = null;
        public string RFID_Rfid = null; 

        private void frmChoseRfid_Load(object sender, EventArgs e)
        {
            Cbo_Init();
            getDgvRfid();
        }

        private void getDgvRfid()
        {
            string strSql = null;
            string val=(cboItem.SelectedItem as BoxItem).Value.ToString();
            if (val == "-1")
            {
                strSql = @"select R.ID as 标签卡ID,R.Rfid as RFID,
                                 (select meaning from codes where code= R.Purpose and purpose='rfidpurpose') as 用途,
                                  P.Name as 巡检点,
                                  E.Name as 巡检人员 
                                  from rfid R left join physicalcheckpoint P on R.ID=P.Rfid_id
                                            left join employee E on R.ID=E.Rfid_id";
            }
            else if (val == "1")
            {
                strSql = @"select R.ID as 标签卡ID,R.Rfid as RFID,
                                 (select meaning from codes where code= R.Purpose and purpose='rfidpurpose') as 用途,
                                  P.Name as 巡检点,
                                  E.Name as 巡检人员 
                                  from rfid R left join physicalcheckpoint P on R.ID=P.Rfid_id
                                            left join employee E on R.ID=E.Rfid_id where R.Purpose=1";
            }
            else if (val == "2")
            {
                strSql = @"select R.ID as 标签卡ID,R.Rfid as RFID,
                                 (select meaning from codes where code= R.Purpose and purpose='rfidpurpose') as 用途,
                                  P.Name as 巡检点,
                                  E.Name as 巡检人员 
                                  from rfid R left join physicalcheckpoint P on R.ID=P.Rfid_id
                                            left join employee E on R.ID=E.Rfid_id where R.Purpose=2";
            }
            DataSet ds = SqlHelper.ExecuteDataset(strSql);
            dgvRfid.DataSource=ds.Tables[0];
        }

        private void Cbo_Init()
        {
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
            int count = 0;
            string id=null, rfid=null;
            for (int i = 0; i < dgvRfid.Rows.Count; i++)
            {
                try
                {
                    if ((bool)dgvRfid.Rows[i].Cells[0].Value == true)
                    {
                        id = dgvRfid.Rows[i].Cells[1].Value.ToString();
                        rfid = dgvRfid.Rows[i].Cells[2].Value.ToString();
                        count++;
                    }
                }
                catch
                {
                    continue;
                }
            }
            if (count != 1)
            {
                MessageBox.Show("请选择一个");
                return;
            }
            else
            {
                this.RFID_ID = id;
                this.RFID_Rfid = rfid;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDgvRfid();
        }

        private void dgvRfid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvRfid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            this.RFID_ID = dgvRfid.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.RFID_Rfid = dgvRfid.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.Close();
        }

    }
}
