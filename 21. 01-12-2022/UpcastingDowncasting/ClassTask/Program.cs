using ClassTask.Models;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student1 = new Student();
            student1.Name = "Eli";
            Person student2 = new Student();
            student2.Name = "Veli";
            Person student3 = new Student();
            student3.Name = "Pirveli";

            Person teacher1 = new Teacher();
            teacher1.SurName = "Guliyev";
            Person teacher2 = new Teacher();
            teacher2.SurName = "Guluzada";
            Person teacher3 = new Teacher();
            teacher3.SurName = "Aliyev";

            Person[] people = { student1, student2, student3, teacher1, teacher2, teacher3 };

            foreach (Person person in people)
            {
                if(person is Teacher teacher)
                {
                    Console.WriteLine(teacher.SurName);
                }
                if (person is Student student)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
    }
}