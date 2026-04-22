using System;
using System.Collections.Generic;
using System.Text;
using Travel_Agency_System.Data;

namespace Travel_Agency_System.Models
{
    public class Client
    {
       
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string EmailAddress { get; set; }
            public string PhoneNumber { get; set; }
        
    }
}
