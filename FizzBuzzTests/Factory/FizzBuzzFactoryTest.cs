using FizzBuzz.Factory;
using FizzBuzz.Helper;
using FizzBuzz.Interfaces;
using FizzBuzz.Managers;

namespace FizzBuzzTests.Factory
{
    public class FizzBuzzFactoryTest
    {
        private FizzBuzzManagerFactory fizzBuzzFactory;

        [SetUp]
        public void SetUp()
        {
            fizzBuzzFactory = new FizzBuzzManagerFactory();
        }

        [Test]
        public void IsMultiDivider_ReturnTrue()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.StrFifteen);
            var result = factManager.GetDivisionResult(Constants.StrFifteen);
            Assert.That(result, Is.EqualTo(Constants.FizzBuzz));
        }

        [Test]
        public void IsMultiDivider_ReturnFalse()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.StrFive);
            var result = factManager.GetDivisionResult(Constants.StrFifteen);
            Assert.That(result, Is.Not.EqualTo(Constants.FizzBuzz));
        }

        [Test]
        public void IsThreeDivider_ReturnTrue()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.StrThree);
            var result = factManager.GetDivisionResult(Constants.StrThree);
            Assert.That(result, Is.EqualTo(Constants.Fizz));
        }

        [Test]
        public void IsFiveDivider_ReturnTrue()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.StrFive);
            var result = factManager.GetDivisionResult(Constants.StrFive);
            Assert.That(result, Is.EqualTo(Constants.Buzz));
        }

        [Test]
        public void IsUnDivider_ReturnFalse()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.StrOne);
            var result = factManager.GetDivisionResult(Constants.StrOne);
            Assert.That(result, Is.Not.EqualTo(Constants.FizzBuzz));
        }

        [Test]
        public void IsInvalid_ReturnTrue()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.Fizz);
            var result = factManager.GetDivisionResult(Constants.Fizz);
            Assert.That(result, Is.EqualTo(Constants.InvalidItem));
        }
    }
}
