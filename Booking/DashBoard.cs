using Booking.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Threading;

namespace Booking
{
    public partial class DashBoard : Form
    {
        private TableLayoutPanel tripTableLayoutPanel;
        private User currentUser;
        private Dictionary<string, string> logoMap;
        MySqlConnection con = new MySqlConnection("SERVER = LOCALHOST;DATABASE = bookingsystem; UID = Jhanez28; PASSWORD = @Sur1nga123");
  
        public DashBoard(User user)
        {
            InitializeComponent();
            InitializeLogoMap();
            currentUser = user;
            tripTableLayoutPanel = new TableLayoutPanel();
            tripTableLayoutPanel.ForeColor = Color.Black;
            tripTableLayoutPanel.Font = new Font("Myanmar Text", 14, FontStyle.Regular);
            tripTableLayoutPanel.Location = new Point(250, 120);
            tripTableLayoutPanel.Size = new Size(800, 500);
            tripTableLayoutPanel.AutoScroll = true;
            tripTableLayoutPanel.Anchor = AnchorStyles.None;
            tripTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); 
            this.Controls.Add(tripTableLayoutPanel);

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            curentuser.Text = currentUser != null ? currentUser.Username : "";
            panel7.Visible = true;
            dash_text.Visible = true;
            contact_us.Visible = false;
            contact_panel.Visible = false;
            PopulateDetials();
        }
        private void InitializeLogoMap()
        {
             logoMap = new Dictionary<string, string>();
            logoMap.Add("Oceanjet", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\oceanjet.png");
            logoMap.Add("Seacat", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\seacat.png");
            logoMap.Add("Supercat", "C:\\Users\\juliansuringa\\source\\repos\\Booking\\Booking\\Resources\\supercat.png");
        }
        private void PopulateDetials()
        {
            con.Open();
            DateTime today = DateTime.Today;
            string query = "SELECT trip.*,boat.boat_name,boat.boat_availableSeat, boat.shipping_line FROM trip INNER JOIN boat on trip.boat_id = boat.boat_id WHERE trip.date_departure = @Today and boat.boat_availableSeat > 0";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Today",today);
            MySqlDataReader reader  = command.ExecuteReader();

            tripTableLayoutPanel.Controls.Clear();

            Label shippingLineLabel = new Label();
            shippingLineLabel.Text = "Shipping Line";
            shippingLineLabel.Font = new Font(shippingLineLabel.Font, FontStyle.Bold);
            tripTableLayoutPanel.Controls.Add(shippingLineLabel, 0, 0);

            Label boatNameLabel = new Label();
            boatNameLabel.Text = "Boat Name";
            boatNameLabel.Font = new Font(boatNameLabel.Font, FontStyle.Bold);
            tripTableLayoutPanel.Controls.Add(boatNameLabel, 1, 0);

            Label departTimeLabel = new Label();
            departTimeLabel.Text = "Departure Time";
            departTimeLabel.Font = new Font(departTimeLabel.Font, FontStyle.Bold);
            tripTableLayoutPanel.Controls.Add(departTimeLabel, 2, 0);

           Label arrivalTimeLabel = new Label();
            arrivalTimeLabel.Text = "Arrival Time";
            arrivalTimeLabel.Font = new Font(arrivalTimeLabel.Font, FontStyle.Bold);
            tripTableLayoutPanel.Controls.Add(arrivalTimeLabel, 3, 0);

            Label originplaceLabel = new Label();
            originplaceLabel.Text = "Origin";
            originplaceLabel.Font = new Font(originplaceLabel.Font, FontStyle.Bold);
            tripTableLayoutPanel.Controls.Add(originplaceLabel, 4, 0);

            Label desplaceLabel = new Label();
            desplaceLabel.Text = "Destination";
            desplaceLabel.Font = new Font(desplaceLabel.Font, FontStyle.Bold);
            tripTableLayoutPanel.Controls.Add(desplaceLabel, 5, 0);

            Label capacityLabel = new Label();
            capacityLabel.Text = "Capacity";
            capacityLabel.Font = new Font(capacityLabel.Font, FontStyle.Bold);
            tripTableLayoutPanel.Controls.Add(capacityLabel, 6, 0);

            int rowIndex = 1;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string shippingLine = reader.GetString(reader.GetOrdinal("shipping_line"));
                    string boatname = reader.GetString(reader.GetOrdinal("boat_name"));
                    string departtime = reader.GetString(reader.GetOrdinal("time_departure"));
                    string arrivaltime = reader.GetString(reader.GetOrdinal("time_arrival"));
                    string origin = reader.GetString(reader.GetOrdinal("origin"));
                    string destination = reader.GetString(reader.GetOrdinal("destination"));
                    int available = reader.GetInt32(reader.GetOrdinal("boat_availableSeat"));

                    PictureBox logoPictureBox = new PictureBox();
                    if (logoMap.ContainsKey(shippingLine))
                    {
                        logoPictureBox.Size = new Size(50, 23);
                        logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        logoPictureBox.Image = Image.FromFile(logoMap[shippingLine]);
                    }

                    Label boatnameLabel = new Label();
                    boatnameLabel.Text = boatname;
                    boatnameLabel.Font = new Font("Myanmar Text", 9, FontStyle.Regular);
                    boatnameLabel.AutoSize = true;

                    Label departtimeLabel = new Label();
                    departtimeLabel.Text = departtime;
                    departtimeLabel.Font = new Font("Myanmar Text", 9, FontStyle.Regular);
                    departtimeLabel.AutoSize = true;

                    Label arrivaltimeLabel = new Label();
                    arrivaltimeLabel.Text = arrivaltime;
                    arrivaltimeLabel.Font = new Font("Myanmar Text", 9, FontStyle.Regular);
                    arrivaltimeLabel.AutoSize = true;

                    Label originLabel = new Label();
                    originLabel.Text = origin;
                    originLabel.Font = new Font("Myanmar Text", 9, FontStyle.Regular);
                    originLabel.AutoSize = true;

                    Label destinationLabel = new Label();
                    destinationLabel.Text = destination;
                    destinationLabel.Font = new Font("Myanmar Text", 9, FontStyle.Regular);
                    destinationLabel.AutoSize = true;

                    Label capacityValueLabel = new Label();
                    capacityValueLabel.Text = available.ToString();
                    capacityValueLabel.Font = new Font("Myanmar Text", 9, FontStyle.Regular);
                    capacityValueLabel.AutoSize = true;

                   
                    tripTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tripTableLayoutPanel.Controls.Add(logoPictureBox, 0, rowIndex);
                    tripTableLayoutPanel.Controls.Add(boatnameLabel, 1, rowIndex);
                    tripTableLayoutPanel.Controls.Add(departtimeLabel, 2, rowIndex);
                    tripTableLayoutPanel.Controls.Add(arrivaltimeLabel, 3, rowIndex);
                    tripTableLayoutPanel.Controls.Add(originLabel, 4, rowIndex);
                    tripTableLayoutPanel.Controls.Add(destinationLabel, 5, rowIndex);
                    tripTableLayoutPanel.Controls.Add(capacityValueLabel, 6, rowIndex);

                    rowIndex++;
                }
            }
            else
            {
                Label noTripLabel = new Label();
                noTripLabel.AutoSize = true;
                noTripLabel.Text = "No Trip Available";
                tripTableLayoutPanel.Controls.Add(noTripLabel, 0, 1);
            }
            reader.Close();
            con.Close();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            dash_text.Visible = false;
            tripTableLayoutPanel.Visible = false;
            contact_us.Visible = true;
            contact_panel.Visible = true;
        }

