using Tools;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the username: ");
            string username = Console.ReadLine();

            string password;

            do
            {
                Console.WriteLine("Enter the password: ");
                password = Console.ReadLine();
            } while (!Helpers.CheckPassword(password));

            User user = new User(username, password);

            Console.WriteLine($"Id: {user.Id} Username: {user.Username} Password: {user.Password} ");
        }
    }
}