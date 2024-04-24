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
    public partial class GameManagement : Form
    {
        public GameManagement()
        {
            InitializeComponent();
            DisplayGames();
        }
        private void DisplayGames()
        {
            SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con.Open();
                string Query = "select * from Gamess";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            try
            {

                if (ID.Text == "" || name.Text == "" || releaseYear.Text == "" || price.Text == "" || platform.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    SqlCommand sq2 = new SqlCommand("insert into Gamess(GID,GNAME,RELEASEYEAR,PRICE,PLATFORM) values(@ID,@NA,@RY,@PR,@PL)", Con);
                    sq2.Parameters.AddWithValue("@ID", ID.Text);
                    sq2.Parameters.AddWithValue("@NA", name.Text);
                    sq2.Parameters.AddWithValue("@RY", releaseYear.Text);
                    sq2.Parameters.AddWithValue("@PR", price.Text);
                    sq2.Parameters.AddWithValue("@PL", platform.Text);

                    sq2.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Game Added");
                    DisplayGames();


                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                if (ID.Text == "")
                {
                    MessageBox.Show("Enter Game ID");
                }

                else
                {
                    Con.Open();
                    string Query = "delete from Gamess WHERE ID = '" + ID.Text + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayGames();
                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            name.Text = "";
            releaseYear.Text = "";
            price.Text = "";
            platform.Text ="" ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminHome AH1 = new AdminHome();
            AH1.Show();
            this.Hide();
        }
    }
    
}

