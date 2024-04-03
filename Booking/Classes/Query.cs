﻿using MySql.Data.MySqlClient;
using System;
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
            Console.WriteLine(username);
            Console.WriteLine(todayDate);
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
            Console.WriteLine(shippingLine);
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) " +
                      "FROM trip " +
                      "INNER JOIN boat ON trip.boat_id = boat.boat_id " +
                      "WHERE DATE(trip.date_departure) = DATE(@Today) " +
                      "AND boat.boat_availableSeat > 0 " +
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
    }
}
