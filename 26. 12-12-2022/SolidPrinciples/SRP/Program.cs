namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Elekber";
            string password = "Murad123";

            UserChecker checker = new UserChecker();
            User user = new User();

            if (checker.CheckUsername(username))
            {
                user.Username = username;
            }

            if (checker.CheckPassword(password))
            {
                user.Password = password;
            }

            UserCRUD userCRUD = new UserCRUD();

            userCRUD.Create(user);
            userCRUD.Create(new User { Username = "Jeyhun", Password = "Jeyhun123" });


            foreach (User item in userCRUD.GetAll())
            {
                Console.WriteLine(item.Username +" " + item.Password);
            }

            Console.WriteLine("=============================");
            userCRUD.Delete(user);

            foreach (User item in userCRUD.GetAll())
            {
                Console.WriteLine(item.Username + " " + item.Password);
            }
        }
    }
}