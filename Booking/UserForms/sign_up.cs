using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System.Text.RegularExpressions;
using Booking.Classes;

namespace Booking
{
    public partial class sign_up : Form
    {
        String randomCode;
        private bool buttonClicked = false;
        public sign_up()
        {
            InitializeComponent();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string regexPattern = @"^09\d{9}$"; // Regex pattern for Philippine mobile phone numbers
            return Regex.IsMatch(phoneNumber, regexPattern);
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            if (password.Text != null)
            {
                password.PasswordChar = '●';
                this.password.UseSystemPasswordChar = true;
            }
        }

        private void ConPass_TextChanged(object sender, EventArgs e)
        {
            if (con_pass.Text != null)
            {
                con_pass.PasswordChar = '●';
               this.con_pass.UseSystemPasswordChar = true;  
            }
        }
        private void verify_Click(object sender, EventArgs e)
        {
            if(email.Text == "Email Address ")
            {
                MessageBox.Show("Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            buttonClicked = true;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            ApplicationSystem s = new ApplicationSystem();
            s.sendEmailToUser(email.Text , randomCode);
            otp.Text = "";

        }
        private void signUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userN.Text) || userN.Text == "Username" ||
            string.IsNullOrWhiteSpace(password.Text) || password.Text == "Password" ||
            string.IsNullOrWhiteSpace(con_pass.Text) || con_pass.Text == "Retype Password" ||
            string.IsNullOrWhiteSpace(email.Text) || email.Text == "xxxxxxx@gmail.com" ||
            string.IsNullOrWhiteSpace(number.Text) || number.Text == "09XXXXXXXXX" ||
            string.IsNullOrWhiteSpace(fname.Text) || fname.Text == "First Name" ||
            string.IsNullOrWhiteSpace(lname.Text) || lname.Text == "Last Name" || buttonClicked == false )
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string phoneNumber = number.Text.Trim();

            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Phone Number Invalid");
            }
            if (password.Text != con_pass.Text)
            {
                MessageBox.Show("Passwords did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(otp.Text != randomCode)
            {
                MessageBox.Show("Invalid OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Account account = new Account(userN.Text, password.Text, email.Text,number.Text ,fname.Text,lname.Text);
                    bool created = account.createAccount();
            if (created == true)
            {
                new Home().Show();
                this.Close();
            }
        }

        private void UserN_Enter(object sender, EventArgs e)
        {
            if (userN.Text == "Username")
            {
                userN.Text = "";
                userN.ForeColor = Color.Black;
            }
        }

        private void UserN_Leave(object sender, EventArgs e)
        {
            if (userN.Text == "")
            {
                userN.Text = "Username";

                userN.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void Con_Pass_Enter(object sender, EventArgs e)
        {
            if (con_pass.Text == "Retype Password")
            {
                con_pass.Text = "";
                con_pass.ForeColor = Color.Black;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "xxxxxxx@gmail.com")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "xxxxxxx@gmail.com";

                email.ForeColor = Color.Silver;
            }
        }

        private void Number_Enter(object sender, EventArgs e)
        {
            if (number.Text == "09XXXXXXXXX")
            {
                number.Text = "";
                number.ForeColor = Color.Black;
            }
        }

        private void Number_Leave(object sender, EventArgs e)
        {
            if (number.Text == "")
            {
                number.Text = "09XXXXXXXXX";

                number.ForeColor = Color.Silver;
            }
        }

        private void Fname_Enter(object sender, EventArgs e)
        {
            if (fname.Text == "First Name")
            {
                fname.Text = "";
                fname.ForeColor = Color.Black;
            }
        }

        private void Fname_Leave(object sender, EventArgs e)
        {
            if (fname.Text == "")
            {
                fname.Text = "First Name";

                fname.ForeColor = Color.Silver;
            }
        }

        private void Lname_Enter(object sender, EventArgs e)
        {
            if (lname.Text == "Last Name")
            {
                lname.Text = "";
                lname.ForeColor = Color.Black;
            }
        }

        private void Lname_Leave(object sender, EventArgs e)
        {
            if (lname.Text == "")
            {
                lname.Text = "Last Name";

                lname.ForeColor = Color.Silver;
            }
        }

        private void Back_OnClick(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text != null)
            {
                password.PasswordChar = '●';
                this.password.UseSystemPasswordChar = true;
            }
        }

        private void con_Pass_TextChanged(object sender, EventArgs e)
        {
            if (con_pass.Text != null)
            {
                con_pass.PasswordChar = '●';
                this.con_pass.UseSystemPasswordChar = true;
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }
    }
}
