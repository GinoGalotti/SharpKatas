using NUnit.Framework;
using Fizzbuzz;

namespace Fizzbuzz.Unittests
{
    public class Fizzbuzz_Tests
    {
        private readonly Fizzbuzz _Fizzbuzz;

        public Fizzbuzz_Tests()
        {
            _Fizzbuzz = new Fizzbuzz();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Fizzbuzz_ReturnsNumber()
        {
            Assert.AreEqual("0", _Fizzbuzz.DoStuff(0));
            Assert.AreEqual("1", _Fizzbuzz.DoStuff(1));
            Assert.AreEqual("7", _Fizzbuzz.DoStuff(7));
            Assert.AreEqual("19", _Fizzbuzz.DoStuff(19));
        }

        [Test]
        public void Fizzbuzz_ReturnsFizz()
        {
            Assert.AreEqual("fizz", _Fizzbuzz.DoStuff(3));
            Assert.AreEqual("fizz", _Fizzbuzz.DoStuff(9));
            Assert.AreEqual("fizz", _Fizzbuzz.DoStuff(33));
        }
        [Test]
        public void Fizzbuzz_ReturnsBuzz()
        {
            Assert.AreEqual("buzz", _Fizzbuzz.DoStuff(5));
            Assert.AreEqual("buzz", _Fizzbuzz.DoStuff(10));
            Assert.AreEqual("buzz", _Fizzbuzz.DoStuff(20));
            Assert.AreEqual("buzz", _Fizzbuzz.DoStuff(50));
        }
        [Test]
        public void Fizzbuzz_ReturnsFizzbuzz()
        {
            Assert.AreEqual("fizzbuzz", _Fizzbuzz.DoStuff(15));
            Assert.AreEqual("fizzbuzz", _Fizzbuzz.DoStuff(30));
            Assert.AreEqual("fizzbuzz", _Fizzbuzz.DoStuff(45));
            Assert.AreEqual("fizzbuzz", _Fizzbuzz.DoStuff(90));
        }

    }
}