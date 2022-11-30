namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;

            Console.WriteLine(num1.Add(10));
            Console.WriteLine(num1.MultiplyByTen());

            string name = "muRaD"; // Murad
            Console.WriteLine(name.ToCapitalize());

            string str = "eleKbeRRRR";
            Console.WriteLine(str.ToCapitalize());

        }
    }
}