using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.Classes
{
    public class User
    {
        private List<BookingDetail> bookingHistoryDetails;
        private Query query;
        public string Username {  get; set; }
        public string Password { get; set; }

        public User() { 
        }
        public User(string username , string pass) {
                this.Username = username;
                this.Password = pass;
        }
        public Boolean Login(string username, string password)
        {
            query = new Query();
            bool searchUser = query.searchAccount(username, password);
            return searchUser;
        }
        public Boolean changePassword(string email, string code)
        {
            bool done = false;
            query = new Query();
            bool searchemail = query.searchEmail(email);
            if(searchemail)
            {
                ApplicationSystemEmail s = new ApplicationSystemEmail();
                s.sendEmailToUser(email ,code);
                done = true;
            }
            return done;

        }
        public int addPassenger(Passenger passenger)
        {
            int passenger_id = -1;
            query = new Query();
            passenger_id = query.insertPassenger(passenger);
            return passenger_id;
        }
        public Boolean bookPassenger(PassengerBooking pb)
        {
             query = new Query();
            bool done = query.insertBooking(pb);
            return done;
        }
        public List<BookingDetail> searchBookings (string adMinName , string date , string boatName , string selectedTime)
        {
            query = new Query();
            bookingHistoryDetails = query.getBookings(adMinName,date, boatName, selectedTime);
            return bookingHistoryDetails;
        }
        public Boolean cancelBooking(int booking_id)
        {
            query = new Query();
            bool cancelled = query.updateBooking(booking_id);
                return cancelled;
        }
    }
}
