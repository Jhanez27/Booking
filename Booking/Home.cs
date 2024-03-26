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
        MySqlConnection con = new MySqlConnection("SERVER = LOCALHOST;DATABASE = bookingsystem; UID = Jhanez28; PASSWORD = @Sur1nga123");
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
            if (string.IsNullOrWhiteSpace(username.Text) || username.Text == "Type your username" ||
            string.IsNullOrWhiteSpace(pass.Text) || pass.Text == "Type your password")
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                MySqlDataAdapter sd = new MySqlDataAdapter("select Username,Password from user where Username= '" + username.Text + "' and Password= '"+pass.Text+"'", con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Invalid Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    new DashBoard().Show();
                    this.Hide();
                }
            }

            con.Close();
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
