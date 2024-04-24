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
    public partial class EmplyeeManagement : Form
    {
        public EmplyeeManagement()
        {
            InitializeComponent();
            DisplayEMP();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayEMP()
        {
            try
            {
                Con.Open();
                string Query = "select * from Emplyee";
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

        private void EmplyeeManagement_Load(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Text == "" || name.Text == "" || phone.Text == "" || username.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();

                    string Query = "insert into Emplyee values('" + ID.Text + "', '" + name.Text + "','" + phone.Text + "', '" + username.Text + "','" + password.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Employee Added");
                    DisplayEMP();


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
            try
            {
                if (ID.Text == "")
                {
                    MessageBox.Show("Enter Emplyee ID");
                }

                else
                {
                    Con.Open();
                    string Query = "delete from Emplyee WHERE ID = '" + ID.Text + "';";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayEMP();
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
            phone.Text = "";
            username.Text = "";
            password.Text = "";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            phone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            username.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            password.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminHome AH1 = new AdminHome();
            AH1.Show();
            this.Hide();
        }

        
    }
}

