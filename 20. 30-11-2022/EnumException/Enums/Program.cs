namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Fullname = "Eli Ekberov";
            person1.Position = Position.Boss;

            Person person2 = new Person();
            person2.Fullname = "Jeyhun Ferzullayev";
            person2.Position = Position.Engineer;

            Person person3 = new Person();
            person3.Fullname = "Fehmin Huseynov";
            person3.Position = Position.Engineer;

            Person person4 = new Person();
            person4.Fullname = "Ravi Ceferli";
            person4.Position = Position.Employee;

            Person person5 = new Person();
            person5.Fullname = "Maryam Xanmedova";
            person5.Position = Position.Employee;

            Person person6 = new Person();
            person6.Fullname = "Ulvi Adilov";
            person6.Position = Position.Employee;

            Department department = new Department();
            department.Name = "BB201";

            Person[] people = new Person[] { person1, person2, person3, person4, person5, person6 };

            department.AddPerson(people);

            Person[] wantedPeople =  department.GetPeopleByPosition(2);

            if(wantedPeople.Length > 0)
            {
                foreach (Person person in wantedPeople)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Axtardigin position adini ve ya reqemini duzgun daxil edin:");
            }


        }
    }
}