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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            LandingForm lform = new LandingForm();
            lform.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            LandingForm lform = new LandingForm();
            lform.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsrNm.Text = " ";
            txtPsswrd.Text = " ";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if(txtUsrNm.Text=="Admin" && txtPsswrd.Text=="12345")
            {
                this.Hide();
                Menu Mn = new Menu();
                Mn.Show();
            }else
            {
                MessageBox.Show("Invalid Username or Password try Again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsrNm.Text = "";
                txtPsswrd.Text = "";
                
            }
            
        }
    }
}
