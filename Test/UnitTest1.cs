using Travel_Agency_System.Enums;
using Travel_Agency_System.Models;
using Travel_Agency_System.Services;
using Travel_Agency_System.Data;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Trip_Duration_ShouldBeCorrect()
        {
            var start = new DateTime(2026, 5, 1);
            var end = new DateTime(2026, 5, 10);
            var trip = new Trip { StartDate = start, EndDate = end };

            var duration = (trip.EndDate - trip.StartDate).Days;

            Assert.That(duration, Is.EqualTo(9));
        }

        [Test]
        public void Client_FullName_ShouldConcatenateCorrectly()
        {
            var client = new Client { FirstName = "Ivan", LastName = "Ivanov" };

            string fullName = $"{client.FirstName} {client.LastName}";

            Assert.That(fullName, Is.EqualTo("Ivan Ivanov"));
        }


        [Test]
        public void Trip_AvailableSeats_ShouldDecreaseWhenClientAdded()
        {
            var trip = new Trip { MaxCapacity = 50 };
            var registeredClients = new List<int> { 1, 2, 3 }; 

            int available = trip.MaxCapacity - registeredClients.Count;

            Assert.That(available, Is.EqualTo(47));
        }

        [Test]
        public void Booking_InitialStatus_ShouldBePending()
        {
            var booking = new Booking { Status = BookingStatus.Pending };

            Assert.That(booking.Status, Is.EqualTo(BookingStatus.Pending));
        }

        [Test]
        public void ExtraService_Price_ShouldNotBeNegative()
        {
            var service = new ExtraService { Price = 50.0m };

            Assert.That(service.Price, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void Trip_BasePrice_ShouldHoldCorrectValue()
        {
            var trip = new Trip { BasePrice = 1200.50m };
            Assert.That(trip.BasePrice, Is.EqualTo(1200.50m));
        }

        [Test]
        public void Client_Email_ShouldStoreCorrectValue()
        {
            var client = new Client { Email = "dqdokukuruz.com" };
            Assert.That(client.Email, Is.EqualTo("enevdar.com"));
        }

        [Test]
        public void Client_Phone_ShouldStoreCorrectValue()
        {
            var client = new Client { Phone = "0888123456" };
            Assert.That(client.Phone, Is.EqualTo("0888123456"));
        }
    }
}
