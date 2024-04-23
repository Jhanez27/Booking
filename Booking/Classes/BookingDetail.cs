using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Classes
{
    public class BookingDetail
    {
        public int bookingId {  get; set; }
        public int trip_id {  get; set; }
        public string vesselName {  get; set; }
        public string tripSchedule { get; set;}
        public string origin { get; set; }
        public string destination { get; set; }
        public string passengerName { get; set; }
        public string ticketNumber {  get; set; }
        public string bookingStatus {  get; set; }
        public string email {  get; set; }
        public string accomodation { get; set; }

        public BookingDetail()
        {

        }
        public BookingDetail(int bookingId,int tripId , string vesselName , string tripSched,string origin, string destination , string passName,string ticketnumber, string status, string email, string accomodation) {
            this.bookingId = bookingId;
            this.trip_id  = tripId;
            this.vesselName = vesselName;
            this.tripSchedule = tripSched;
            this.origin = origin;
            this.destination = destination;
            this.passengerName = passName;
            this.ticketNumber = ticketnumber;
            this.bookingStatus = status;
            this.email = email;
            this.accomodation  = accomodation;
        }
    }
}
