using _29122022.Models;
using Microsoft.AspNetCore.Mvc;

namespace _29122022.Areas.Manage.Controllers;

[Area("Manage")]
public class ServiceController : Controller
{
    private readonly DataContext _dataContext;

    public ServiceController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public IActionResult Index()
    {
        List<Service> services = _dataContext.Services.ToList();

        return View(services);
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Service service)
    {
        if (!ModelState.IsValid) return View();

        _dataContext.Services.Add(service);
        _dataContext.SaveChanges();

        return RedirectToAction("index");
    }

    public IActionResult Update(int id)
    {
        Service service = _dataContext.Services.Find(id);

        if (service is null) return NotFound();

        return View(service);
    }

    [HttpPost]
    public IActionResult Update(Service newService)
    {
        Service existService = _dataContext.Services.Find(newService.Id);

        if(existService is null) return NotFound();

        existService.Title = newService.Title;
        existService.Icon = newService.Icon;
        existService.Desc = newService.Desc;

        _dataContext.SaveChanges();

        return RedirectToAction("Index");
    }
}
