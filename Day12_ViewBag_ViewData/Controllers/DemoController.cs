using Day12_ViewBag_ViewData.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day12_ViewBag_ViewData.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            // Key-value: Dynamic type
            ViewBag.message = "This is the way!";

            Emp emp = new Emp() { Id = 101, Name = "Tom Ellis", Address = "London" };
            ViewBag.empInfo = emp;

            ViewData["number"] = 12345;

            Emp emp1 = new Emp() { Id = 102, Name = "Tom Hanks", Address = "LA" };
            ViewData["emp1"] = emp1;

            TempData["PIN"] = 223344;

            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
