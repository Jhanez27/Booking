using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Booking
{
    public partial class ResetPassword : Form
    {
        String randomCode1;
        public static String to;
        MySqlConnection con = new MySqlConnection("SERVER = LOCALHOST;DATABASE = bookingsystem; UID = Jhanez28; PASSWORD = @Sur1nga123");
        public ResetPassword()
        {
            InitializeComponent();
        }
        private void ResetPassword_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            panel2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            panel_change.Visible = false;
        }
        private void customButton31_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(res_email.Text) || res_email.Text == "Enter Email Address")
            {
                MessageBox.Show("Enter a valid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                con.Open();
                MySqlDataAdapter sd = new MySqlDataAdapter("select Email_Address from user where Email_Address= '" + res_email.Text + "'", con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Email Not Registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Random rand = new Random();
                    randomCode1 = (rand.Next(999999)).ToString();
                    try
                    {
                        // OAuth 2.0 authentication
                        var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            new ClientSecrets
                            {
                                ClientId = "710913857464-3rvaos761uctb0hbaue1cd2d1qof48vj.apps.googleusercontent.com",
                                ClientSecret = "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"
                            },
                            new[] { "https://mail.google.com/" },
                            "user",
                            CancellationToken.None,
                            new FileDataStore("credential_file_path")).Result;

                        // Create SMTP client
                        using (var smtp = new SmtpClient())
                        {
                            // Configure SMTP client
                            smtp.Host = "smtp.gmail.com";
                            smtp.Port = 587;
                            smtp.EnableSsl = true;
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("ticketeasebookingnotification@gmail.com", "fxjm rmbl gozc kqrk");
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                            // Create mail message
                            using (var message = new MailMessage())
                            {
                                message.From = new MailAddress("ticketeasebookingnotification@gmail.com");
                                message.To.Add(res_email.Text);
                                message.Subject = "OTP";
                                message.Body = "Your One Time Password (OTP) for verification is: " +
                        randomCode1 + ". Please enter this OTP to proceed with the resetting password process.";

                                // Send mail
                                smtp.Send(message);
                                panel1.Visible = false;
                                label1.Visible = false;
                                label4.Visible = true;
                                panel2.Visible = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void res_email_Enter(object sender, EventArgs e)
        {
            if (res_email.Text == "Enter Email Address")
            {
                res_email.Text = "";
                res_email.ForeColor = Color.Black;
            }
        }

        private void res_email_Leave(object sender, EventArgs e)
        {
            if (res_email.Text == "")
            {
                res_email.Text = "Enter Email Address";

                res_email.ForeColor = Color.Silver;
            }
        }

        private void customButton41_Click(object sender, EventArgs e)
        {
            if(res_otp.Text != randomCode1 || string.IsNullOrWhiteSpace(res_otp.Text))
            {
                MessageBox.Show("Enter Valid OTP");
                return;
            }
            
            
                panel1.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
                panel2.Visible = false;
                label5.Visible = true;
                panel_change.Visible = true;
            
        }

        private void but_change_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(res_pas.Text) || string.IsNullOrWhiteSpace(rescon_pass.Text))
            {
                MessageBox.Show("Enter New Password");
                return;
            }
            if(res_pas.Text != rescon_pass.Text)
            {
                MessageBox.Show("Password did not match");
                return;
            }
            else
            {
                try
                {
                    MySqlDataAdapter ds = new MySqlDataAdapter("update user set Password='" + res_pas.Text + "' where Email_Address ='" + res_email.Text + "'", con);
                    DataSet dw = new DataSet();
                    ds.Fill(dw);
                    MessageBox.Show("Change Successful, Continue to Login");
                    new Home().Show();
                    this.Hide();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
