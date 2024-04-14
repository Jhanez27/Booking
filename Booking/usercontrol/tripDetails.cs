using Booking.Classes;
using Booking.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Booking.usercontrol
{
    public partial class tripDetails : UserControl
    {
        private Query query;
        private Dictionary<string, string> logoMap;
        public tripDetails()
        {
            InitializeComponent();
            InitializeLogoMap();
            query = new Query();
            this.MouseEnter += TripDetails_MouseEnter;
            this.MouseLeave += TripDetails_MouseLeave;
        }
        public event EventHandler ButtonClick;

        private void InitializeLogoMap()
        {
            logoMap = new Dictionary<string, string>();
            logoMap.Add("Oceanjet", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\oceanjet.png");
            logoMap.Add("Seacat", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\seacat.png");
            logoMap.Add("Supercat", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\supercat.png");
            logoMap.Add("Roble", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\rsi-logo-short.png");
            logoMap.Add("Lite", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\lite1.png");
            logoMap.Add("Lapu-Lapu", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\list_lapulapu.png");
        }
        public Image logo
        {
            get { return icon.Image; }
            set { icon.Image = value; }
        }
        public string boatName
        {
            get { return boat_name.Text; }
            set { boat_name.Text = value; }
        }
        public string departTime
        {
            get { return depart_time.Text; }
            set { depart_time.Text = value; }
        }
        public string origin
        {
            get { return origin_label.Text; }
            set { origin_label.Text = value; }
        }
        public string destination
        {
            get { return destination_label.Text; }
            set { destination_label.Text = value; }
        }
        public string shipping_Line
        {
            get { return shippingLine.Text; }
            set
            {
                shippingLine.Text = value;
                if (logoMap.ContainsKey(value))
                {
                    icon.Image = Image.FromFile(logoMap[value]);
                }
                else
                {
                    icon.Image = null;
                }
            }
        }
        public string trip_id
        {
            get { return tripId_label.Text; }
            set { tripId_label.Text = value; }
        }
        public string trip_ETA
        {
            get { return tripETA.Text; }
            set { tripETA.Text = value; }
        }
        private void TripDetails_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
          

        }
        private void TripDetails_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void tripDetails_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
