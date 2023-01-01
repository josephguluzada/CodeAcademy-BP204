using _29122022.Models;
using _29122022.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _29122022.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _dataContext;
        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = _dataContext.Sliders.ToList()
            };


            return View(homeViewModel);
        }
    }
}