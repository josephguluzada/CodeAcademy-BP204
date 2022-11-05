namespace Array__BigO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };
            //int[] numbers4 = { 1, 2, 3, 4, 5 };

            //int[] numbers3 =  new int[5] {1, 2, 3, 4, 5 };

            //Console.WriteLine(numbers3[2]);


            //Console.WriteLine(numbers3[3]);

            //int sum = 0;
            //for (int i = 0; i < numbers3.Length; i++)
            //{
            //    sum += numbers3[i];
            //}

            //Console.WriteLine(sum);

            //Console.WriteLine(numbers3[numbers3.Length-1]);

            //string[] names = new string[] { "Ekber", "Elekber", "Eli" };

            //Console.WriteLine(names[0]);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i] == "Eli")
            //    {
            //        Console.WriteLine("Eli tapildi");
            //        break;
            //    }
            //}


            // Verilmis arraydaki tek ededlerin ceminin cut ededlerin cemine nisbetini hesablayan algorithm

            //int[] numbersArr = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            //double sumOfEvens = 0;
            //double sumOfOdds = 0;
            //double result = 0;

            //for (int i = 0; i < numbersArr.Length; i++)
            //{
            //    if (numbersArr[i] % 2 == 0)
            //    {
            //        sumOfEvens += numbersArr[i];
            //    }
            //    else
            //    {
            //        sumOfOdds += numbersArr[i];
            //    }
            //}

            //result = sumOfOdds / sumOfEvens;

            //Console.WriteLine("Result: " + result);


            //int[] numbers2 = { 1, 2, 3 } ;

            //Console.WriteLine(numbers2.Rank);


            int n = 49;
            bool check = false;
            int counter = 0;
            if(n == 0 || n == 1)
            {
                Console.WriteLine("ne sade ne murekkebdir");
            }

            if(n == 2 )
            {
                Console.WriteLine("Sade ededdir");
            }

            for (int i = 2; i*i <= n; i++)
            {
                counter++;
                if(n % i == 0)
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine("eded murekkebdir");
            }
            else
            {
                Console.WriteLine("Sadedir");
            }

            Console.WriteLine("Dongu sayi: " + counter);

        }
    }
}