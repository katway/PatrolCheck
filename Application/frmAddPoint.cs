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
    public partial class frmAddPoint : Form
    {
        public frmAddPoint()
        {
            InitializeComponent();
        }

        private void frmAddPoint_Load(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
            getList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlParameter[] pars = new SqlParameter[] { 
                    new SqlParameter("@name",SqlDbType.NVarChar),
                    new SqlParameter("@alias",SqlDbType.NVarChar),
                    new SqlParameter("@rfid",SqlDbType.Int)
            };
            pars[0].Value = this.txtName.Text.Trim();
            pars[1].Value = this.txtAlias.Text.Trim();

            string str_select = "Select ID From Rrid Where Name='"+this.txtRelation.Text.Trim()+"'";
            string str_rfid = (SqlHelper.ExecuteScalar("connectionstring",CommandType.Text,str_select)).ToString();
            pars[2].Value = str_rfid;

            string str_insert = "Insert Into PhysicalCheckPoint([Name],Alias,Rfi_Id) values(@name,@alias,@rfid)";

            Object obj_ret = SqlHelper.ExecuteNonQuery(str_insert);
            if (obj_ret.ToString() == "1")
            {
                MessageBox.Show("保存成功");
            }
            getList();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

        private void getList()
        {
            SqlDataReader datareader= SqlHelper.ExecuteReader("Select P.ID,P.Name,P.Alias,R.RFID from PhysicalCheckPoint P,Rfid R where P.Rfi_ID=R.ID");
            if (datareader.Read())
            {
                listView1.Items.Add(new ListViewItem(new string[]{
                   datareader["ID"].ToString(),
                   datareader["Name"].ToString(),
                   datareader["Alias"].ToString(),
                   datareader["RFID"].ToString()
                }));
            }
            datareader.Close();
        }
       
    }
}
