namespace FizzBuzz.Helper
{
    public class FizzBuzzHelper
    {
        public static bool IsNumeric(string numerator)
        {
            if (!string.IsNullOrEmpty(numerator) && int.TryParse(numerator, out _))
            {
                return true;
            }
            return false;
        }
    }
}
