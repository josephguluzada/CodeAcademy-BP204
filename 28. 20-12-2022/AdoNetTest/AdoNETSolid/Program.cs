using AdoNETSolid.Concretes;
using AdoNETSolid.DAL;
using AdoNETSolid.Models;

namespace AdoNETSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Fullname = "Ulvi Adilov";
            student.Age = 11;
            student.GroupId = 2;
            student.Grant = 1000;


            StudentService studentService = new StudentService();

            //studentService.Create(student);

            //studentService.Delete(10);

            //List<Student> students = studentService.GetAll();

            //foreach (Student std in students)
            //{
            //    Console.WriteLine(std);
            //}

            //AddStudent();

            //Student std = GetbyId(2);

            //Console.WriteLine(std);

            foreach (var item in GetAll())
            {
                Console.WriteLine(item);
            }
        }

        public static void AddStudent()
        {
            AppDbContext context = new AppDbContext();


            context.Students.Add(new Student { Fullname = "Entity Framework Core",Age= 7, Grant = 100000, GroupId= 1});
            context.SaveChanges();
        }

        public static Student GetbyId(int id)
        {
            AppDbContext context = new AppDbContext();
            Student student = context.Students.FirstOrDefault(std => std.Id == id);

            if (student == null) throw new NullReferenceException();

            return student;
        }

        public static List<Student> GetAll()
        {
            AppDbContext context = new AppDbContext();
            return context.Students.ToList();
        }
    }
}