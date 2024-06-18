using FizzBuzz.Managers;
using FizzBuzz.Helper;

namespace FizzBuzzTests.Managers
{
    [TestFixture]
    public class FiveDividerManagerTest
    {
        private FiveDividerManager fiveDividerManager;

        [SetUp]
        public void SetUp()
        {
            fiveDividerManager = new FiveDividerManager();
        }

        [Test]
        public void IsFiveDivider_ReturnTrue()
        {
            var result = fiveDividerManager.GetDivisionResult(Constants.Five);
            Assert.That(result, Is.EqualTo(Constants.Buzz));
        }
    }
}
