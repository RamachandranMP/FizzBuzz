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
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.strFifteen);
            var result = factManager.GetDivisionResult(Constants.strFifteen);
            Assert.That(result, Is.EqualTo(Constants.FizzBuzz));
        }

        [Test]
        public void IsMultiDivider_ReturnFalse()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.strFive);
            var result = factManager.GetDivisionResult(Constants.strFifteen);
            Assert.That(result, Is.Not.EqualTo(Constants.FizzBuzz));
        }

        [Test]
        public void IsThreeDivider_ReturnTrue()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.strThree);
            var result = factManager.GetDivisionResult(Constants.strThree);
            Assert.That(result, Is.EqualTo(Constants.Fizz));
        }

        [Test]
        public void IsFiveDivider_ReturnTrue()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.strFive);
            var result = factManager.GetDivisionResult(Constants.strFive);
            Assert.That(result, Is.EqualTo(Constants.Buzz));
        }

        [Test]
        public void IsUnDivider_ReturnFalse()
        {
            var factManager = fizzBuzzFactory.GetFizzBuzzManager(Constants.strOne);
            var result = factManager.GetDivisionResult(Constants.strOne);
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
