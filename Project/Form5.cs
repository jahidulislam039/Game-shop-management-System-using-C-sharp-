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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form27 F27 = new Form27();
            F27.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form28 F28 = new Form28();
            F28.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form29 F29 = new Form29();
            F29.Show();
            this.Hide();
        }
    }

 }

