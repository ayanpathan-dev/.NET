using Microsoft.AspNetCore.Mvc;

namespace Day11_MVCAttributeBasedRouting.Controllers
{
    [Route("/demo")]
    public class DemoController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("Greet")]
        public string SayHi()
        {
            return "Hello !!";
        }

        [Route("hello/{nm?}")]
        public string syahello(string nm)
        {
            return $" Hello :{nm}";
        }
    }
}
