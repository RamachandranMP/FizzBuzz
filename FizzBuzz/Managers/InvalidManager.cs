using FizzBuzz.Helper;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Managers
{
    public class InvalidManager : IFizzBuzzManager
    {
        public string GetDivisionResult(dynamic inpNumerator)
        {
            return Constants.InvalidItem;
        }
    }
}
