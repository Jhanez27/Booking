using Booking.Classes;
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

namespace Booking.usercontrol
{
    public partial class reportControl : UserControl
    {
        private User currentUser;
        private Query query;
        MySqlConnection con = new MySqlConnection("SERVER = LOCALHOST;DATABASE = bookingsystem; UID = Jhanez28; PASSWORD = @Sur1nga123");
        public reportControl(User user)
        {
            InitializeComponent();
            currentUser = user;
            query = new Query();
        }
        private void generateReport_btn_Click(object sender, EventArgs e)
        {
           fillwithData();
           
        }
        public void fillwithData()
        {
            report_content.Columns.Clear();

            DateTime reportDate = report_datePicker.Value.Date;
            string datesearch = reportDate.ToString("yyyy-MM-dd");
            con.Open();
            string query = "SELECT boat.boat_name as VesselName, trip.date_departure as TripSchedule, " +
                   "CONCAT(passenger.passenger_fname, ' ', passenger.passenger_lname) as PassengerName, " +
                   "booking.booking_amount as TicketAmount, booking.booking_status as Status FROM booking " +
                   "INNER JOIN trip ON booking.trip_id = trip.trip_id " +
                   "INNER JOIN boat ON trip.boat_id = boat.boat_id " +
                   "INNER JOIN passenger ON booking.passenger_id = passenger.passenger_id " +
                   "WHERE username = '" + currentUser.Username + "' AND booking.booking_date = '" + datesearch + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Rename DataTable columns to match DataGridView column names
            dt.Columns["VesselName"].ColumnName = "Vessel Name";
            dt.Columns["TripSchedule"].ColumnName = "Trip Schedule";
            dt.Columns["PassengerName"].ColumnName = "Passenger Name";
            dt.Columns["TicketAmount"].ColumnName = "Payment";
            dt.Columns["Status"].ColumnName = "Status";

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Bookings on that day");
                return;
            }

            report_content.DataSource = dt;

            con.Close();
        }
    }
}

