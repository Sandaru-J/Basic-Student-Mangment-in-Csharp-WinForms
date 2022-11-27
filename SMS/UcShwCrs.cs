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
    public partial class UcShwCrs : UserControl
    {
        OleDbConnection conn;
        public UcShwCrs()
        {
            InitializeComponent();
        }
        private void dataload()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Sandaru/Desktop/SMS/SMS/smsDb.accdb");
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select  CourseName, Duration, Capacity, Cordinator from CourseTbl", conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void UcShwCrs_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataload();
        }
    }
}
