using System;
using System.Collections.Generic;
using System.Text;
using Travel_Agency_System.Data;

namespace Travel_Agency_System.Reports
{
    internal class VoucherService
    {
        public string GenerateVoucher(int bookingId)
        {
            
            var booking = DataContext.Bookings.FirstOrDefault(b => b.Id == bookingId);
            if (booking == null) return "Грешка: Резервацията не е намерена!";

            
            var client = DataContext.Clients.FirstOrDefault(c => c.Id == booking.ClientId);
            var trip = DataContext.Trips.FirstOrDefault(t => t.Id == booking.TripId);

            if (client == null || trip == null) return "Грешка: Непълни данни за ваучера!";

            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**************************************************");
            sb.AppendLine("           ТУРИСТИЧЕСКИ ВАУЧЕР (OFFICIAL)         ");
            sb.AppendLine("**************************************************");
            sb.AppendLine($" Номер на ваучер: {booking.Id:D5}");
            sb.AppendLine($" Дата на издаване: {DateTime.Now:dd/MM/yyyy}");
            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine($" КЛИЕНТ: {client.FirstName} {client.LastName}");
            sb.AppendLine($" ТЕЛЕФОН: {client.Phone}");
            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine($" ДЕСТИНАЦИЯ: {trip.MainDestination}");
            sb.AppendLine($" ПЕРИОД: {trip.StartDate:dd/MM/yyyy} - {trip.EndDate:dd/MM/yyyy}");
            sb.AppendLine($" БРОЙ УЧАСТНИЦИ: {booking.PeopleCount}");

            if (trip.AdditionalStops.Any())
            {
                sb.AppendLine($" МАРШРУТ: {string.Join(" -> ", trip.AdditionalStops)}");
            }

            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine($" СТАТУС: {booking.Status}");
            sb.AppendLine($" ПЛАТЕНА СУМА: {booking.FinalPrice:F2} лв.");
            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine("   Благодарим Ви, че избрахте нашата агенция!     ");
            sb.AppendLine("**************************************************");

            return sb.ToString();
        }
    }
}
