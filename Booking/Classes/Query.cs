using Booking.usercontrol;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Booking.Classes
{

     public class Query
    {
        private List<bookingHistoryDetail> bookinghistories = new List<bookingHistoryDetail>();
        private List<Accommodation> accommodations = new List<Accommodation>();
        private List<Destination> destinations = new List<Destination>();
        private List<Trip> trips = new List<Trip>();
        private List<Origin> origins = new List<Origin>();
        private List<BoatName> boats = new List<BoatName>();
        private List<departureTime> departTimes = new List<departureTime>();
        private Trip tripDetails;
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
        public float getDailySales(string username)
        {
            float dailySales = 0;
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            con.Open();
            string query = "SELECT booking_amount FROM booking where username= '"+username+"' AND booking_date = @Today and booking_status = 'Paid'";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Today", todayDate);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()) {
                dailySales += reader.GetFloat(reader.GetOrdinal("booking_amount"));
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
                      "WHERE DATE(trip.date_departure) = DATE(@Today) AND TIME(trip.date_departure) > CURTIME()" +
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
        public List<BoatName> getBoatName()
        {
            con.Open();
            string query = "SELECT boat_name from boat";
            MySqlCommand command = new MySqlCommand( query, con);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string boat_name = reader["boat_name"].ToString();
                BoatName boat = new BoatName();
                boat.boatName = boat_name;
                boats.Add(boat);
            }
            return boats;
        }
        public List<Trip> getTrips(string origin , string destination , DateTime departTime)
        {
            trips.Clear();
            con.Open();
            string query = "SELECT trip.*,boat.boat_name, boat.shipping_line FROM trip INNER JOIN boat on trip.boat_id = boat.boat_id WHERE DATE(trip.date_departure) = Date(@Schedule) AND availableSeat > 0 and origin = @Origin and destination = @Destination";
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
                int tripETA = reader.GetInt32(reader.GetOrdinal("trip_ETA"));
                string trip_ETA = tripETA.ToString();

                Trip trip = new Trip
                {
                    trip_id = tripId,
                    shippingLine = shippingLine,
                    boat_name = boatname,
                    destination = boat_destination,
                    origin = boat_origin,
                    departureDate = departtime,
                    trip_ETA = trip_ETA,
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
            string query = "SELECT accomodation_name FROM accomodation WHERE trip_id = @Trip AND seatAvailable > 0";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Trip", tripId);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Accommodation accommo = new Accommodation();
                accommo.accomName = reader.GetString(reader.GetOrdinal("accomodation_name"));
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
                string formattedDate = dateTime.ToString("MMMM dd yyyy");
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
        public int getAccomPrice(string tripId , string accomName)
        {
            int price = 0;
            con.Open();
            string query = "SELECT accomodation_price FROM accomodation WHERE trip_id = @Trip AND accomodation_name = @AccomodationName";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Trip", tripId);
            command.Parameters.AddWithValue("@AccomodationName", accomName);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                price = reader.GetInt32(reader.GetOrdinal("accomodation_price"));
                
            }
            reader.Close();
            con.Close();
            return price;
        }
        public int insertPassenger(Passenger p)
        {
            int passengerId = -1;
            try
            {
                    con.Open();
                    string insertQuery = "INSERT INTO passenger (passenger_fname, passenger_lname , passenger_age, passenger_gender, passenger_contactNum,passenger_email,passenger_ticket_number,passenger_accomodation) " +
                    "VALUES (@Fname, @Lname, @Age,  @Gender, @Number, @Email, @TicketNum, @Accom); SELECT LAST_INSERT_ID();";
                    MySqlCommand command = new MySqlCommand(insertQuery, con);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Fname", p.passenger_fname);
                    command.Parameters.AddWithValue("@Lname", p.passenger_lname);
                    command.Parameters.AddWithValue("@Age", p.passenger_age);
                    command.Parameters.AddWithValue("@Gender", p.passenger_gender);
                    command.Parameters.AddWithValue("@Number", p.passenger_number);
                    command.Parameters.AddWithValue("@Email", p.passenger_email);
                   command.Parameters.AddWithValue("@TicketNum", p.ticketNumber);
                    command.Parameters.AddWithValue("@Accom", p.accomodation);
                        passengerId = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding passenger: " + ex.Message);
            }
            con.Close();
            return passengerId;
        }
        public Boolean insertBooking(PassengerBooking pb)
        {
            bool inserted = false;
           
            try
            {
                con.Open();
                string insertQuery = "INSERT INTO booking (username, passenger_id ,trip_id,booking_amount,booking_date,booking_status) " +
                "VALUES (@Username, @PassengerId, @TripId,  @BookingAmount, @BookingDate, @BookingStatus)";
                MySqlCommand command = new MySqlCommand(insertQuery, con);

                // Add parameters to the command
                command.Parameters.AddWithValue("@Username", pb.bookedAdmin);
                command.Parameters.AddWithValue("@PassengerId", pb.passenger_id);
                command.Parameters.AddWithValue("@TripId", pb.trip_id);
                command.Parameters.AddWithValue("@BookingAmount", pb.booking_amount);
                command.Parameters.AddWithValue("@BookingDate", pb.booked_Date);
                command.Parameters.AddWithValue("@BookingStatus", pb.booked_status);

                command.ExecuteNonQuery();
                inserted = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding booking: " + ex.Message);
            }
            con.Close();
            return inserted;
        }
        public void updateAccomodationSeat(string tripId , string accomodationName)
        {
            con.Open();
            try
            {
                string updateQuery = "UPDATE accomodation SET seatAvailable = seatAvailable - 1 WHERE trip_id = @TripId and accomodation_name = @AccomodationName";
                MySqlCommand command = new MySqlCommand(@updateQuery, con);
                command.Parameters.AddWithValue("@TripId", tripId);
                command.Parameters.AddWithValue("@AccomodationName", accomodationName);
                command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            con.Close();

        }
        public float getReportSales(string username , string date)
        {
            float dailySales = 0;
            con.Open();
            string query = "SELECT booking_amount FROM booking where username= '" + username + "' AND booking_date = '"+date+"' and booking_status = 'Paid'";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dailySales += reader.GetFloat(reader.GetOrdinal("booking_amount"));
            }
            reader.Close();
            con.Close();
            return dailySales;
        }
        public List<bookingHistoryDetail> getBookings(string adminName , string date , string vessel , string selectedTime) 
        {
            bookinghistories.Clear();
            con.Open();
            string query = "SELECT booking.*, boat.boat_name, trip.date_departure,trip.origin,trip.destination, passenger.passenger_fname, passenger.passenger_lname, passenger.passenger_email,passenger.passenger_ticket_number" +
                " FROM booking" +
                " INNER JOIN trip ON booking.trip_id = trip.trip_id" +
                " INNER JOIN boat ON trip.boat_id = boat.boat_id" +
                " INNER JOIN passenger ON booking.passenger_id = passenger.passenger_id" +
                " WHERE booking.username = @adminName" +
                " AND DATE(trip.date_departure) = @departureDate" +
                " AND boat.boat_name = @Vessel and TIME(trip.date_departure) = @Time";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@adminName", adminName);
            command.Parameters.AddWithValue("@departureDate" , date);
            command.Parameters.AddWithValue("@Vessel" ,  vessel);  
            command.Parameters.AddWithValue("@Time" , selectedTime);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int booking_id_int = reader.GetInt32(reader.GetOrdinal("booking_id"));
                string boatname = reader.GetString(reader.GetOrdinal("boat_name"));
                DateTime dateTime = reader.GetDateTime(reader.GetOrdinal("date_departure"));
                string formattedDate = dateTime.ToString("MMMM dd, yyyy");
                string departtime = dateTime.ToString("hh:mm tt");
                string boat_destination = reader.GetString(reader.GetOrdinal("destination"));
                string boat_origin = reader.GetString(reader.GetOrdinal("origin"));
                string passengerfname = reader.GetString(reader.GetOrdinal("passenger_fname"));
                string passengerlname = reader.GetString(reader.GetOrdinal("passenger_lname"));
                string ticketNumber = reader.GetString(reader.GetOrdinal("passenger_ticket_number"));
                string stat = reader.GetString(reader.GetOrdinal("booking_status"));



                bookingHistoryDetail h = new bookingHistoryDetail
                {
                    bookingId = booking_id_int,
                    vesselName = boatname,
                    tripSchedule = formattedDate + " / " + departtime,
                    origin = boat_origin,
                    destination = boat_destination,
                    passengerName = passengerfname + " " + passengerlname,
                    ticketNumber = ticketNumber,
                    bookingStatus = stat,

                };

                bookinghistories.Add(h);

            }
            reader.Close();
            con.Close();
            return bookinghistories;
        }
        public List<departureTime> getDepartureTimes(string vesselName)
        {
            departTimes.Clear();
            string connectionString = "SERVER=LOCALHOST;DATABASE=bookingsystem;UID=Jhanez28;PASSWORD=@Sur1nga123";

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            string query = "SELECT TIME_FORMAT(trip.date_departure, '%h:%i %p') AS departure_time " +
                           "FROM trip " +
                           "INNER JOIN boat ON trip.boat_id = boat.boat_id " +
                           "WHERE boat.boat_name = @Vessel";

            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@Vessel", vesselName);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                departureTime depart_time = new departureTime();
                string depart = reader["departure_time"].ToString();
                depart_time.departime = depart;
                departTimes.Add(depart_time);
            }

            reader.Close();
            con.Close();

            return departTimes;
        }
    }
}
