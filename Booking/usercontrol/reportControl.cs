using Booking.Classes;
using DGVPrinterHelper;
using Microsoft.VisualBasic.Devices;
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
       
        public reportControl(User user)
        {
            InitializeComponent();
            currentUser = user;
            query = new Query();
        }

        private void reportControl_Load(object sender, EventArgs e)
        {
            report_contentHolder.Visible = false;
            report_topPanel.Visible = true;
        }
        private void generateReport_btn_Click(object sender, EventArgs e)
        {
           fillwithData();
           
        }
        public void fillwithData()
        {
            report_content.Columns.Clear();
            string userName = Environment.GetEnvironmentVariable("MYSQL_USERNAME");
            string password = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");
            string server = Environment.GetEnvironmentVariable("MYSQL_SERVER");
            string connectionString = $"SERVER={server};DATABASE=bookingsystem;UID={userName};PASSWORD={password}";
            MySqlConnection con = new MySqlConnection(connectionString);
            DateTime reportDate = report_datePicker.Value.Date;
            string datesearch = reportDate.ToString("yyyy-MM-dd");
            con.Open();
            string selectquery = "SELECT boat.boat_name as VesselName, trip.date_departure as TripSchedule, " +
                   "CONCAT(passenger.passenger_fname, ' ', passenger.passenger_lname) as PassengerName, " +
                   "booking.booking_amount as TicketAmount, booking.booking_status as Status FROM booking " +
                   "INNER JOIN trip ON booking.trip_id = trip.trip_id " +
                   "INNER JOIN boat ON trip.boat_id = boat.boat_id " +
                   "INNER JOIN passenger ON booking.passenger_id = passenger.passenger_id " +
                   "WHERE username = '" + currentUser.Username + "' AND booking.booking_date = '" + datesearch + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(selectquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dt.Columns["VesselName"].ColumnName = "Vessel Name";
            dt.Columns["TripSchedule"].ColumnName = "Trip Schedule";
            dt.Columns["PassengerName"].ColumnName = "Passenger Name";
            dt.Columns["TicketAmount"].ColumnName = "Payment";
            dt.Columns["Status"].ColumnName = "Status";
            report_contentHolder.Visible=true;
            topReport_txt.Text = "Sales Report for " + reportDate.ToString("MMMM dd yyyy");
            adminLabel.Text = "Admin : " + currentUser.Username;
           
            reportSales_txt.Text = "Total Sales : " + query.getReportSales(currentUser.Username, reportDate.ToString("yyyy-MM-dd"));
            if (dt.Rows.Count == 0)
            {
                DataRow newRow = dt.NewRow();
                newRow["Passenger Name"] = "No Bookings";
                dt.Rows.Add(newRow);
            }

            report_content.DataSource = dt;

            con.Close();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Sales Report for " + report_datePicker.Value.Date.ToString("MMMM dd yyyy");
            printer.SubTitle = "Admin : " + currentUser.Username;
            printer.SubTitleSpacing = 20;
            printer.SubTitleFormatFlags  =StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Far;
            printer.Footer = "Total Sales : " + query.getReportSales(currentUser.Username, report_datePicker.Value.Date.ToString("yyyy-MM-dd"));
            printer.FooterSpacing = 15;
            printer.FooterAlignment = StringAlignment.Far;
            printer.PrintDataGridView(report_content);

        }
    }
}

