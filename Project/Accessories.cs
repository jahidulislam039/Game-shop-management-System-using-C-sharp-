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
    public partial class Accessories : Form
    {
        public Accessories()
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
            Headphone F27 = new Headphone();
            F27.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mouse F28 = new Mouse();
            F28.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Keyboard F29 = new Keyboard();
            F29.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }

 }

