using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class lastOfUs : Form
    {
        public lastOfUs()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            F F2 = new F();
            F2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            try
            {
                SqlCommand sq2 = new SqlCommand("insert into Cart(Username,PName,Quantity,Price,platform) values(@UN,@PN,@QT,@PR,@PT)", Con);
                sq2.Parameters.AddWithValue("@UN", LoggedinUser.username);
                sq2.Parameters.AddWithValue("@PN", "The Last of Us");
                sq2.Parameters.AddWithValue("@PR", 59.99);
                sq2.Parameters.AddWithValue("@QT", 1);
                sq2.Parameters.AddWithValue("@PT", comboBox1.SelectedItem.ToString());

                sq2.ExecuteNonQuery();
                MessageBox.Show("Product Added to cart");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
