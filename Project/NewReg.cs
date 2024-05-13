using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace Project
{
    public partial class NewReg : Form
    {
        String randomCode;
        public static String to;
        public NewReg()
        {
            InitializeComponent();
        }
        

        private void button22_Click(object sender, EventArgs e)
        {
            Login F6 = new Login();
            F6.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void NewReg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (randomCode == (enterOTP.Text).ToString())
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mystr\source\repos\Project\Project\Games.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                if (name.Text == "" || username.Text == "" || password.Text == "" || phone.Text == "" || Email.Text == "")
                {
                    MessageBox.Show("Please Insert all Information");
                }

                else
                {
                    try
                    {
                        SqlCommand sq2 = new SqlCommand("insert into USSER(NAME,USERNAME,PASSWORD,PHONE,EMAIL) values(@NA,@UN,@PASS,@PN,@EM)", con);
                        sq2.Parameters.AddWithValue("@NA", name.Text);
                        sq2.Parameters.AddWithValue("@UN", username.Text);
                        sq2.Parameters.AddWithValue("@PASS", password.Text);
                        sq2.Parameters.AddWithValue("@PN", phone.Text);
                        sq2.Parameters.AddWithValue("@EM", Email.Text);
                        sq2.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Registration Successfull");
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }


                }
            }
            else
            {
                MessageBox.Show("Wrong OTP");
            }
        }

        private void OTPsend_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(9999)).ToString();
            MailMessage message = new MailMessage();
            to = (Email.Text).ToString();
            from = "projectacc08@gmail.com";
            pass = "yvrw gfxl revv yqdv";
            messageBody = "Your OTP to register in Redemption Game Shop is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "OTP to register in Redemption Game Shop";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OTPverify_Click(object sender, EventArgs e)
        {
            
        }
    }
}
