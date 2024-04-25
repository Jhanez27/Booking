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
        private List<BookingDetail> histories;
        private List<BookingDetail> cancelBooking;
        private List <departureTime> departurestime;
        private List<BookingDetail> onloadhistories;
        public bool isChecked { get; private set; }

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

            toLoadTodaysHistories();
        }
        private void toLoadTodaysHistories()
        {
            onloadhistories = query.getTodayBookings(currentUser.Username);
            populateTable(onloadhistories);
            details_panel.Visible = true;
            cancel_btn.Visible = false;
            cancel_btn2.Visible = true;
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
            cancel_btn.Visible = true;
            cancel_btn2.Visible = false ;
        }
        private void populateTable(List<BookingDetail> details)
        {
            

            bookingHistoryDataGridView.Rows.Clear();
            bookingHistoryDataGridView.Columns.Clear();
            bookingHistoryDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            bookingHistoryDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 121, 171);
            bookingHistoryDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            bookingHistoryDataGridView.EnableHeadersVisualStyles = false;

            bookingHistoryDataGridView.Columns.Add("Cancel", "Cancel");
            bookingHistoryDataGridView.Columns.Add("Booking ID", "Booking ID");
            bookingHistoryDataGridView.Columns.Add("Vessel Name", "Vessel Name");
            bookingHistoryDataGridView.Columns.Add("Trip Schedule", "Trip Schedule");
            bookingHistoryDataGridView.Columns.Add("Origin", "Origin");
            bookingHistoryDataGridView.Columns.Add("Destination", "Destination");
            bookingHistoryDataGridView.Columns.Add("Passenger Name", "Passenger Name");
            bookingHistoryDataGridView.Columns.Add("Ticket Number", "Ticket Number");
            bookingHistoryDataGridView.Columns.Add("Status", "Booking Status");
            bookingHistoryDataGridView.Columns.Add("email" , "email");
            bookingHistoryDataGridView.Columns["email"].Visible = false;
            bookingHistoryDataGridView.Columns.Add("accomodation", "accomodation");
            bookingHistoryDataGridView.Columns["accomodation"].Visible = false;
            bookingHistoryDataGridView.Columns.Add("tripId", "trip id");
            bookingHistoryDataGridView.Columns["tripId"].Visible = false;
            bookingHistoryDataGridView.Columns.Add("Number", "Number");
            bookingHistoryDataGridView.Columns["Number"].Visible = false;

            if (details.Count == 0)
            {
                MessageBox.Show("No Bookings");
                return;
            }
            foreach (var bookingHistoryDetail in details)
            {

                int rowIndex = bookingHistoryDataGridView.Rows.Add();

                if (bookingHistoryDetail.bookingStatus == "Paid")
                {
                    DataGridViewCheckBoxCell checkboxCell = new DataGridViewCheckBoxCell();
                    checkboxCell.Value = false;
                    isChecked = false;
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
                bookingHistoryDataGridView.Rows[rowIndex].Cells[10].Value = bookingHistoryDetail.accomodation;
                bookingHistoryDataGridView.Rows[rowIndex].Cells[11].Value = bookingHistoryDetail.trip_id;
                bookingHistoryDataGridView.Rows[rowIndex].Cells[12].Value = bookingHistoryDetail.pNumber;
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

        private void BookingHistoryDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var checkboxCell = bookingHistoryDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;

            if (checkboxCell != null)
            { 
                isChecked = Convert.ToBoolean(checkboxCell.Value);

                
                checkboxCell.Value = !isChecked;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancelBooking = new List<BookingDetail>();
            foreach (DataGridViewRow row in bookingHistoryDataGridView.Rows)
            {
               
                if (row.Cells[0] is DataGridViewCheckBoxCell checkboxCell)
                {
                    if ((bool)checkboxCell.Value == true)
                    {
                        try
                        {
                            BookingDetail bookingDetail = new BookingDetail
                            {
                                bookingId = int.Parse(row.Cells[1].Value?.ToString() ?? "0"), 
                                trip_id = int.Parse(row.Cells[11].Value?.ToString() ?? "0"),  
                                vesselName = row.Cells[2].Value?.ToString() ?? "Unknown",
                                tripSchedule = row.Cells[3].Value?.ToString() ?? "Unknown",
                                origin = row.Cells[4].Value?.ToString() ?? "Unknown",
                                destination = row.Cells[5].Value?.ToString() ?? "Unknown",
                                passengerName = row.Cells[6].Value?.ToString() ?? "Unknown",
                                ticketNumber = row.Cells[7].Value?.ToString() ?? "Unknown",
                                bookingStatus = row.Cells[8].Value?.ToString() ?? "Unknown",
                                email = row.Cells[9].Value?.ToString() ?? "Unknown",
                                accomodation = row.Cells[10].Value?.ToString() ?? "Unknown",
                                pNumber = row.Cells[12].Value?.ToString() ?? "Unknown",
                            };

                            cancelBooking.Add(bookingDetail);
                        }
                        catch (Exception ex)
                        {
                            
                            MessageBox.Show($"Error: {ex.Message}");
                        }

                    }
                }
            }

            if(cancelBooking.Count == 0)
            {
                MessageBox.Show("No bookings selected for cancellation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (BookingDetail cancelList in cancelBooking)
            {
                string bookingid = cancelList.bookingId.ToString();
                int bookid = int.Parse(bookingid);
                bool cancel =  currentUser.cancelBooking(bookid);
                string tripid = cancelList.trip_id.ToString();
                int tripId = int.Parse(tripid);
                if(cancel)
                {
                    query.updateAccomodation(tripId, cancelList.accomodation.ToString());
                    ApplicationSystemEmail notif = new ApplicationSystemEmail();
                    notif.sendEmailToCancel(cancelList.email.ToString(), cancelList.tripSchedule.ToString(),cancelList.destination.ToString());
                     
                }
   
            }
            MessageBox.Show("Notification regarding the cancellation has been sent.");
            searchBooking_btn_Click(sender, e);
        }

        private void cancel_btn2_Click(object sender, EventArgs e)
        {
            cancelBooking = new List<BookingDetail>();
            foreach (DataGridViewRow row in bookingHistoryDataGridView.Rows)
            {

                if (row.Cells[0] is DataGridViewCheckBoxCell checkboxCell)
                {
                    if ((bool)checkboxCell.Value == true)
                    {
                        try
                        {
                            BookingDetail bookingDetail = new BookingDetail
                            {
                                bookingId = int.Parse(row.Cells[1].Value?.ToString() ?? "0"),  // Ensure no null
                                trip_id = int.Parse(row.Cells[11].Value?.ToString() ?? "0"),  // Ensure no null
                                vesselName = row.Cells[2].Value?.ToString() ?? "Unknown",
                                tripSchedule = row.Cells[3].Value?.ToString() ?? "Unknown",
                                origin = row.Cells[4].Value?.ToString() ?? "Unknown",
                                destination = row.Cells[5].Value?.ToString() ?? "Unknown",
                                passengerName = row.Cells[6].Value?.ToString() ?? "Unknown",
                                ticketNumber = row.Cells[7].Value?.ToString() ?? "Unknown",
                                bookingStatus = row.Cells[8].Value?.ToString() ?? "Unknown",
                                email = row.Cells[9].Value?.ToString() ?? "Unknown",
                                accomodation = row.Cells[10].Value?.ToString() ?? "Unknown",
                                pNumber = row.Cells[12].Value?.ToString() ?? "Unknown",
                            };

                            cancelBooking.Add(bookingDetail);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show($"Error: {ex.Message}");
                        }

                    }
                }
            }

            if (cancelBooking.Count == 0)
            {
                MessageBox.Show("No bookings selected for cancellation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (BookingDetail cancelList in cancelBooking)
            {
                string bookingid = cancelList.bookingId.ToString();
                int bookid = int.Parse(bookingid);
                bool cancel = currentUser.cancelBooking(bookid);
                string tripid = cancelList.trip_id.ToString();
                int tripId = int.Parse(tripid);
                if (cancel)
                {
                    query.updateAccomodation(tripId, cancelList.accomodation.ToString());
                    ApplicationSystemEmail notif = new ApplicationSystemEmail();
                    notif.sendEmailToCancel(cancelList.email.ToString(), cancelList.tripSchedule.ToString(), cancelList.destination.ToString());
                   
                }

            }
            MessageBox.Show("Notification regarding the cancellation has been sent.");
            toLoadTodaysHistories();
        }
    }
}
