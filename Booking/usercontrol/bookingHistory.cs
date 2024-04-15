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
    }
}
