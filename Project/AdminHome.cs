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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeManagement EM1 = new EmployeeManagement();
            EM1.Show();
            this.Hide();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GameManagement GM1 = new GameManagement();
            GM1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerManagement CM1 = new CustomerManagement();
            CM1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesManagement SM1 = new SalesManagement();
            SM1.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLogin AL1 = new AdminLogin();
            AL1.Show();
            this.Hide();
        }
    }
}
