using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class NewReg : Form
    {
        public NewReg()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Logiin F6 = new Logiin();
            F6.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
