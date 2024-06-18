using FizzBuzz.Controllers;
using FizzBuzz.Helper;
using FizzBuzz.Interfaces;
using FizzBuzz.Managers;
using FizzBuzz.Model;
using Moq;

namespace FizzBuzzTests.Controllers
{
    [TestFixture]
    public class FizzBuzzControllerTest
    {
        [Test]
        public void ValidateNumberDivision_ReturnTrue()
        {
            string[] divNumbers = { Constants.strThree };
            IFizzBuzzManager fizzBuzzManager = new ThreeDividerManager();
            //Arrange
            var managerRepositoryMock = new Mock<IFizzBuzzManagerFactory>();
            managerRepositoryMock.Setup(manager => manager.GetFizzBuzzManager(Constants.strThree)).Returns(fizzBuzzManager);
            FizzBuzzController fizzBuzzController = new FizzBuzzController(managerRepositoryMock.Object);

            //Act
            IEnumerable<FizzBuzzModel> fizzBuzz = fizzBuzzController.Post(divNumbers);
            var input = fizzBuzz.Select(i => i.Input).First();
            var result = fizzBuzz.Select(r => r.Result).First();

            //Assert
            Assert.That(input, Is.EqualTo(Constants.strThree));
            Assert.That(result, Is.EqualTo(Constants.Fizz));
        }
    }
}