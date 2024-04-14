using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Classes
{
    public class Trip
    {
        public string trip_id { get; set; }
        public string shippingLine { get; set; }
        public string boat_name { get; set; }
        public string destination {  get; set; }
        public string origin { get; set;}
        public string departureDate { get; set; }

        public string trip_ETA { get; set; }
        public Trip()
        {

        }
        public Trip (string trip_id, string shippingLine, string boat_name, string destination, string origin, string departureDate, string trip_ETA)
        {
            this.trip_id = trip_id;
            this.shippingLine = shippingLine;
            this.boat_name = boat_name;
            this.destination = destination;
            this.origin = origin;
            this.departureDate = departureDate;
            this.trip_ETA = trip_ETA;

        }
    }
}
