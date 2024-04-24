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
    public partial class SalesManagement : Form
    {
        public SalesManagement()
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

                SqlCommand sq1 = new SqlCommand("select * from Sales", Con);
                DataTable dt = new DataTable();

                SqlDataReader sdr = sq1.ExecuteReader();
                dt.Load(sdr);

                dataGridView1.DataSource = dt;
                Con.Close();

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
            AdminHome AH1 = new AdminHome();
            AH1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalesManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
