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
using Booking.Classes;

namespace Booking
{
    public partial class ResetPassword : Form
    {
        String randomCode1;
        public static String to;
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
                    Random rand = new Random();
                    randomCode1 = (rand.Next(999999)).ToString();
                   
                     User user = new User();
                     bool success = user.changePassword(res_email.Text,randomCode1);
                if (success)
                {
                    panel1.Visible = false;
                    label1.Visible = false;
                    label4.Visible = true;
                    panel2.Visible = true;
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
               Query query = new Query();
                query.updateEmail(res_email.Text, res_pas.Text);
                new Home().Show();
                this.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
