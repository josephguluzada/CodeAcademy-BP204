namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Console.WriteLine(user1.Id);

            User user2 = new User();
            Console.WriteLine(user2.Id);

            string password = "salam";
            Console.WriteLine(User.CheckPassword(password));

        }
    }
}