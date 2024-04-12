using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Classes
{
    public class PassengerBooking
    {
        public string bookedAdmin { get; set; }
        public int passenger_id { get; set; }
        public int trip_id { get; set; }
        public double booking_amount { get; set; }
        public string booked_Date { get; set; }
        public string booked_status { get; set; }
        public PassengerBooking(string bookedAdmin, int passenger_id, int trip_id, double booking_amount, string booked_Date, string booked_status)
        {
            this.bookedAdmin = bookedAdmin;
            this.passenger_id = passenger_id;
            this.trip_id = trip_id;
            this.booking_amount = booking_amount;
            this.booked_Date = booked_Date;
            this.booked_status = booked_status;
        }
    }
}
