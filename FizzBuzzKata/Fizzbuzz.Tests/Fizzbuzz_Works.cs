using NUnit.Framework;
using Fizzbuzz;

namespace Fizzbuzz.Unittests
{
    public class Fizzbuzz_Works
    {
        private readonly Fizzbuzz _Fizzbuzz;

        public Fizzbuzz_Works()
        {
            _Fizzbuzz = new Fizzbuzz();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThisFails()
        {
            Assert.IsFalse(true);
            
        }
    }
}