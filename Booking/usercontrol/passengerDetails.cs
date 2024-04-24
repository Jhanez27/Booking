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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Booking.usercontrol
{
    public partial class passengerDetails : UserControl
    {
        private Query query;
        private string tripId;
        private Classes.User currentUser;
        private Trip trip;
        private Dictionary<string, string> logoMap;
        public passengerDetails(string tripId , Classes.User currentUser)
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
            logoMap.Add("Roble", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\rsi-logo-short.png");
            logoMap.Add("Lite Shipping", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\lite1.png");
            logoMap.Add("Lapu-Lapu", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\list_lapulapu.png");
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

        private void passengerDetails_Load(object sender, EventArgs e)
        {
            List<Accommodation> accomodations = query.getAccomodation(tripId);
            foreach (Accommodation accomodation in accomodations)
            {
                accom_comboBox.Items.Add(accomodation.accomName);
            }
            passType_comboBox.Items.Add("Minor");
            passType_comboBox.Items.Add("Student");
            passType_comboBox.Items.Add("Senior Citizen");
            passType_comboBox.Items.Add("Standard");
            //Gender ComboBox Items
            pass_genderComboBox.Items.Add("F");
            pass_genderComboBox.Items.Add("M");

        }

        private void accom_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAccom = accom_comboBox.SelectedItem.ToString();
            int accomPrice = query.getAccomPrice(tripId, selectedAccom);

            accom_price.Text = accomPrice.ToString();
        }

        private void passType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(passType_comboBox.SelectedIndex == 0)
            {
                if (decimal.TryParse(accom_price.Text, out decimal price))
                {
                    decimal discountedPrice = price - (price * 0.5m) + 100; 
                    ticket_amount.Text = discountedPrice.ToString();
                }
            }
            if (passType_comboBox.SelectedIndex == 1)
            {
                if (decimal.TryParse(accom_price.Text, out decimal price))
                {
                    decimal discountedPrice = price - (price * 0.15m) + 100;
                    ticket_amount.Text = discountedPrice.ToString();
                }
            }
            if (passType_comboBox.SelectedIndex == 2)
            {
                if (decimal.TryParse(accom_price.Text, out decimal price))
                {
                    decimal discountedPrice = price - (price * 0.15m) + 100;
                    ticket_amount.Text = discountedPrice.ToString();
                }
            }
            if (passType_comboBox.SelectedIndex == 3)
            {
                if (decimal.TryParse(accom_price.Text, out decimal price))
                {
                    decimal discountedPrice = price  + 100;
                    ticket_amount.Text = discountedPrice.ToString();
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(pass_fname.Text) || string.IsNullOrWhiteSpace(pass_lname.Text)
                || string.IsNullOrWhiteSpace(pass_Age.Text) || string.IsNullOrWhiteSpace(pass_contactNum.Text)
                || string.IsNullOrWhiteSpace(pass_email.Text))
            {
                MessageBox.Show("All fields Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string passNumber = pass_contactNum.Text.Trim();
            if (!IsValidPhoneNumber(passNumber))
            {
                MessageBox.Show("Invalid Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ticketNumber = GenerateUniqueTicketNumber();
            double price = Convert.ToDouble(ticket_amount.Text);
            int age = Convert.ToInt32(pass_Age.Text);
            Passenger p = new Passenger(pass_fname.Text,pass_lname.Text ,age , pass_genderComboBox.SelectedItem.ToString()
                ,pass_contactNum.Text , pass_email.Text,ticketNumber, accom_comboBox.SelectedItem.ToString());
            int passengerId = currentUser.addPassenger(p);
            string dateToday = DateTime.Now.ToString("yyyy-MM-dd");
            PassengerBooking pb = new PassengerBooking(currentUser.Username, passengerId, Convert.ToInt16(tripId),Convert.ToDouble(ticket_amount.Text),dateToday , "Paid");
            bool booked = currentUser.bookPassenger(pb);
            if (booked)
            {
                query = new Query();
                query.updateAccomodationSeat(tripId, accom_comboBox.SelectedItem.ToString());
                MessageBox.Show("Book Successfull.\n An email containing the ticket will be sent to the Passenger");
                UserHome parentForm = this.ParentForm as UserHome;
                if (parentForm != null)
                {
                    bookingControl bc = new bookingControl(currentUser);
                    parentForm.DashboardPanel.Controls.Clear();
                    parentForm.DashboardPanel.Controls.Add(bc);
                }
            }
        }
        public string GenerateUniqueTicketNumber()
        {
            string datePart = DateTime.Now.ToString("mmss");
            string randomPart = GenerateRandomNumber(0, 999999).ToString("D6"); 
            string ticketNumber = datePart + randomPart;

            return ticketNumber;
        }
        public int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string regexPattern = @"^09\d{9}$"; // Regex pattern for Philippine mobile phone numbers
            return Regex.IsMatch(phoneNumber, regexPattern);
        }
    }
}
