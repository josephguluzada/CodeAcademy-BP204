namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person developer = new Developer();
            developer.GetFullname();
            developer.GetAge();
            //developer.GetExperience();

            Person teacher = new Teacher();
            teacher.GetFullname();
            teacher.GetAge();
            //teacher.GetExperience();

            Person student = new Student();
            student.GetFullname();
            student.GetAge();
            //student.GetExperience();


        }
    }
}