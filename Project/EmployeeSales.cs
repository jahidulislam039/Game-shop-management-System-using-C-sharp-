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
    public partial class EmployeeSales : Form
    {
        public EmployeeSales()
        {
            InitializeComponent();
            DisplaySales();
        }

        private void DisplaySales()
        {
            SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                Con.Open();
                string Query = "select * from Sales";
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

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            try
            {

                if ( name.Text == "" || Games.Text == "" || accessories.Text == "" || price.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    SqlCommand sq2 = new SqlCommand("insert into Sales(USERNAME,GAMES,ACCESSORIES,PRICE) values(@UN,@GA,@AS,@PR)", Con);
                    sq2.Parameters.AddWithValue("@UN", name.Text);
                    sq2.Parameters.AddWithValue("@GA", Games.Text);
                    sq2.Parameters.AddWithValue("@AS", accessories.Text);
                    sq2.Parameters.AddWithValue("@PR", price.Text);

                    sq2.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Checkout Successfull");
                    DisplaySales();


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            Games.Text = "";
            accessories.Text = "";
            price.Text = "";
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
