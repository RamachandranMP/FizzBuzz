using FizzBuzz.Interfaces;
using FizzBuzz.Helper;

namespace FizzBuzz.Managers
{
    public class UndividableManager : IFizzBuzzManager
    {
        public string GetDivisionResult(dynamic inpNumerator)
        {
            return Constants.Divided + Constants.Space + inpNumerator + Constants.Space + Constants.ByThree + Constants.Space + Constants.Divided + Constants.Space + inpNumerator + Constants.Space + Constants.ByFive;
        }
    }
}
