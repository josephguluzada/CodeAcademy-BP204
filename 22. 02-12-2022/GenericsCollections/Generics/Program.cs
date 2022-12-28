namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new();
            Student student2 = new();
            Student student3 = new();
            student1.Fullname = "Murad Eliyev";
            student2.Fullname = "Jeyhun Hajili";
            student3.Fullname = "Fehmin Huseynov";

            CustomList<Student> customList = new CustomList<Student>();
            customList.Add(student1);
            customList.Add(student2);
            customList.Add(student3);

            foreach (Student std in customList.Values)
            {
                Console.WriteLine(std);
            }
            Console.WriteLine(customList.Count());

            Console.WriteLine(customList.FindByIndex(1));


            CustomList<Student> customList1 = new CustomList<Student>();
           


            //StudentList studentList = new();

            //studentList.Add(student1);
            //studentList.Add(student2);
            //studentList.Add(student3);

            //foreach (var item in studentList.Students)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(studentList.Count());

            //Student std = studentList.FindByIndex(0);
            //Console.WriteLine(std);
        }
    }
}