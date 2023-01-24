using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pustok.Helpers;
using Pustok.Models;
using System.Reflection;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BookController : Controller
    {
        private readonly PustokContext _pustokContext;
        private readonly IWebHostEnvironment _env;

        public BookController(PustokContext pustokContext, IWebHostEnvironment env)
        {
            _pustokContext = pustokContext;
            _env = env;
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


            if(book.PosterImageFile != null)
            {
                if (book.PosterImageFile.ContentType != "image/png" && book.PosterImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("PosterImageFile", "You can only upload png or jpeg");
                    return View();
                }

                if (book.PosterImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("PosterImageFile", "You can only upload image size lower than 2mb");
                    return View();
                }

                BookImage bookImage = new BookImage
                {
                    Book = book,
                    ImageUrl = book.PosterImageFile.SaveFile(_env.WebRootPath, "uploads/books"),
                    IsPoster = true
                };

                _pustokContext.BookImages.Add(bookImage);
            }

            if (book.HoverImageFile != null)
            {
                if (book.HoverImageFile.ContentType != "image/png" && book.HoverImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("HoverImageFile", "You can only upload png or jpeg");
                    return View();
                }

                if (book.HoverImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("HoverImageFile", "You can only upload image size lower than 2mb");
                    return View();
                }
                
                BookImage bookImage = new BookImage
                {
                    Book = book,
                    ImageUrl = book.HoverImageFile.SaveFile(_env.WebRootPath, "uploads/books"),
                    IsPoster = false
                    
                };

                _pustokContext.BookImages.Add(bookImage);
            }

            // Multiple ImageFiles
            if (book.ImageFiles != null)
            {
                foreach (IFormFile imageFile in book.ImageFiles)
                {
                    if (imageFile.ContentType != "image/png" && imageFile.ContentType != "image/jpeg")
                    {
                        ModelState.AddModelError("ImageFiles", "You can only upload png or jpeg");
                        return View();
                    }

                    if (imageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("ImageFiles", "You can only upload image size lower than 2mb");
                        return View();
                    }

                    BookImage bookImage = new BookImage
                    {
                        Book = book,
                        ImageUrl = imageFile.SaveFile(_env.WebRootPath, "uploads/books"),
                        IsPoster = null
                    };

                    _pustokContext.BookImages.Add(bookImage);
                }
            }

            _pustokContext.Books.Add(book);
            _pustokContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            ViewBag.Authors = new SelectList(_pustokContext.Authors.ToList(), "Id", "Fullname");
            ViewBag.Categories = _pustokContext.Categories.ToList();
            Book book = _pustokContext.Books
                            .Include(b => b.BookImages)            
                            .FirstOrDefault(x=> x.Id == id);

            if (book is null) return View("Error");

            return View(book);
        }

        [HttpPost]
        public IActionResult Update(Book book)
        {
            ViewBag.Authors = new SelectList(_pustokContext.Authors.ToList(), "Id", "Fullname");
            ViewBag.Categories = _pustokContext.Categories.ToList();

            Book existBook = _pustokContext.Books
                                .Include(b => b.BookImages)
                                .FirstOrDefault(x => x.Id == book.Id);
            if (existBook is null) return View("Error");

            //PropertyInfo[] destination = existBook.GetType().GetProperties();
            //PropertyInfo[] source = book.GetType().GetProperties();

            //for (int i = 0; i < destination.Length; i++)
            //{
            //    destination[i].SetValue(existBook, source[i].GetValue(book));
            //}

            existBook.BookImages.RemoveAll(bi => !book.BookImageIds.Contains(bi.Id) && bi.IsPoster == null);

            if(book.ImageFiles != null)
            {
                foreach (var imageFile in book.ImageFiles)
                {
                    if (imageFile.ContentType != "image/png" && imageFile.ContentType != "image/jpeg")
                    {
                        ModelState.AddModelError("ImageFiles", "You can only upload png or jpeg");
                        return View();
                    }

                    if (imageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("ImageFiles", "You can only upload image size lower than 2mb");
                        return View();
                    }

                    BookImage bookImage = new BookImage
                    {
                        BookId = book.Id,
                        ImageUrl = imageFile.SaveFile(_env.WebRootPath, "uploads/books"),
                        IsPoster = null
                    };

                    existBook.BookImages.Add(bookImage);
                }
            }

            existBook.Name = book.Name;
            existBook.Costprice = book.Costprice;
            existBook.SalePrice = book.SalePrice;
            existBook.DiscountPrice = book.DiscountPrice;
            existBook.Desc = book.Desc;
            existBook.IsAvailable = book.IsAvailable;
            existBook.AuthorId = book.AuthorId;
            existBook.CategoryId = book.CategoryId;

            _pustokContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Book book = _pustokContext.Books.FirstOrDefault(x => x.Id == id);
            if (book is null) return NotFound(); // 404

            _pustokContext.Books.Remove(book);
            _pustokContext.SaveChanges();

            return Ok(); // 200
        }
    }
}
