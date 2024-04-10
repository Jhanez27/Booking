using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Booking.Classes
{

     public class Query
    {
        List<Accommodation> accommodations = new List<Accommodation>();
        List<Destination> destinations = new List<Destination>();
        List<Trip> trips = new List<Trip>();
        List<Origin> origins = new List<Origin>();
        Trip tripDetails;
        MySqlConnection con = new MySqlConnection("SERVER = LOCALHOST;DATABASE = bookingsystem; UID = Jhanez28; PASSWORD = @Sur1nga123");
        public Boolean insertUser(string username, string password, string email, string pNumber,string fname, string lname)

        {
            bool res = false;
            try
            {
                con.Open();
                // Check if username already exists
                MySqlDataAdapter sd = new MySqlDataAdapter("select Username,Email_Address from user where Username= '" + username + "' OR Email_Address='" + email + "'", con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username or Email Address already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    // Insert user data into the database
                    MySqlDataAdapter da = new MySqlDataAdapter("insert into user(Username,Password,Email_Address,Contact_Number,Fname,Lname) values ('" + username + "', '" + password + "', '" + email + "','" + pNumber + "','" + fname + "','" + lname + "')", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Sign Up Successful, Continue to Login");
                    res = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();

            }
            return res;
        }
        public Boolean searchAccount(string username, string password)
        {
            con.Open();
            bool search = true;
            MySqlDataAdapter sd = new MySqlDataAdapter("select Username,Password from user where Username= '" + username + "' and Password= '" + password + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Wrong Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                search = false;
            }
            con.Close();
            return search;
        }
        public Boolean searchEmail(string email)
        {
            con.Open();
            bool search = true;
            MySqlDataAdapter sd = new MySqlDataAdapter("select Email_Address from user where Email_Address= '" + email + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Email Not Registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                search = false;

            }
            con.Close();
            return search;
        }
        public void updateEmail(string email, string newpass) {
            con.Open();
            try
            {
                MySqlDataAdapter ds = new MySqlDataAdapter("update user set Password='" + newpass + "' where Email_Address ='" +email+ "'", con);
                DataSet dw = new DataSet();
                ds.Fill(dw);
                MessageBox.Show("Change Successful, Continue to Login");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
        public int getDailySales(string username)
        {
            int dailySales = 0;
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            con.Open();
            string query = "SELECT booking_amount FROM booking where username= '"+username+"' AND booking_date = @Today";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Today", todayDate);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()) { 
                dailySales+= reader.GetInt32(reader.GetOrdinal("booking_amount"));
            }
            reader.Close();
            con.Close();
            return dailySales;
        }
        public int getNumberOfBookings(string username)
        {
            int numberBookings = 0;
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            con.Open();
            string query = "SELECT * FROM booking where username= '" + username + "' AND booking_date = @Today";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Today", todayDate);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                numberBookings++;
            }
            reader.Close();
            con.Close();
            return numberBookings;
        }
        public int getNumberOfTrips(string shippingLine)
        {
            int numberTrips = 0;
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) " +
                      "FROM trip " +
                      "INNER JOIN boat ON trip.boat_id = boat.boat_id " +
                      "WHERE DATE(trip.date_departure) = DATE(@Today) " +
                      "AND trip.availableSeat > 0 " +
                      "AND boat.shipping_line = @ShippingLine";

                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ShippingLine", shippingLine);
                    command.Parameters.AddWithValue("@Today", todayDate);
                    numberTrips = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return numberTrips;
        }
        public List<Destination> addDestination()
        {
            HashSet<string> destinationNames = new HashSet<string>();

            con.Open();
            string query = "SELECT destination FROM trip";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string destinationName = reader["destination"].ToString();

                if (!destinationNames.Contains(destinationName))
                {
                    Destination destination = new Destination();
                    destination.destinationName = destinationName;
                    destinations.Add(destination);
                    destinationNames.Add(destinationName);
                }
            }

            reader.Close();
            con.Close();

            return destinations;
        }
        public List<Origin> addOrigin()
        {
            HashSet<string> originNames = new HashSet<string>();
            con.Open();
            string query = "SELECT origin FROM trip";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string originName = reader["origin"].ToString();

                if (!originNames.Contains(originName))
                {
                    Origin origin = new Origin();
                    origin.originName = originName;
                    origins.Add(origin);
                    originNames.Add(originName);
                }
            }

            reader.Close();
            con.Close();

            return origins;
        }
        public List<Trip> getTrips(string origin , string destination , DateTime departTime)
        {
            trips.Clear();
            con.Open();
            string query = "SELECT trip.*,boat.boat_name, boat.shipping_line FROM trip INNER JOIN boat on trip.boat_id = boat.boat_id WHERE DATE(trip.date_departure) = Date(@Schedule) and availableSeat > 0 and origin = @Origin and destination = @Destination";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Schedule",departTime);
            command.Parameters.AddWithValue("@Origin", origin);
            command.Parameters.AddWithValue("@Destination", destination);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int trip_id_int = reader.GetInt32(reader.GetOrdinal("trip_id"));
                string tripId = trip_id_int.ToString();
                string shippingLine = reader.GetString(reader.GetOrdinal("shipping_line"));
                string boatname = reader.GetString(reader.GetOrdinal("boat_name"));
                string boat_destination = reader.GetString(reader.GetOrdinal("destination"));
                string boat_origin = reader.GetString(reader.GetOrdinal("origin"));
                DateTime dateTime = reader.GetDateTime(reader.GetOrdinal("date_departure"));
                string departtime = dateTime.ToString("hh:mm tt");

                Trip trip = new Trip
                {
                    trip_id = tripId,
                    shippingLine = shippingLine,
                    boat_name = boatname,
                    destination = boat_destination,
                    origin = boat_origin,
                    departureDate = departtime
                };

                // Add the Trip object to the trips list
               
                trips.Add(trip);

            }

            reader.Close();
            con.Close();

            return trips;
        }
        public List<Accommodation> getAccomodation(string tripId)
        {
            con.Open();
            string query = "SELECT accomodation_name FROM accomodation WHERE trip_id = @Trip";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Trip", tripId);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Accommodation accommo = new Accommodation();
                accommo.accomName = reader.GetString(reader.GetOrdinal("accomodation"));
                accommodations.Add(accommo);
            }
            reader.Close();
            con.Close() ;
            return accommodations;
        }
        public Trip getTripDetials(string tripId)
        {
            con.Open();
            string query = "SELECT trip.*,boat.boat_name, boat.shipping_line FROM trip INNER JOIN boat on trip.boat_id = boat.boat_id WHERE trip.trip_id = @TripId";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@TripId",tripId);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int trip_id_int = reader.GetInt32(reader.GetOrdinal("trip_id"));
                string trip_Id = trip_id_int.ToString();
                string shippingLine = reader.GetString(reader.GetOrdinal("shipping_line"));
                string boatname = reader.GetString(reader.GetOrdinal("boat_name"));
                string boat_destination = reader.GetString(reader.GetOrdinal("destination"));
                string boat_origin = reader.GetString(reader.GetOrdinal("origin"));
                DateTime dateTime = reader.GetDateTime(reader.GetOrdinal("date_departure"));
                string formattedDate = dateTime.ToString("MMMM/dd/yyyy");
                string departtime = dateTime.ToString("hh:mm tt");

                tripDetails = new Trip()
                {
                    trip_id = trip_Id,
                    shippingLine = shippingLine,
                    boat_name = boatname,
                    destination = boat_destination,
                    origin = boat_origin,
                    departureDate = formattedDate +  "   (" + departtime + ")"

                 };

             }
                 reader.Close();
                con.Close();
                return tripDetails;                    
        }

    }
}
