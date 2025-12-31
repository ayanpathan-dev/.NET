using Microsoft.AspNetCore.Mvc;

namespace Day12_Basic_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult<int> sum(int a,int b) {
            return a + b;
        }
        public ActionResult<int> id(int c)
        {
            return c;
        }
        public string Index(string nm)
        {
            return nm;
        }
    }

}

