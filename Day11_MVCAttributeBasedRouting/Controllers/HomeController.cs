using Microsoft.AspNetCore.Mvc;

namespace Day11_MVCAttributeBasedRouting.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        //[Route("")]
        //[Route("/Home")]
        //[Route("/Home/Index")]
        //[Route("~/")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        
    }
}
