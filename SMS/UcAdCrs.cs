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
    
    public partial class UcAdCrs : UserControl
    {
        OleDbConnection conn;
        public UcAdCrs()
        {
            InitializeComponent();
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            txtCap.Text = "";
            txtCrsName.Text = "";
            txtCrsDur.Text = "";
            txtCrsCord.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //var path = Application.StartupPath + "";
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Sandaru/Desktop/SMS/SMS/smsDb.accdb");


                string sqlQuery = "INSERT INTO CourseTbl (`CourseName`,`Duration`,`Capacity`,`Cordinator`) values (?,?,?,?)";

                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {

                    conn.Open();
                    cmd.Parameters.AddWithValue("@CourseName", this.txtCrsName.Text);
                    cmd.Parameters.AddWithValue("@Duration", this.txtCrsDur.Text);
                    cmd.Parameters.AddWithValue("@Capacity", this.txtCap.Text);
                    cmd.Parameters.AddWithValue("@Cordinator", this.txtCrsCord.Text);
                    cmd.ExecuteNonQuery();
                }
                System.Windows.Forms.MessageBox.Show("Course Added Successfully");
                txtCap.Text = "";
                txtCrsName.Text = "";
                txtCrsDur.Text = "";
                txtCrsCord.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
    }
}
