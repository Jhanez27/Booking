# Booking System for Fastcraft and Ferries
- This system is for Application Development and Event-Driven Programming final output.
- This system allows user / clerk to book passenger in their chosen vessel name and trip date/ time. 
- The passeger will have the option to either have their ticket printed or sent to their email address.

## Table of Contents
 [Features of The System](#features-of-the-system)
- [Login Page](#login-page)
- [Reset Password Page](#reset-password-page)
- [Dashboard](#dashboard)
- [Booking Page](#booking-page)
- [Booking History](#booking-history)
- [Report Page](#report-page)
- [Class Diagram](#class-diagram)

[Database Used](#database-used)

[Entity Relationship Diagram](#entity-relationship-diagram)

[Events Documentation](#events-documentation)

[Use Case Diagram](#use-case-diagram)


## Features of the System

### Login Page
![Login Page](https://github.com/Jhanez27/Booking/assets/113825787/3f12f9b8-1fdd-4651-a739-b7c167361d1d)
 *This is the page that will appear upon opening the application, this is where the user will input his login credentials.*

### Reset Password Page
![Reset Password Page](https://github.com/Jhanez27/Booking/assets/113825787/405d54c9-3ef6-4a91-9e33-37f3d2cede3b)
 *This page is will show when the label link Forgot password is click, this page is when the user forgets his login credential , password in particular and want a reset.*

### Dashboard
![Dashboard](https://github.com/Jhanez27/Booking/assets/113825787/4ba7eb2e-abea-4b88-9015-2f51a0e76261)
 *This page will appear after logging in. The displays here includes , time and date , total sales ,number of bookings , number of cancelled bookings , and the number of trips for each of the affiliate shipping lines (within the day).*

 ### Booking Page
 ![Booking Page](https://github.com/Jhanez27/Booking/assets/113825787/9633a6ff-ae15-42a5-97e3-098120a55aeb)
  *This page is where the user/clerk books the trip of a passenger. He can search trip by selecting trip date , origin and destination and a list of available trips will be displayed.*

 ### Booking History
  ![Booking History](https://github.com/Jhanez27/Booking/assets/113825787/ef1844d9-591c-4694-8556-5fbdda2e71e2)
  *This page is where he can view previous bookings. Here is where he can cancel a booking and an email notifying the passenger regarding the cancellation will be sent.*

 ### Report Page
 ![Report Page](https://github.com/Jhanez27/Booking/assets/113825787/b5f97580-059d-4bfc-a217-18ae281bd5a0)
  *In this page the user can generate sales report. He just choose what date to generate on the datetime picker and a display will show. He has the option to print the report is he like.*

## Database Used
  ![Database Used](https://github.com/Jhanez27/Booking/assets/113825787/091b28ce-9bc1-4648-bc24-84a9bd2c38e9)
 *For data storage,i used mysql database , with the following credentials:*

*Username : Jhanez28 , Password : @Sur1nga123 , server : Localhost , database : bookingsystem*

## Entity Relationship Diagram
![Entity Relationship Diagram](https://github.com/Jhanez27/Booking/assets/113825787/d6465b9e-5718-46b3-9c72-11310c767d29)

### booking
*contains passenger booking information*
- booking_id (primary key)
- username (foreign key reference user Username)
- passenger_id (foreign key reference passenger passenger_id
- trip_id (foreign key reference trip trip_id)
- booking_amount
- booking_date
- booking_status
- date_cancelled

### user
*stores user/clerk private information*
- Username (primary key)
- Password
- Email_Address
- Contact_Number
- Fname
- Lname

### passenger
*Stores passenger information*
 - passenger_id (primary key)
 - passenger_fname
 - passenger_lname
 - passenger_age
 - passenger_gender
 - passenger_contactNum
 - passenger_email
 - passenger_ticket_number
 - passenger_accomodation

### boat
*contains vessel information*
 - boat_id (primary key)
 - boat_name
 - shipping_line

### trip
*this contains all trip information*
 - trip_id (primary key)
 - boat_id (foreign key reference boat boat_id)
 - origin
 - destination
 - date_departure
 - availableSeat
 - trip_ETA

### accomodation
*stores all accomodation for each of the trips*
 - acc_trip_id (foreign key reference trip trip_id)
 - accomodation_id (primary key)
 - accomodation_name
 - accomodation_price
 - seatAvailable

## Events Documentation
![Events Documentation](https://github.com/Jhanez27/Booking/assets/113825787/566345e3-acfa-4e6d-b79f-1366fb47b69c)

 *To view the whole list of events, download document [here](https://github.com/Jhanez27/Booking/files/15164326/event_documentation.pdf)*


 ## Use Case Diagram
![Use Case Diagram](https://github.com/Jhanez27/Booking/assets/113825787/8fc3d7a3-517a-4740-9383-2a05aa7a2ec8)

## Class Diagram



