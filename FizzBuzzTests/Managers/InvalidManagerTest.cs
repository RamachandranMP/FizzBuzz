using FizzBuzz.Managers;
using FizzBuzz.Helper;

namespace FizzBuzzTests.Managers
{
    [TestFixture]
    public class InvalidManagerTest
    {
        private InvalidManager invalidDividerManager;

        [SetUp]
        public void SetUp()
        {
            invalidDividerManager = new InvalidManager();
        }

        [Test]
        public void IsInvalid_ReturnTrue()
        {
            var result = invalidDividerManager.GetDivisionResult(Constants.Fizz);
            Assert.That(result, Is.EqualTo(Constants.InvalidItem));
        }
    }
}
