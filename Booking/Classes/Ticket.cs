using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Classes
{
    public class Ticket
    {
        public string ticketNumber {  get; set; }
        public string shippingLine {  get; set; }
        public string bookingDate { get; set; }
        public string accomodationName { get; set; }
        public string discountType {  get; set; }
        public string originName {  get; set; }
        public string destinationName { get; set; }
        public string vesselName { get; set; }
        public string tripSched {  get; set; }
        public string passName { get; set; }
        public string passAge {  get; set; }
        public string passSex { get; set; }
        public double fare { get; set;   }

        public Ticket(string ticketNumber,string shipLine, string bookingDate, string accomodationName, string discountType, string originName, string destinationName, string vesselName, string tripSched, string passName, string passAge, string passSex, double fare)
        {
            this.ticketNumber = ticketNumber;
            this.shippingLine = shipLine;
            this.bookingDate = bookingDate;
            this.accomodationName = accomodationName;
            this.discountType = discountType;
            this.originName = originName;
            this.destinationName = destinationName;
            this.vesselName = vesselName;
            this.tripSched = tripSched;
            this.passName = passName;
            this.passAge = passAge;
            this.passSex = passSex;
            this.fare = fare;
        }
    }
}