        private void curentuser_Click(object sender, EventArgs e)
        {
            PopulateDetials();
            dash_text.Visible = true;
            tripTableLayoutPanel.Visible = true;
            panel7.Visible = true;
            contact_us.Visible = false;
            contact_panel.Visible = false;   
        }

        private void history_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void contactSubject_OnLeave(object sender, EventArgs e)
        {
            
                if (contact_subject.Text != "")
                {
                    contact_subject.Text = "";

                }

            
        }

        private void contactMessage_OnLeave(object sender, EventArgs e)
        {

        }

        private void contact_sendBTn_Click(object sender, EventArgs e)
        {
            con.Open();
            string useremail = "" ,userfname ="", userlname = "", usercontact = "";
            string currentUsername = currentUser.Username;
            string currentPass = currentUser.Password;
            string query = "SELECT Email_Address,Fname, Lname,Contact_Number from user WHERE Username = @Username and Password = @Password";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Username", currentUsername);
            command.Parameters.AddWithValue("@Password" ,currentPass);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                useremail = reader["Email_Address"].ToString();
                userfname = reader["Fname"].ToString();
                userlname = reader["Lname"].ToString();
                usercontact = reader["Contact_Number"].ToString();

            }
            reader.Close();
            con.Close();    
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
                            message.To.Add("ticketeasebookingnotification@gmail.com");
                            message.Subject = contact_subject.Text;
                            message.Body = $"Sender's Details:\n\n" +
                           $"Name: {userfname} {userlname}\n" +
                           $"Email: {useremail}\n" +
                           $"Contact Number: {usercontact}\n\n" +
                           $"Message:\n{contact_message.Text}";


                            // Send mail
                            smtp.Send(message);
                            MessageBox.Show("Message Sent Successfully");
                        contact_subject.Text = "";
                        contact_message.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        private void logout_Click(object sender, EventArgs e)
        {
            currentUser = null;
            new Home().Show();
            this.Hide();
        }

    }
}
