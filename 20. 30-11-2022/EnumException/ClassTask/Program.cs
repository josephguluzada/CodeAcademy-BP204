namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Fullname = "Eli Ekberov";
            person1.PositionName = Position.Teacher;

            Person person2 = new Person();
            person2.Fullname = "Jeyhun Ferzullayev";
            person2.PositionName = Position.Teacher;

            Person person3 = new Person();
            person3.Fullname = "Fehmin Huseynov";
            person3.PositionName = Position.Teacher;

            Person person4 = new Person();
            person4.Fullname = "Ravi Ceferli";
            person4.PositionName = Position.Student;

            Person person5 = new Person();
            person5.Fullname = "Maryam Xanmedova";
            person5.PositionName = Position.Student;

            Person person6 = new Person();
            person6.Fullname = "Ulvi Adilov";
            person6.PositionName = Position.Student;

            Person[] people = { person1, person2, person3, person4, person5, person6 };
            Course course = new Course();

            course.AddPerson(people);


            foreach (Person person in course.GetPeopleByPosition("     StUdENT    "))
            {
                Console.WriteLine(person);
            }

        }
    }
}