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
    public partial class dashBoardControl : UserControl
    {
        private User currentUser;
        private Query query;
        public dashBoardControl(User user)
        {
            query = new Query();
            InitializeComponent();
            currentUser = user;
            display_mainDashBoard();
            timer1.Start();
        }
        private void display_mainDashBoard()
        {
            admin.Text = currentUser.Username + "'s Dashboard";
            string oceanjet = "Oceanjet";
            string seacat = "Seacat";
            string supercat = "Supercat";
            string roble = "Roble";
            string lite = "Lite Shipping";
            string lapu = "Lapu-Lapu";
            daily_sale.Text = query.getDailySales(currentUser.Username).ToString();
           booking_number.Text = query.getNumberOfBookings(currentUser.Username).ToString();
            oceanjet_avail.Text = query.getNumberOfTrips(oceanjet).ToString();
            seacat_avail.Text = query.getNumberOfTrips(seacat).ToString();
            supercat_avail.Text = query.getNumberOfTrips(supercat).ToString();
            roble_avail.Text = query.getNumberOfTrips(roble).ToString();
            lite_available.Text = query.getNumberOfTrips(lite).ToString();
            lapu_available.Text = query.getNumberOfTrips(lapu).ToString();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }
    }
}
