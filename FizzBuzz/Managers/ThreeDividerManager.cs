using FizzBuzz.Helper;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Managers
{
    public class ThreeDividerManager : IFizzBuzzManager
    {
        public string GetDivisionResult(dynamic inpNumerator)
        {
            return Constants.Fizz;
        }
    }
}
