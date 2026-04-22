using System;
using System.Collections.Generic;
using System.Text;
using Travel_Agency_System.Data;

namespace Travel_Agency_System.Reports
{
    internal class ReportGenerator
    {
       
        public List<string> GetParticipantList(int tripId)
        {
            var trip = DataContext.Trips.FirstOrDefault(t => t.Id == tripId);
            if (trip == null) return new List<string>();

            
            return DataContext.Clients
                .Where(c => trip.RegisteredClientIds.Contains(c.Id))
                .Select(c => $"{c.Name} {c.Surname}")
                .ToList();
        }

        
        public decimal GetTotalRevenue(DateTime start, DateTime end)
        {
            return DataContext.Payments
                .Where(p => p.Date >= start && p.Date <= end)
                .Sum(p => p.Amount);
        }

        
        public string GetMostPopularDestination()
        {
            var mostPopular = DataContext.Bookings
                .GroupBy(b => b.TripId)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            if (mostPopular == null) return "Няма данни.";

            var trip = DataContext.Trips.First(t => t.Id == mostPopular.Key);
            return trip.MainDestination;
        }
    }
}
