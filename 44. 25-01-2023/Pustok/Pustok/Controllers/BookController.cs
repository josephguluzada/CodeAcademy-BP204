﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pustok.Models;
using Pustok.ViewModels;
using System.Reflection;

namespace Pustok.Controllers
{
    public class BookController : Controller
    {
        private readonly PustokContext _pustokContext;
        private readonly UserManager<AppUser> _userManager;

        public BookController(PustokContext pustokContext, UserManager<AppUser> userManager)
        {
            _pustokContext = pustokContext;
            _userManager = userManager;
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


        public async Task<IActionResult> AddToBasket(int bookId)
        {
            if (!_pustokContext.Books.Any(x => x.Id == bookId)) return NotFound(); // 404

            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            BasketItemViewModel basketItem = null;
            AppUser member = null;
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                member = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            }
            string basketItemsStr = HttpContext.Request.Cookies["BasketItems"];

            if(member == null)
            {
                if (basketItemsStr != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);

                    basketItem = basketItems.FirstOrDefault(x => x.BookId == bookId);

                    if (basketItem != null) basketItem.Count++;
                    else
                    {
                        basketItem = new BasketItemViewModel
                        {
                            BookId = bookId,
                            Count = 1
                        };
                        basketItems.Add(basketItem);
                    }
                }
                else
                {
                    basketItem = new BasketItemViewModel
                    {
                        BookId = bookId,
                        Count = 1
                    };

                    basketItems.Add(basketItem);
                }
                basketItemsStr = JsonConvert.SerializeObject(basketItems);

                HttpContext.Response.Cookies.Append("BasketItems", basketItemsStr);
            }
            else
            {
                BasketItem memberBasketItem = _pustokContext.BasketItems.FirstOrDefault(x => x.AppUserId == member.Id && x.BookId == bookId);

                if(memberBasketItem != null)
                {
                    memberBasketItem.Count++;
                }
                else
                {
                    memberBasketItem = new BasketItem
                    {
                        AppUserId = member.Id,
                        BookId = bookId,
                        Count = 1
                    };

                    _pustokContext.BasketItems.Add(memberBasketItem);
                }
                await _pustokContext.SaveChangesAsync();
            }

            return Ok(); // 200
        }

        public IActionResult GetBasketItems()
        {
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            string basketItemsStr = HttpContext.Request.Cookies["BasketItems"];

            if(basketItemsStr != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);
            }

            return Json(basketItems);
        }

        public async Task<IActionResult> Checkout()
        {
            AppUser member = null;
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                member = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            }
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            List<CheckoutItemViewModel> checkoutItems = new List<CheckoutItemViewModel>();
            CheckoutItemViewModel checkoutItem = null;
            List<BasketItem> memberBasketItems = null;
            OrderViewModel orderViewModel = null;
            string basketItemsStr = HttpContext.Request.Cookies["BasketItems"];

            if(member == null)
            {
                if (basketItemsStr != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);

                    foreach (var item in basketItems)
                    {
                        checkoutItem = new CheckoutItemViewModel
                        {
                            Book = _pustokContext.Books.FirstOrDefault(x => x.Id == item.BookId),
                            Count = item.Count
                        };
                        checkoutItems.Add(checkoutItem);
                    }
                }
            }
            else
            {
                memberBasketItems = _pustokContext.BasketItems.Include(x=>x.Book).Where(x => x.AppUserId == member.Id).ToList();

                foreach (var item in memberBasketItems)
                {
                    if (!item.IsDeleted)
                    {
                        checkoutItem = new CheckoutItemViewModel
                        {
                            Book = item.Book,
                            Count = item.Count
                        };
                        checkoutItems.Add(checkoutItem);
                    }
                }

            }

            orderViewModel = new OrderViewModel
            {
                CheckoutItemViewModels = checkoutItems,
                FullName = member?.FullName,
                Email = member?.Email,
                Phone = member?.PhoneNumber
            };

            return View(orderViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Order(OrderViewModel orderVM)
        {
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            List<CheckoutItemViewModel> checkoutItems = new List<CheckoutItemViewModel>();
            CheckoutItemViewModel checkoutItem = null;
            List<BasketItem> memberBasketItems = null;
            OrderItem orderItem = null;
            double totalPrice = 0;
            string basketItemsStr = HttpContext.Request.Cookies["BasketItems"];
            //if (!ModelState.IsValid) return View();
            AppUser member = null;
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                member = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            }
            Order order = null;

            order = new Order
            {
                FullName = orderVM.FullName,
                Country = orderVM.Country,
                Adress = orderVM.Adress,
                City = orderVM.City,
                Email = orderVM.Email,
                Note = orderVM.Note,
                Phone = orderVM.Phone,
                ZipCode = orderVM.ZipCode,
                OrderStatus = Enums.OrderStatus.Pending,
                CreateDate = DateTime.UtcNow.AddHours(4),
                AppUserId = member?.Id
                //AppUserId = (member != null ? member.Id : null)
            };

            if (member == null)
            {
                if (basketItemsStr != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);

                    foreach (var item in basketItems)
                    {
                        Book book = _pustokContext.Books.FirstOrDefault(x => x.Id == item.BookId);
                        orderItem = new OrderItem
                        {
                            Book = book,
                            BookName = book.Name,
                            CostPrice = book.Costprice,
                            DiscountPrice = book.DiscountPrice,
                            SalePrice = (book.SalePrice * (1 - (book.DiscountPrice / 100))),
                            Count = item.Count,
                            Order = order
                        };
                        totalPrice += orderItem.SalePrice* orderItem.Count;
                        order.OrderItems.Add(orderItem);
                    }
                }
            }
            else
            {
                memberBasketItems = _pustokContext.BasketItems.Include(x => x.Book).Where(x => x.AppUserId == member.Id).ToList();

                foreach (var item in memberBasketItems)
                {
                    Book book = _pustokContext.Books.FirstOrDefault(x => x.Id == item.BookId);
                    orderItem = new OrderItem
                    {
                        Book = book,
                        BookName = book.Name,
                        CostPrice = book.Costprice,
                        DiscountPrice = book.DiscountPrice,
                        SalePrice = (book.SalePrice * (1 - (book.DiscountPrice / 100))),
                        Count = item.Count,
                        Order = order
                    };
                    totalPrice += orderItem.SalePrice * orderItem.Count;
                    order.OrderItems.Add(orderItem);
                }
            }
            order.TotalPrice = totalPrice;

            _pustokContext.Orders.Add(order);
            _pustokContext.SaveChanges();

            return RedirectToAction("index", "Home");
        }
    }
}