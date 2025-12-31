using System.Diagnostics;
using Day11_ModelAndView1stDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day11_ModelAndView1stDemo.Controllers
{
    public class HomeController : Controller
    {
        // Action Method
        public IActionResult Index()
        {
            return View();
        }
    }
}
