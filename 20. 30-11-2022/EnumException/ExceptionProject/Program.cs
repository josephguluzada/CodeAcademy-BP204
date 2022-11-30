using ExceptionProject.Exceptions;

namespace ExceptionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Enter the first number: ");
            //    int number1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter the second number: ");
            //    int number2 = Convert.ToInt32(Console.ReadLine());

            //    int number3 = number1 / number2;
            //    Console.WriteLine(number3);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0 daxil etmeyin!");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Eded daxil edin!");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Byten limitini kecdiniz!");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen xeta!");
            //}

            //Console.WriteLine("Elave eded daxil edin:");
            //Console.ReadLine();

            Student student = new Student();

            try
            {
                student.Name = "El";
            }
            catch (InvalidNameLengthException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {

                Console.WriteLine("Bilinmeyen xeta!");
            }
        }
    }
}