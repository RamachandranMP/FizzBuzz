using FizzBuzz.Helper;
using FizzBuzz.Managers;

namespace FizzBuzzTests.Helper
{
    public class FizzBuzzHelperTest
    {
        [Test]
        public void IsNumeric_ReturnTrue()
        {
            bool result = FizzBuzzHelper.IsNumeric(Constants.StrOne);
            Assert.That(result, Is.EqualTo(true));
        }
        [Test]
        public void IsNumeric_ReturnFalse()
        {
            bool result = FizzBuzzHelper.IsNumeric(Constants.Fizz);
            Assert.That(result, Is.Not.EqualTo(true));
        }
    }
}
