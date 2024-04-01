using Booking.Classes;
using Booking.UserForms;
using MySql.Data.MySqlClient;
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

namespace Booking
{
    public partial class Home : Form
    {
        private User curentUser;
        public Home()
        {
            InitializeComponent();
            curentUser = new User();
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Type your username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }

        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Type your username";

                username.ForeColor = Color.Silver;
            }

        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Type your password")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
            }

        }

        

        private void pass_TextChange(object sender, EventArgs e)
        {
           
            if (pass.Text != null)
            {
                pass.PasswordChar = '●';
                this.pass.UseSystemPasswordChar = true;
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) || username.Text == "Type your username" ||
            string.IsNullOrWhiteSpace(pass.Text) || pass.Text == "Type your password")
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else { 
                bool exist = curentUser.Login(username.Text , pass.Text);
                if (exist)
                {
                    curentUser.Username = username.Text;
                    curentUser.Password = pass.Text;
                    DashBoard dash = new DashBoard(curentUser);
                    new UserHome(curentUser).Show();
                    this.Hide();
                }

                 
            }
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new sign_up().Show();
            this.Hide();
        }

        private void forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ResetPassword().Show(); 
            this.Hide();
        }
    }
}
