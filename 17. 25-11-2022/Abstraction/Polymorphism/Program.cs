namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "Eli";
            human.Surname = "Eliyev";
            human.Age = 19;
            human.ShowFullData();

            Teacher teacher = new Teacher();
            teacher.Name = "Veli";
            teacher.Surname = "VEliyev";
            teacher.Age = 29;
            teacher.Experience = 7;
            teacher.ShowFullData();

            Student student = new Student();
            student.Name = "Rasim";
            student.Surname = "Balayev";
            student.Age = 16;
            student.Point = 78;
            student.ShowFullData();


            Human human1 = student; // new Student();
            human1.ShowFullData();

            Human human2 = teacher;
            human2.ShowFullData();
        }
    }
}