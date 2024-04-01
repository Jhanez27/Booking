using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Classes
{
    public class User
    {
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
            Query query = new Query();
            bool searchUser = query.searchAccount(username, password);
            return searchUser;
        }
        public Boolean changePassword(string email, string code)
        {
            bool done = false;
            Query query = new Query();
            bool searchemail = query.searchEmail(email);
            if(searchemail)
            {
                ApplicationSystem s = new ApplicationSystem();
                s.sendEmailToUser(email ,code);
                done = true;
            }
            return done;

        }

    }
}
