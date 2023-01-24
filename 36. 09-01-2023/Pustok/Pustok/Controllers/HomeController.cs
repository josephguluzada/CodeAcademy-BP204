﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    }
}