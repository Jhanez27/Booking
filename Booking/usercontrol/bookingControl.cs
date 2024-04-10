using Booking.Classes;
using Booking.UserForms;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class bookingControl : UserControl
    {
        private Query query;
        private Classes.User currentUser;

        public bookingControl(Classes.User user)
        {
            InitializeComponent();
            query = new Query();
            currentUser = user;

        }

        private void bookingControl_Load(object sender, EventArgs e)
        {
            List<Destination> destinationList = query.addDestination();
            destination_combo.Items.Clear();


            foreach (Destination destination in destinationList)
            {
                destination_combo.Items.Add(destination.destinationName);
            }

            List<Origin> originList = query.addOrigin();
            origin_combo.Items.Clear();


            foreach (Origin origin in originList)
            {
                origin_combo.Items.Add(origin.originName);
            }

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string originName = origin_combo.SelectedItem.ToString();
            string destinationName = destination_combo.SelectedItem.ToString();
            DateTime departDate = departure_datePicker.Value.Date;
            tripPanel.Controls.Clear();
            List<Trip> tripList = new List <Trip>();
            tripList.Clear();
            tripList = query.getTrips(originName, destinationName, departDate);
            if(tripList.Count == 0)
            {
                MessageBox.Show("No trips available for the selected Origin and Destination.");
                return;
            }
         
            int y = 0;
            foreach (Trip trip in tripList)
            {
                tripDetails tripButton = new tripDetails();
                tripButton.trip_id = trip.trip_id;
                tripButton.boatName = trip.boat_name;
                tripButton.origin = trip.origin;
                tripButton.destination = trip.destination;
                tripButton.departTime = trip.departureDate.ToString();
                tripButton.shipping_Line = trip.shippingLine;
                tripButton.ButtonClick += TripButton_ButtonClick;
                tripButton.Location = new Point(0, y);
                y += tripButton.Height;
                tripPanel.Controls.Add(tripButton);
            }
        }
        private void TripButton_ButtonClick(object sender, EventArgs e)
        {
            tripDetails clickedTrip = sender as tripDetails;
            if (clickedTrip != null)
            {
                UserHome parentForm = this.ParentForm as UserHome;
                if (parentForm != null)
                {
                    string tripId = clickedTrip.trip_id;
                    passengerDetails psg = new passengerDetails(tripId, currentUser);
                    parentForm.DashboardPanel.Controls.Clear();
                    parentForm.DashboardPanel.Controls.Add(psg);
                    int x = (parentForm.DashboardPanel.Width - psg.Width) / 2;
                    int y = (parentForm.DashboardPanel.Height - psg.Height) / 2;
                    psg.Location = new Point(x, y);
                }
            }
        
        }
    }
}
