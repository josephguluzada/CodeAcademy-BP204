using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletCapacity;
            int bulletCount;
            double dechargeTime;
            bool isAuto;
            bool check;

            Console.WriteLine("Welcome to armory");
            do
            {
                Console.WriteLine("Enter the bulletCapacity");
                check = int.TryParse(Console.ReadLine(), out bulletCapacity);
            } while (!check);

            do
            {
                Console.WriteLine("Enter the bulletCount");
                check = int.TryParse(Console.ReadLine(), out bulletCount);
            } while (!check);

            do
            {
                Console.WriteLine("Enter the dechargeTime");
                check = double.TryParse(Console.ReadLine(), out dechargeTime);
            } while (!check);
            do
            {
                Console.WriteLine("Enter the Mode");
                check = bool.TryParse(Console.ReadLine(), out isAuto);
            } while (!check);


            Console.WriteLine(bulletCapacity);
            Console.WriteLine(bulletCount);
            Console.WriteLine(dechargeTime);
            Console.WriteLine(isAuto);

            Weapon weapon = new Weapon(bulletCapacity, bulletCount,dechargeTime,isAuto);

            string choice;

            do
            {
                Console.WriteLine("Secim et:\n" +
                "1: Shoot\n" +
                "2: Fire\n" +
                "3: GetRemainBulletCount\n" +
                "4: Clear Console");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        weapon.GetRemainBulletCount();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            } while (choice != "6");
        }
    }
}