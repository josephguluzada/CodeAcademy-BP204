using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pustok.Models;
using System.Reflection;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BookController : Controller
    {
        private readonly PustokContext _pustokContext;

        public BookController(PustokContext pustokContext)
        {
            _pustokContext = pustokContext;
        }

        public IActionResult Index()
        {
            return View(_pustokContext.Books.ToList());
        }

        public IActionResult Create()
        {
            //ViewBag.Authors = _pustokContext.Authors.ToList();
            ViewBag.Authors = new SelectList(_pustokContext.Authors.ToList(), "Id", "Fullname");
            ViewBag.Categories = _pustokContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            ViewBag.Authors = new SelectList(_pustokContext.Authors.ToList(), "Id", "Fullname");
            ViewBag.Categories = _pustokContext.Categories.ToList();
            if (!ModelState.IsValid) return View();

            _pustokContext.Books.Add(book);
            _pustokContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            ViewBag.Authors = _pustokContext.Authors.ToList();
            ViewBag.Categories = _pustokContext.Categories.ToList();
            Book book = _pustokContext.Books.FirstOrDefault(x=> x.Id == id);

            if (book is null) return View("Error");

            return View(book);
        }

        [HttpPost]
        public IActionResult Update(Book book)
        {
            Book existBook = _pustokContext.Books.FirstOrDefault(x => x.Id == book.Id);
            if (existBook is null) return View("Error");

            PropertyInfo[] destination = existBook.GetType().GetProperties();
            PropertyInfo[] source = book.GetType().GetProperties();

            for (int i = 0; i < destination.Length; i++)
            {
                destination[i].SetValue(existBook, source[i].GetValue(book));
            }

            //existBook.Name = book.Name;
            //existBook.Costprice = book.Costprice;
            //existBook.SalePrice = book.SalePrice;
            //existBook.DiscountPrice = book.DiscountPrice;
            //existBook.Desc = book.Desc;
            //existBook.IsAvailable = book.IsAvailable;
            //existBook.AuthorId = book.AuthorId;
            //existBook.CategoryId = book.CategoryId;

            _pustokContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
