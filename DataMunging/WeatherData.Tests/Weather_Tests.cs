using NUnit.Framework;
using WeatherData;

namespace WeatherData.Unittests
{
    public class Weather_Tests
    {
        private readonly WeatherData _Weather;
        public Weather_Tests()
        {
            _Weather = new WeatherData();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Spread()
        {
            Assert.AreEqual(14, _Weather.SmallestSpread());
        }
    }
}