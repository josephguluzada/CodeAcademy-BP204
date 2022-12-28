using Microsoft.AspNetCore.Mvc;

namespace BB201MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id = 1000)
        {
            ViewBag.Number = 99;
            ViewData["number"] = id;
            TempData["number2"] = id;

            string name = "BB201";

            //return RedirectToAction("Detail");
            return View((object)name);
        }

        public IActionResult Detail(int id, string name)
        {
            ViewBag.Number = id + " " + name;
            return View();
        }
    }
}
