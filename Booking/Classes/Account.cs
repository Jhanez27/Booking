using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Classes
{
    public class Account
    {
        public string userName {  get; set; }
        public string password { get; set; }
        public string email {  get; set; }
        public string pNumber { get; set; }
        public string fname {  get; set; }
        public string lname {  get; set; }


        public Account(string accName, string accPass, string accEmail, string accNumber, string accFname, string accLname)
        {
            this.userName = accName;
            this.password = accPass;
            this.email = accEmail;
            this.pNumber = accNumber;
            this.fname = accFname;
            this.lname = accLname;
        }
        public Boolean createAccount()
        {
            Query query = new Query();
            bool res =  query.insertUser(userName, password, email, pNumber, fname, lname);  
            return res;
        }
    }
}
