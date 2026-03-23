using System;
using System.Collections.Generic;
using System.Text;
using Travel_Agency_System.Models;

namespace Travel_Agency_System.Data
{
    internal class DataContext
    {
        public static List<Client> Clients = new List<Client>();
        public static List<Trip> Trips = new List<Trip>();
        public static List<Booking> Bookings = new List<Booking>();
        public static List<Payment> Payments = new List<Payment>();
        public static List<Guide> Guides = new List<Guide>();
    }
}
