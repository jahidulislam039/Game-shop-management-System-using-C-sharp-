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
    public partial class ACMirage : Form
    {
        public ACMirage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F F2 = new F();
            F2.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            try
            {
                SqlCommand sq2 = new SqlCommand("insert into Cart(UID,PName,Quantity,Price,platform) values(@Uid,@PN,@QT,@PR,@PT)", Con);
                sq2.Parameters.AddWithValue("@Uid", LoggedinUser.Id);
                sq2.Parameters.AddWithValue("@PN", "AC Mirage");
                sq2.Parameters.AddWithValue("@PR", 29.99);
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
