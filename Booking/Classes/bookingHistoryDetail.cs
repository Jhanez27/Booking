using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Classes
{
    public class bookingHistoryDetail
    {
        public int bookingId {  get; set; }
        public string vesselName {  get; set; }
        public string tripSchedule { get; set;}
        public string origin { get; set; }
        public string destination { get; set; }
        public string passengerName { get; set; }
        public string ticketNumber {  get; set; }
        public string bookingStatus {  get; set; }
        public string email {  get; set; }

        public bookingHistoryDetail()
        {

        }
        public bookingHistoryDetail(int bookingId , string vesselName , string tripSched,string origin, string destination , string passName,string ticketnumber, string status, string email) {
            this.bookingId = bookingId;
            this.vesselName = vesselName;
            this.tripSchedule = tripSched;
            this.origin = origin;
            this.destination = destination;
            this.passengerName = passName;
            this.ticketNumber = ticketnumber;
            this.bookingStatus = status;
            this.email = email;
        }
    }
}
