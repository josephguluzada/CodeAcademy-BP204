using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Models;
using Pustok.ViewModels;

namespace Pustok.Controllers
{
    public class BookController : Controller
    {
        private readonly PustokContext _pustokContext;

        public BookController(PustokContext pustokContext)
        {
            _pustokContext = pustokContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            Book book = _pustokContext.Books
                            .Include(x=>x.Author)
                            .Include(x=>x.Category)
                            .Include(x=>x.BookImages)
                            .FirstOrDefault(x => x.Id == id);

            if (book == null) return View("Error");

            BookViewModel bookVM = new BookViewModel
            {
                Book = book,
                Books = _pustokContext.Books
                            .Include(x => x.Author)
                            .Include(x => x.Category)
                            .Include(x => x.BookImages)
                            .Where(x => x.DiscountPrice>0).ToList()
            };

            return View(bookVM);
        }
    }
}
