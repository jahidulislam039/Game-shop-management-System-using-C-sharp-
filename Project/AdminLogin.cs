using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Logiin L1 = new Logiin();
            L1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (username.Text == "Admin" && password.Text == "1234") 
            {
                AdminHome AH1 = new AdminHome();
                AH1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please inset the correct Information");
            }
            

            

        }
    }
}
