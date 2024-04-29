using Booking.Classes;
using Booking.usercontrol;
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
            currentUser = user;
        }
        public Panel DashboardPanel
        {
            get { return dashboardMain_panel; }
        }
        private void UserHome_Load(object sender, EventArgs e)
        {
            query = new Query();
            current_user.Text = currentUser.Username;
            dashBoardControl dbs = new dashBoardControl(currentUser);
            dashboardMain_panel.Controls.Add(dbs);
        }
        
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void home_btn_Click(object sender, EventArgs e)
        {
            dashboardMain_panel.Controls.Clear();
            dashBoardControl dbs = new dashBoardControl(currentUser);
            dashboardMain_panel.Controls.Add(dbs);

        }
        private void book_btn_Click(object sender, EventArgs e)
        {
            dashboardMain_panel.Controls.Clear();
            bookingControl bookingControl = new bookingControl(currentUser);
            dashboardMain_panel.Controls.Add(bookingControl);


        }
        private void logout_btn_Click(object sender, EventArgs e)
        {
            currentUser = null;
            new Home().Show();
            this.Close();
        }
        private void bookhistory_btn_Click(object sender, EventArgs e)
        {
            dashboardMain_panel.Controls.Clear();
            bookingHistory bh = new bookingHistory(currentUser);
            dashboardMain_panel.Controls.Add(bh);
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            dashboardMain_panel.Controls.Clear();
            reportControl rc = new reportControl(currentUser);
            dashboardMain_panel.Controls.Add(rc);

        }
    }
}
