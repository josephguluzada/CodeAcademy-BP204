namespace IndexerLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                Id = 1,
                FullName = "Jeyhun Hajili",
                Point = 77
            };

            //Console.WriteLine(student1);

            Student student2 = new Student
            {
                Id = 2,
                FullName = "Murad Aliyev",
                Point = 55
            };

            Student student3 = new Student
            {
                Id = 3,
                FullName = "Eli Efendiyev",
                Point = 99
            };

            Student student4 = new Student
            {
                Id = 4,
                FullName = "4cu Telebe",
                Point = 99
            };

            Course course = new Course();
            course.Name = "BB201";

            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);
            Console.WriteLine(course[6]);
            Console.WriteLine(course[7]);

            course[0] = student4;

            Console.WriteLine(course[0]);

            Console.WriteLine();
        }
    }
}