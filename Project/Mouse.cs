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
    public partial class Mouse : Form
    {
        public Mouse()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accessories F5 = new Accessories();
            F5.Show();
            this.Hide();
        }
    }
}
