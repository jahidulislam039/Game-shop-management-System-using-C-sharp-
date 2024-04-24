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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand("select * from USSER WHERE username = @username and password =@password", Con);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfull");

                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Incorrect information");
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewReg NR1 = new NewReg();
            NR1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeLogin EL1 = new EmployeeLogin();
            EL1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLogin AL1 = new AdminLogin();
            AL1.Show();
            this.Hide();
        }
    }
}
