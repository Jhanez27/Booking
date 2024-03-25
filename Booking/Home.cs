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
        public Home()
        {
            InitializeComponent();
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
            if (username.Text == "Type your username")
            {
                errorProvider1.SetError(username, "Username is required");
            }
            else
            {
                errorProvider1.SetError(username, string.Empty);
            }
            if (pass.Text == "Type your password")
            {
                errorProvider2.SetError(pass, "Password is required");
            }
            else
            {
                errorProvider2.SetError(pass, string.Empty);
            }
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new sign_up().Show();
            this.Hide();
        }
    }
}
