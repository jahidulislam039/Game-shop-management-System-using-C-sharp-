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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accessories F5 = new Accessories();
            F5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F F2 = new F();
            F2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerLibrary CL1 = new CustomerLibrary();
            CL1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerProfile CP1 = new CustomerProfile();
            CP1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cart C1 = new Cart();
            C1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }
    }
   
}
