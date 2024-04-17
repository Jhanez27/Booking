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

namespace Booking.usercontrol
{
    public partial class bookingHistory : UserControl
    {
        private User currentUser;
        private Query query;
        private List<bookingHistoryDetail> histories;
        private List <departureTime> departurestime;
        public bookingHistory(User user)
        {
            InitializeComponent();
            currentUser = user;
            query = new Query();

        }

        private void bookingHistory_Load(object sender, EventArgs e)
        {
            List<BoatName> boats = new List<BoatName>();
            boats = query.getBoatName();
            foreach(BoatName boat in boats)
            {
                 boatName_comboBox.Items.Add(boat.boatName);
            }
        }

        private void searchBooking_btn_Click(object sender, EventArgs e)
        {
            string vesselName = boatName_comboBox.SelectedItem.ToString();
            string datedepart = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd ");
            string selectedTime = departureTime_comboBox.SelectedItem.ToString();
            DateTime selecttime = DateTime.Parse(selectedTime);
            string queryTime = selecttime.ToString("HH:mm:ss");
            details_panel.Visible = true;
            histories = currentUser.searchBookings(currentUser.Username, datedepart, vesselName, queryTime);
            populateTable(histories);

        }
        private void populateTable(List<bookingHistoryDetail> details)
        {
            if (details.Count == 0)
            {
                MessageBox.Show("No bookings on that Trip");
                details_panel.Visible = false;
                return;
            }

            bookingHistoryDataGridView.Rows.Clear();
            bookingHistoryDataGridView.Columns.Clear();
     
            bookingHistoryDataGridView.Columns.Add("Cancel", "Cancel");
            bookingHistoryDataGridView.Columns.Add("Booking ID", "Booking ID");
            bookingHistoryDataGridView.Columns.Add("Vessel Name", "Vessel Name");
            bookingHistoryDataGridView.Columns.Add("Trip Schedule", "Trip Schedule");
            bookingHistoryDataGridView.Columns.Add("Origin", "Origin");
            bookingHistoryDataGridView.Columns.Add("Destination", "Destination");
            bookingHistoryDataGridView.Columns.Add("Passenger Name", "Passenger Name");
            bookingHistoryDataGridView.Columns.Add("Ticket Number", "Ticket Number");
            bookingHistoryDataGridView.Columns.Add("Booking Status", "Booking Status");
            bookingHistoryDataGridView.Columns.Add("email" , "email");
            bookingHistoryDataGridView.Columns["email"].Visible = false;
            foreach (var bookingHistoryDetail in details)
            {
                int rowIndex = bookingHistoryDataGridView.Rows.Add();

            
                if (bookingHistoryDetail.bookingStatus == "Paid")
                {
                    DataGridViewCheckBoxCell checkboxCell = new DataGridViewCheckBoxCell();
                    checkboxCell.Value = false;
                    bookingHistoryDataGridView.Rows[rowIndex].Cells[0] = checkboxCell;
                }
                else
                {
                    bookingHistoryDataGridView.Rows[rowIndex].Cells[0].Value = " ";
                    
                }

                bookingHistoryDataGridView.Rows[rowIndex].Cells[1].Value = bookingHistoryDetail.bookingId.ToString();
                bookingHistoryDataGridView.Rows[rowIndex].Cells[2].Value = bookingHistoryDetail.vesselName;
                bookingHistoryDataGridView.Rows[rowIndex].Cells[3].Value = bookingHistoryDetail.tripSchedule;
                bookingHistoryDataGridView.Rows[rowIndex].Cells[4].Value = bookingHistoryDetail.origin;
                bookingHistoryDataGridView.Rows[rowIndex].Cells[5].Value = bookingHistoryDetail.destination;
                bookingHistoryDataGridView.Rows[rowIndex].Cells[6].Value = bookingHistoryDetail.passengerName;
                bookingHistoryDataGridView.Rows[rowIndex].Cells[7].Value = bookingHistoryDetail.ticketNumber;
                bookingHistoryDataGridView.Rows[rowIndex].Cells[8].Value = bookingHistoryDetail.bookingStatus;
                bookingHistoryDataGridView.Rows[rowIndex].Cells[9].Value = bookingHistoryDetail.email;
            }
        }

        private void boatName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            departureTime_comboBox.Items.Clear();
            string vessel = boatName_comboBox.SelectedItem.ToString();
            Console.WriteLine(vessel);
            departurestime = query.getDepartureTimes(vessel);
            foreach(departureTime dtime in departurestime)
            {
                departureTime_comboBox.Items.Add(dtime.departime);
            }
        }
    }
}
