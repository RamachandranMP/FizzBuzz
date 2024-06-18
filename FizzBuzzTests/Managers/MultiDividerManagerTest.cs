using FizzBuzz.Managers;
using FizzBuzz.Helper;

namespace FizzBuzzTests.Managers
{
    [TestFixture]
    public class MultiDividerManagerTest
    {
        private MultiDividerManager multiDividerManager;

        [SetUp]
        public void SetUp()
        {
            multiDividerManager = new MultiDividerManager();
        }

        [Test]
        public void IsMultiDivider_ReturnTrue()
        {
            var result = multiDividerManager.GetDivisionResult(Constants.strFifteen);
            Assert.That(result, Is.EqualTo(Constants.FizzBuzz));
        }
    }
}
