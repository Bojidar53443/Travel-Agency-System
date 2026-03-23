using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Agency_System.Models
{
    internal class Guide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public List<int> AssignedTripIds { get; set; } = new List<int>();
    }
}
