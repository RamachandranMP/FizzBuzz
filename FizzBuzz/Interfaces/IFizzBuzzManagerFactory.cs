namespace FizzBuzz.Interfaces
{
    public interface IFizzBuzzManagerFactory
    {
        IFizzBuzzManager GetFizzBuzzManager(string inpNum);
    }
}
