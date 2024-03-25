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
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

  

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text != null)
            {
                pass.PasswordChar = '●';
                this.pass.UseSystemPasswordChar = true;
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

        private void signUp_Click(object sender, EventArgs e)
        {
            if (userN.Text == "Username")
            {
                errorProvider1.SetError(userN, "User Name is Required");
            }
            else
            {
                errorProvider1.SetError(userN, string.Empty);
            }
            if (pass.Text == "Password")
            {
                errorProvider2.SetError(pass, "Password is required");
            }
            else
            {
                errorProvider2.SetError(pass, string.Empty);
            }
            if (con_pass.Text == "Confirm Password")
            {
                errorProvider3.SetError(con_pass, "Re-type password");
            }
            else
            {
                errorProvider3.SetError(con_pass, string.Empty);
            }
            if (email.Text == "Email Address ")
            {
                errorProvider4.SetError(email, "Email is required");
            }
            else
            {
                errorProvider4.SetError(email, string.Empty);
            }
            if (number.Text == "Contact Number")
            {
                errorProvider5.SetError(number, "Phone Number is required");
            }
            else
            {
                errorProvider5.SetError(number, string.Empty);
            }
            if (fname.Text == "First Name" || lname.Text == "Last Name")
            {
                errorProvider6.SetError(lname, "Fields required");
            }
            else
            {
                errorProvider6.SetError(lname, string.Empty);
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

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Password")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
            }
        }

        private void Con_Pass_Enter(object sender, EventArgs e)
        {
            if (con_pass.Text == "Confirm Password")
            {
                con_pass.Text = "";
                con_pass.ForeColor = Color.Black;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Email Address")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email Address";

                email.ForeColor = Color.Silver;
            }
        }

        private void Number_Enter(object sender, EventArgs e)
        {
            if (number.Text == "Contact Number")
            {
                number.Text = "";
                number.ForeColor = Color.Black;
            }
        }

        private void Number_Leave(object sender, EventArgs e)
        {
            if (number.Text == "")
            {
                number.Text = "Contact Number";

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
            this.Hide();
        }
    }
}
