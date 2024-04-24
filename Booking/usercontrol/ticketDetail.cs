using Booking.Classes;
using Booking.UserForms;
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
    public partial class ticketDetail : UserControl
    {
        private Ticket ticket;
        private Dictionary<string, string> logoMap;
        public ticketDetail(Ticket ticketdetail)
        {
            InitializeComponent();
            InitializeLogoMap();
            ticket = ticketdetail;
            viewTicketDisplay();
        }
        private void viewTicketDisplay()
        {
            bookDate_lbl.Text = ticket.bookingDate.ToString();
            ticketNum_lbl.Text = ticket.ticketNumber.ToString();
            accom_lbl.Text = ticket.accomodationName.ToString();
            discountT_lbl.Text = ticket.discountType.ToString();
            passName_lbl.Text = ticket.passName.ToString();
            age_lbl.Text = ticket.passAge.ToString();
            sex_lbl.Text = ticket.passSex.ToString();
            fare_lbl.Text = ticket.fare.ToString();
            origin_lbl.Text = ticket.originName.ToString();
            destination_lbl.Text = ticket.destinationName.ToString();
            schedule_lbl.Text = ticket.tripSched.ToString();
            vessel_lbl.Text = ticket.vesselName.ToString();
            if (logoMap.ContainsKey(ticket.shippingLine.ToString()))
            {
                logo_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                logo_pictureBox.Image = Image.FromFile(logoMap[ticket.shippingLine.ToString()]);
            }
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
    }
}
