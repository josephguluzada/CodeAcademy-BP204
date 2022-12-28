using _28122022.Models;
using _28122022.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _28122022.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 10, Name ="Rehim", Age = 19, TeacherId = 1},
                new Student { Id = 18, Name ="Rehman", Age = 17, TeacherId = 2},
                new Student { Id = 690, Name ="Rahib", Age = 18, TeacherId = 1},
                new Student { Id = 10089, Name ="Revan", Age = 16, TeacherId = 3}
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher{Id = 1, Name = "Sefer", Experience = 10},
                new Teacher{Id = 2, Name = "Rasim", Experience = 8},
                new Teacher{Id = 3, Name = "Vahid", Experience = 18}
            };

            //ViewBag.Teachers = teachers;

            HomeViewModel homeVM = new HomeViewModel
            {
                Students = students,
                Teachers = teachers
            };
            return View(homeVM);
        }
    }
}
