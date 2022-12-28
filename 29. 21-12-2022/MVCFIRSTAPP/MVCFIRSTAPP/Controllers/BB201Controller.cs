using Microsoft.AspNetCore.Mvc;

namespace MVCFIRSTAPP.Controllers
{
    public class BB201Controller : Controller
    {
        public ContentResult Index()
        {
            return Content("Hello, BB201!");
        }
    }
}
