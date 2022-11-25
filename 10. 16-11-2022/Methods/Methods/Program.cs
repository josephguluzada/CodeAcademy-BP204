namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string humanName = "Elekber";

            //PrintNameChars(humanName);
            //Test();
            int result = Sum(5, 3);

            result += 5;

            Console.WriteLine(Reverse("Deli"));

            //Console.WriteLine(result);
            //Combine("Ravi", "derse bax");

            int[] numbers = { 1, 2, 3,6,7,8,10,56,32 };
            //PrintAllNumbersToConsole(5,6,7,9);
            PrintAllNumbersToConsole(8,3,4,56);
            Sum(6, 7);

            Sum(6,7);

            Console.WriteLine(Divide(5));
        }

        // ReturnType olmayan, Parameteri olmayan

        static void Print()
        {
            Console.WriteLine("Hello,BB201");
        }
        static void Test()
        {
            Print();
        }

        // ReturnType olmayan, Parameteri olan

        static void Combine(string word1, string word2)
        {
            Console.WriteLine(word1 + " " + word2);
        }

        // ReturnType olan, Parameteri olmayan

        static int ReturnZero()
        {
            return 0;
        }

        // ReturnType olan, Parameteri olan
        //static int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        static string Reverse(string name)
        {
            string reversedName = String.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversedName += name[i];
            }
            return reversedName;
        }

        static void PrintNameChars(string name)
        {
            if (name.Length > 5)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    Console.WriteLine(name[i]);
                }
            }
            else
            {
                Console.WriteLine("Problem");
            }
        }

        static void PrintAllNumbersToConsole(int number, params int[] array)
        {
            Console.WriteLine("Int value: " + number);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static double Sum(double num1, double num2=0)
        {
            return num1 + num2;
        }

        static double Sum(double num1, int num2)
        {
            return num1 + num2;
        }

        static double Sum(int num2 , double num1)
        {
            return num1 + num2;
        }

        static int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        static int Sum(int num1, int num2, int num3=0 , int num4=0)
        {
            return num1 + num2 + num3 + num4;
        }


        static double Divide(double num1, double num2 = 1)
        {
            return num1 / num2;
        }

    }
}