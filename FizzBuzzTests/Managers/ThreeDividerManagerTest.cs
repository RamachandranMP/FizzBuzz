using FizzBuzz.Managers;
using FizzBuzz.Helper;

namespace FizzBuzzTests.Managers
{
    [TestFixture]
    public class ThreeDividerManagerTest
    {
        private ThreeDividerManager threeDividerManager;

        [SetUp]
        public void SetUp()
        {
            threeDividerManager = new ThreeDividerManager();
        }

        [Test]
        public void IsThreeDivider_ReturnTrue()
        {
            var result = threeDividerManager.GetDivisionResult(Constants.Three);
            Assert.That(result, Is.EqualTo(Constants.Fizz));
        }
    }
}
