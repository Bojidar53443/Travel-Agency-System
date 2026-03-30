using System;
using System.Collections.Generic;
using System.Text;
using Travel_Agency_System.Enums;

namespace Travel_Agency_System.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TripId { get; set; }
        public int PeopleCount { get; set; } 
        public BookingStatus Status { get; set; }
        public decimal FinalPrice { get; set; } 
        public List<string> ExtraServices { get; set; } = new List<string>(); 
    }
}
