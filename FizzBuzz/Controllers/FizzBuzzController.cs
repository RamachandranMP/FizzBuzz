using Microsoft.AspNetCore.Mvc;
using FizzBuzz.Model;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzManagerFactory _fizzBuzzFactory;
        public FizzBuzzController(IFizzBuzzManagerFactory fizzBuzzFactory)
        {
            _fizzBuzzFactory = fizzBuzzFactory;
        }

        [HttpPost(Name = "GetFizzBuzz")]
        public IEnumerable<FizzBuzzModel> Post(string[] inpNumerator)
        {
            List<FizzBuzzModel> fizzBuzz = new List<FizzBuzzModel>();
            foreach (var num in inpNumerator)
            {
                IFizzBuzzManager fizzBuzzManager = _fizzBuzzFactory.GetFizzBuzzManager(num);
                fizzBuzz.Add(new FizzBuzzModel()
                {
                    Input = num,
                    Result = fizzBuzzManager.GetDivisionResult(num)
                });
            }
            return fizzBuzz;

            //IEnumerable<FizzBuzzModel> data = fizzBuzz;
            //DataTable table = new DataTable();
            //using (var reader = ObjectReader.Create(data))
            //{
            //    table.Load(reader);
            //}
            //return JsonConvert.SerializeObject(table, Formatting.Indented);
        }
    }
}