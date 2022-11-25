namespace HumanDoctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = null;
            human.Surname = "Eliyev";
            human.Gender = "Male";
            human.Age = -14;

            human.ShowInfo();

            //Doctor doctor = new Doctor();
            //doctor.Name = "Murad";
            //doctor.Surname = "Eliyev";
            //doctor.Gender = "Male";
            //doctor.Age = -14;
            //doctor.Speciality = "Jarrah";
            //doctor.Experience = 150;

            //doctor.ShowInfo();
        }
    }
}