using System;
using System.Collections.Generic;
using System.Text;
using Travel_Agency_System.Data;
using Travel_Agency_System.Models;

namespace Travel_Agency_System.Services
{
    internal class ClientManager
    {
        public void RegisterClient(string firstName, string lastName, string email, string phone)
        {
            int nextId = DataContext.Clients.Count + 1;
            var client = new Client
            {
                Id = nextId,
                Name = firstName,
                Surname = lastName,
                EmailAddress = email,
                PhoneNumber = phone
            };
            DataContext.Clients.Add(client);
        }

        
        public bool UpdateClient(int clientId, string newPhone, string newEmail)
        {
            var client = DataContext.Clients.FirstOrDefault(c => c.Id == clientId);
            if (client != null)
            {
                client.PhoneNumber = newPhone;
                client.EmailAddress = newEmail;
                return true;
            }
            return false;
        }
    }
}
