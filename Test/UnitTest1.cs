using Travel_Agency_System.Models;
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

       
    }
}
