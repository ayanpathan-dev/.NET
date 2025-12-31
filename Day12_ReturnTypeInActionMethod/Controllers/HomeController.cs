using Microsoft.AspNetCore.Mvc;

namespace Day12_ReturnTypeInActionMethod.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        // Strongly -typed return type of Method : Generic Type<T>
        public ActionResult<int> GetNumber()
        {
            return 1111;
        }
        public ViewResult M1()
        {
            return View("~/Views/Home/About.cshtml");
        }
        
        public string GetSomething(string unm, string pwd)
        {
            return $"{unm} {pwd}";
        }

        public JsonResult GetData()
        {
            var data = new
            {
                ID = 101,
                Name = "Hugh Jackman",
                Address = "NYC"
            };
            return Json(data); // JSON
        }

        public StatusCodeResult GetStatus()
        {
            return StatusCode(404);
        }

        public ObjectResult GetObject()
        {
            var obj = new
            {
                ID = 101,
                Name = "Hugh Jackman",
                Address = "NYC"
            };
            return new ObjectResult(obj);
        }

        public EmptyResult DoNothing()
        {
            return new EmptyResult();
        }

        public async Task<ViewResult> GetResult()
        {
            await Task.Delay(3000);
            return View("~/Views/Home/GetData.cshtml");
        }

        public FileResult DownloadFile()
        {
            var byteArray = System.IO.File.ReadAllBytes(@"D:\IET_Dec_25_Batch\WebDemos\WebDemosDec25\06Demo_ReturnTypesOfActionMethod\Data\quote.pdf");

            return File(byteArray, "application/pdf", "quote.pdf");
        }
    }
}
}
