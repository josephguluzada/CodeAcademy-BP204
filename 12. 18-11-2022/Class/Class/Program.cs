namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name1 = "Eli";
            //string surname1 = "Eliyev";
            //byte age1 = 18;

            //string name2 = "Elcin";
            //string surname2 = "Eliyev";
            //byte age2 = 20;

            //string[] names = { "Eli", "Elcin", "Veli", "Murad" };
            //string[] surnames = { "Eliyev", "Elcinov", "Veliyev", "Eliyev" , "Rasimov"};
            //byte[] ages = { 22, 23, 18,19 };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    //Console.WriteLine(names[i] + " " + surnames[i] + " " + ages[i]);
            //    Console.WriteLine($" Name:{names[i]} Surname:{surnames[i]} Age:{ages[i]}");
            //}

            //var student1 = new
            //{
            //    Name = "Eli",
            //    Surname = "Eliyev",
            //    Age = 18
            //};

            //var student2 = new
            //{
            //    Name = "Elcin",
            //    Surname = "Eliyev",
            //    Age = 19
            //};

            //var student3 = new
            //{
            //    Name = "Murad",
            //    Surname = "Eliyev",
            //    Age = 13,
            //    Point = 23
            //};

            //var student4 = new
            //{
            //    Name = "Murad",
            //    Surname = "Eliyev",
            //    Age = 13,
            //    Stipendiya = 33
            //};


            //Console.WriteLine(student1.Surname);

            

            //student.ShowFullName();

            Student student2 = new Student
            {
                Name = "Eli",
                Surname = "Veliyev",
                Age = 18,
                Point = 99.9,
                Grant = 156
            };

            student2.ShowFullName();

            //Student[] students = { student, student2 };

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"{students[i].Name} {students[i].Surname} {students[i].Age}");
            //}

            //foreach (Student std in students)
            //{
            //    Console.WriteLine($"{std.Name} {std.Surname} {std.Point}");
            //}
            Student student = new Student();
            student.Name = "Murad";
            student.Surname = "Eliyev";
            student.Age = 13;
            student.Point = 33.2;
            student.Grant = 0;


            Human human = new Human();
            human.Name = "Rasim";
            human.Surname = "Rasimov";
            human.Age = 71;

            Teacher teacher = new Teacher
            {
                Name = "Yusif",
                Surname= "Guluzada",
                Age = 25
            };



        }
    }

    class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
    }

    class Student : Human
    {
        public double Point;
        public double Grant;


        public void ShowFullName()
        {
            Console.WriteLine(Name +" " +  Surname);
        }
    }

    class Teacher : Human
    {
        public double Experience;
        public string Profession;
    }
}