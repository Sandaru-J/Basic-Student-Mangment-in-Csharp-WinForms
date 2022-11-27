using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            ucAddStd1.Hide();
            ucShwStd1.Hide();
            ucShwCrs1.Hide();
            ucAdCrs1.Hide();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ucAddStd1.Show();
            ucAddStd1.BringToFront();
            panel4.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnVwStd_Click(object sender, EventArgs e)
        {
            ucShwStd1.Show();
            ucShwStd1.BringToFront();
            panel4.Hide();
        }

        private void btnAdCrs_Click(object sender, EventArgs e)
        {
            ucAdCrs1.Show();
            ucAdCrs1.BringToFront();
            panel4.Hide();
        }

        private void btnVwCrs_Click(object sender, EventArgs e)
        {
            ucShwCrs1.Show();
            ucShwCrs1.BringToFront();
            panel4.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LandingForm lf = new LandingForm();
            lf.Show();
        }
    }
}
