using CCTV.Models;
using CCTV.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CCTV.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
                Services = _context.Services.ToList(),
            };

            return View(homeVM);
        }
    }
}