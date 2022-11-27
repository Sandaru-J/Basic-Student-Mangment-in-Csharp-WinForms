using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SMS
{
    public partial class UcAddStd : UserControl
    {
        OleDbConnection conn;
        public UcAddStd()
        {
            InitializeComponent();
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            txtStdname.Text = "";
            txtNic.Text = "";
            txtDob.Text = "";
            txtCrs.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //var path = Application.StartupPath + "";
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Sandaru/Desktop/SMS/SMS/smsDb.accdb");
              

                string sqlQuery = "INSERT INTO StdTable (`StudentName`,`NIC`,`DoB`,`Course`) values (?,?,?,?)";

                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {

                    conn.Open();
                    cmd.Parameters.AddWithValue("@StudentName", this.txtStdname.Text);
                    cmd.Parameters.AddWithValue("@NIC", this.txtNic.Text);
                    cmd.Parameters.AddWithValue("@DoB", this.txtDob.Text);
                    cmd.Parameters.AddWithValue("@Course", this.txtCrs.Text);
                    cmd.ExecuteNonQuery();
                }
                    System.Windows.Forms.MessageBox.Show("Student Added successfully");
                txtStdname.Text = "";
                txtNic.Text = "";
                txtDob.Text = "";
                txtCrs.Text = "";
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
    }
}
