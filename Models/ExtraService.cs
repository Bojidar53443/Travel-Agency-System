using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Agency_System.Models
{
    public class ExtraService
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public decimal Price { get; set; }      
        public string Description { get; set; } 

        
        public int? RelatedTripId { get; set; }
    }
}
