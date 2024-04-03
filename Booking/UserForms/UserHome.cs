using Booking.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.UserForms
{
    public partial class UserHome : Form
    {
        private Query query;
        private User currentUser;
        public UserHome(User user)
        {
            InitializeComponent();
            query = new Query();
            currentUser = user;
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

            current_user.Text = currentUser.Username;
            dashboardMain_panel.Visible = true;
            display_mainDashBoard();
        }
        private void display_mainDashBoard  ()
        {
            string oceanjet = "Oceanjet";
            string seacat = "Seacat";
            string supercat = "Supercat";
            daily_sale.Text = query.getDailySales(currentUser.Username).ToString();
            booking_number.Text = query.getNumberOfBookings(currentUser.Username).ToString();
            oceanjet_avail.Text = query.getNumberOfTrips(oceanjet).ToString();
           seacat_avail.Text = query.getNumberOfTrips(seacat).ToString();
            supercat_avail.Text = query.getNumberOfTrips(supercat).ToString();
        }
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            currentUser = null;
            new Home().Show();
            this.Close();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            dashboardMain_panel.Visible = true;
            display_mainDashBoard();

        }
    }
}
