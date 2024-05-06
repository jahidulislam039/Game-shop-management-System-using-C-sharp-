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
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
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
                    SqlCommand cmd = new SqlCommand("select * from Emplyee WHERE username = @username and password =@password",Con);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    if(dt.Rows.Count>0)
                    {                        
                        EmployeeSales ES1 = new EmployeeSales();
                        ES1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect information");
                    }

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login L1 = new Login();
            L1.Show();
            this.Hide();
        }
    }
}
