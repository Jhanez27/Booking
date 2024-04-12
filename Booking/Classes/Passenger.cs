using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Classes
{
    public class Passenger
    {
        public string passenger_fname {  get; set; }
        public string passenger_lname {  get; set; }
        public int passenger_age { get; set; }
        public string passenger_gender {  get; set; }
        public string passenger_number {  get; set; }
        public string passenger_email { get; set; }
        public string ticketNumber {  get; set; }
        public string accomodation { get; set; }

        public Passenger(string passenger_fname, string passenger_lname, int passenger_age, string passenger_gender, string passenger_number, string passenger_email, string ticketNumber, string accomodation)
        {
            this.passenger_fname = passenger_fname;
            this.passenger_lname = passenger_lname;
            this.passenger_age = passenger_age;
            this.passenger_gender = passenger_gender;
            this.passenger_number = passenger_number;
            this.passenger_email = passenger_email;
            this.ticketNumber = ticketNumber;
            this.accomodation = accomodation;
        }
    }
}
