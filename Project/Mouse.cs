﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            try
            {
                SqlCommand sq2 = new SqlCommand("insert into Cart(UID,PName,Quantity,Price) values(@Uid,@PN,@QT,@PR)", Con);
                sq2.Parameters.AddWithValue("@Uid", LoggedinUser.Id);
                sq2.Parameters.AddWithValue("@PN", "G PRO Tenkeyless Keyboard");
                sq2.Parameters.AddWithValue("@PR", 29.99);
                sq2.Parameters.AddWithValue("@QT", comboBox1.SelectedItem.ToString());


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
