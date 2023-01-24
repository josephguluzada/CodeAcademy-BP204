using Microsoft.AspNetCore.Mvc;
using Pustok.Models;
using System.Diagnostics;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}