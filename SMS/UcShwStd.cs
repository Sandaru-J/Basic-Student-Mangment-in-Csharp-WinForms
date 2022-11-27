using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class UcShwStd : UserControl
    {
        public UcShwStd()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        private void UcShwStd_Load(object sender, EventArgs e)
        {
            /*conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Sandaru/Desktop/SMS/SMS/smsDb.accdb");
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select StudentName, NIC, DoB, Course from StdTable");
            OleDbDataReader reader= cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);

            dataGridView2.DataSource = dt;

            conn.Close();*/

        }

        private void dataload()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Sandaru/Desktop/SMS/SMS/smsDb.accdb");
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select StudentName, NIC, DoB, Course from StdTable", conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);
                dataGridView2.DataSource = dt;

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void UcShwStd_Load_1(object sender, EventArgs e)
        {
            dataload();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataload();
        }
    }
}
