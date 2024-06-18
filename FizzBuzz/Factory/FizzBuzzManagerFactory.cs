using FizzBuzz.Helper;
using FizzBuzz.Interfaces;
using FizzBuzz.Managers;
using FizzBuzz.Model;

namespace FizzBuzz.Factory
{
    public class FizzBuzzManagerFactory : IFizzBuzzManagerFactory
    {
        public IFizzBuzzManager GetFizzBuzzManager(string inpNum)
        {
            IFizzBuzzManager fizzBuzzManager = null;

            if (FizzBuzzHelper.IsNumeric(inpNum))
            {
                int numerator = Int32.Parse(inpNum);
                if (numerator % Constants.Three == Constants.Zero & numerator % Constants.Five == Constants.Zero)
                {
                    fizzBuzzManager = new MultiDividerManager();
                }
                else if (numerator % Constants.Three == Constants.Zero)
                {
                    fizzBuzzManager = new ThreeDividerManager();
                }
                else if (numerator % Constants.Five == Constants.Zero)
                {
                    fizzBuzzManager = new FiveDividerManager();
                }
                else
                {
                    fizzBuzzManager = new UndividableManager();
                }
            }
            else
            {
                fizzBuzzManager = new InvalidManager();
            }
            return fizzBuzzManager;
        }
    }
}
