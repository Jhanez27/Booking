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
        private string tripId;
        private User currentUser;
        public passengerDetails(string tripId , User currentUser)
        {
            InitializeComponent();
            this.tripId = tripId;
            this.currentUser = currentUser;
        }
    }
}
