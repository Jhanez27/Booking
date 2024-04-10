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
    public partial class passengerDetails : UserControl
    {
        private Query query;
        private string tripId;
        private User currentUser;
        private Trip trip;
        private Dictionary<string, string> logoMap;
        public passengerDetails(string tripId , User currentUser)
        {
            InitializeComponent();
            InitializeLogoMap();
            this.tripId = tripId;
            this.currentUser = currentUser;
            query = new Query();
            displayTripDetails();
        }
        private void InitializeLogoMap()
        {
            logoMap = new Dictionary<string, string>();
            logoMap.Add("Oceanjet", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\oceanjet.png");
            logoMap.Add("Seacat", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\seacat.png");
            logoMap.Add("Supercat", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\supercat.png");
            logoMap.Add("Roble", "C:\\Users\\juliansuringa\\Source\\Repos\\Booking\\Booking\\Resources\\rsi-logo-short.png");
        }

        public void displayTripDetails()
        {
            
            trip = query.getTripDetials(tripId);
            boat_name.Text = trip.boat_name;
            departure_date.Text = trip.departureDate;
            origin_txt.Text = trip.origin;
            destination_txt.Text = trip.destination;
            if (logoMap.ContainsKey(trip.shippingLine))
            {
                shipLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                shipLogo.Image = Image.FromFile(logoMap[trip.shippingLine]);
            }
        }
    }
}
