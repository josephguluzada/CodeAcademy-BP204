using BB201MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BB201MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student1 = new Student { Id =1, Name = "Vasif", Surname="Memmedov", Age =18};
            Student student2 = new Student { Id =2, Name = "Asif", Surname="Aliyev", Age =19};
            Student student3 = new Student { Id =3, Name = "Memmed", Surname="Rustemov", Age =28};
            Student student4 = new Student { Id =4, Name = "Ceyhun", Surname="Hajili", Age =13};

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            //ViewBag.Students = students;

            return View(students);
        }

        public IActionResult Detail(int id)
        {
            Student student1 = new Student { Id = 1, Name = "Vasif", Surname = "Memmedov", Age = 18 };
            Student student2 = new Student { Id = 2, Name = "Asif", Surname = "Aliyev", Age = 19 };
            Student student3 = new Student { Id = 3, Name = "Memmed", Surname = "Rustemov", Age = 28 };
            Student student4 = new Student { Id = 4, Name = "Ceyhun", Surname = "Hajili", Age = 13 };

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            Student wantedStudent = students.FirstOrDefault(std => std.Id == id);
            if (wantedStudent is null)
            {
                return NotFound();
            }

            return View(wantedStudent);
        }
    }
}
