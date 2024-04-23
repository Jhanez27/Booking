using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.Classes
{
    public class ApplicationSystem
    {
       
        public void sendEmailToUser(string accEmail , string code)
        {
           
            try
            {
                // OAuth 2.0 authentication
                var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = "710913857464-3rvaos761uctb0hbaue1cd2d1qof48vj.apps.googleusercontent.com",
                        ClientSecret = "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"
                    },
                    new[] { "https://mail.google.com/" },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("credential_file_path")).Result;

                // Create SMTP client
                using (var smtp = new SmtpClient())
                {
                    // Configure SMTP client
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("ticketeasebookingnotification@gmail.com", "fxjm rmbl gozc kqrk");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    // Create mail message
                    using (var message = new MailMessage())
                    {
                        message.From = new MailAddress("ticketeasebookingnotification@gmail.com");
                        message.To.Add(accEmail);
                        message.Subject = "OTP";
                        message.Body = "Your One Time Password (OTP) for verification is: " +
                                       code + ". Please enter this OTP to proceed with the process.";

                        // Send mail
                        smtp.Send(message);
                        MessageBox.Show("An OTP is sent to you email address");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Email");
            }

        }
        public void sendEmailToCancel(string accEmail, string schedule , string destination)
        {

            try
            {
                // OAuth 2.0 authentication
                var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = "710913857464-3rvaos761uctb0hbaue1cd2d1qof48vj.apps.googleusercontent.com",
                        ClientSecret = "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"
                    },
                    new[] { "https://mail.google.com/" },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("credential_file_path")).Result;

                // Create SMTP client
                using (var smtp = new SmtpClient())
                {
                    // Configure SMTP client
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("ticketeasebookingnotification@gmail.com", "fxjm rmbl gozc kqrk");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    // Create mail message
                    using (var message = new MailMessage())
                    {
                        message.From = new MailAddress("ticketeasebookingnotification@gmail.com");
                        message.To.Add(accEmail);
                        message.Subject = "OTP";
                        message.Body = "This is to inform your that your trip for " +
                                       schedule + " , bound to" +destination+ "has been cancelled. \n Please go to nearest shipping line ticketing office for refund or rescheduling of your trip. \n Thank you!";

                        // Send mail
                        smtp.Send(message);
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Invalid Email");
            }

        }
    }
}
