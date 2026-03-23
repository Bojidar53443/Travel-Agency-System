using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Agency_System.Models
{
    internal class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethod { get; set; } 
    }
}
