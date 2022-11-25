namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Veli","Veliyev",89);

            //Console.WriteLine(human.Name + " " + human.Surname + " " + human.Age);
            human.ShowFullData();
            Console.WriteLine(human.GetFullData());

            Student student = new Student("Rasim","Balayev",18,90,198);

            Console.WriteLine(student.GetFullData());
            
        }
    }
}