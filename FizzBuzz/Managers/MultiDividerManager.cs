using FizzBuzz.Helper;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Managers
{
    public class MultiDividerManager : IFizzBuzzManager
    {
        public string GetDivisionResult(dynamic inpNumerator)
        {
            return Constants.FizzBuzz;
        }
    }
}
