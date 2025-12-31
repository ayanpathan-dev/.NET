using Microsoft.AspNetCore.Mvc;

namespace Day12_Basic_MVC.Controllers
{
    public class demo : Controller
    {
        public string Index(string nm)
        {
            return nm;
        }

    }
}
