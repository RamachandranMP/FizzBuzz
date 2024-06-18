using FizzBuzz.Managers;
using FizzBuzz.Helper;

namespace FizzBuzzTests.Managers
{
    [TestFixture]
    public class UndividableManagerTest
    {
        private UndividableManager undividableManager;

        [SetUp]
        public void SetUp()
        {
            undividableManager = new UndividableManager();
        }

        [Test]
        public void IsUndividableDivider_ReturnTrue()
        {
            var result = undividableManager.GetDivisionResult(Constants.StrOne);
            Assert.That(result, Is.Not.EqualTo(Constants.FizzBuzz));
        }
    }
}
