using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class CustomerProfile : Form
    {
        private  string Uname = LoggedinUser.username;
        private int _id = LoggedinUser.Id;
        
        public CustomerProfile()
        {
            InitializeComponent();
            DisplayCustomer();
                       
        }
        private void DisplayCustomer()
        {
            SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            try
            {
                var sqlQuery = $@"select [name], phone, email, username from USSER where Id = {_id}";
                var sq1 = new SqlCommand(sqlQuery, Con);
                SqlDataReader sdr = sq1.ExecuteReader();

                sdr.Read();
                namel.Text = sdr["name"].ToString();

                phonel.Text = sdr["phone"].ToString();

                emaill.Text = sdr["email"].ToString();

                usernamel.Text = sdr["username"].ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            

        }

       
       

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            // SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");

            // Con.Open();
            // Con.Close();
            

        }
    }
}
