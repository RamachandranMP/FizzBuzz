using FizzBuzz.Helper;
using FizzBuzz.Interfaces;
using System.Reflection.Metadata;

namespace FizzBuzz.Managers
{
    public class FiveDividerManager : IFizzBuzzManager
    {
        public string GetDivisionResult(dynamic inpNumerator)
        {
            return Constants.Buzz;
        }
    }
}
