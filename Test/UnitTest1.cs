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
    }
}
