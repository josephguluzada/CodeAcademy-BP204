using Microsoft.AspNetCore.Mvc;

namespace MVCFIRSTAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Json()
        {
            return View();
        }

        public ActionResult GetHtml()
        {
            return View();
        }
    }
}
