using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Agency_System.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<int> BookingHistoryIds { get; set; } = new List<int>();
    }
}
