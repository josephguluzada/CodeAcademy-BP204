using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pustok.Models;
using Pustok.ViewModels;
using System.Diagnostics;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokContext _pustokContext;

        public HomeController(PustokContext pustokContext)
        {
            _pustokContext = pustokContext;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _pustokContext.Sliders.OrderBy(x=>x.Order).ToList(),
                FeaturedBooks = _pustokContext.Books.Include(x=>x.Author).Include(x=>x.BookImages).Where(x=>x.IsFeatured).ToList(),
                NewBooks = _pustokContext.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x => x.IsNew).ToList(),
                DiscountedBooks = _pustokContext.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x => x.DiscountPrice>0).ToList()
            };
            return View(homeVM);
        }

        public IActionResult SetSession(int id)
        {
            HttpContext.Session.SetString("UserId", id.ToString());

            return Content("Added Session");
        }

        public IActionResult GetSession()
        {
            string userId = HttpContext.Session.GetString("UserId");

            return Content(userId);
        }

        public IActionResult RemoveSession()
        {
            HttpContext.Session.Remove("UserId");

            return RedirectToAction("Index");
        }

        public IActionResult Test()
        {
            return PartialView("_BasketPartialView");
        }
        public IActionResult SetCookie(int id)
        {
            List<int> ids = new List<int>();
            string idsStr = HttpContext.Request.Cookies["BookIds"];

            if(idsStr != null)
            {
                ids = JsonConvert.DeserializeObject<List<int>>(idsStr);
            }
            ids.Add(id);

            idsStr = JsonConvert.SerializeObject(ids);

            HttpContext.Response.Cookies.Append("BookIds",idsStr);

            return Content("Added cookie");
        }

        public IActionResult GetCookie()
        {
            List<int> ids = new List<int>();

            string idsStr = HttpContext.Request.Cookies["BookIds"];

            if(idsStr != null)
            {
                ids = JsonConvert.DeserializeObject<List<int>>(idsStr);
            }

            return Json(ids);
        }
    }
}