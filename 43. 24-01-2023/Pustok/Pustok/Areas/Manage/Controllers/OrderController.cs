using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Models;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles ="SuperAdmin,Admin")]
    public class OrderController : Controller
    {
        private readonly PustokContext _pustokContext;

        public OrderController(PustokContext pustokContext)
        {
            _pustokContext = pustokContext;
        }

        public IActionResult Index()
        {
            List<Order> orders = _pustokContext.Orders.ToList();
            return View(orders);
        }

        public IActionResult Detail(int id)
        {
            Order order = _pustokContext.Orders.Include(x => x.OrderItems).FirstOrDefault(x=>x.Id == id);
            if (order == null) return View("Error");


            return View(order);
        }

        public IActionResult Accept(int id)
        {
            Order order = _pustokContext.Orders.FirstOrDefault(x => x.Id == id);
            if (order == null) return View("Error");

            order.OrderStatus = Enums.OrderStatus.Accepted;

            _pustokContext.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Reject(int id)
        {
            Order order = _pustokContext.Orders.FirstOrDefault(x => x.Id == id);
            if (order == null) return View("Error");

            order.OrderStatus = Enums.OrderStatus.Rejected;

            _pustokContext.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
