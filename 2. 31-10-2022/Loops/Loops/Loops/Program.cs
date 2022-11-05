namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1den 10a kimi olan reqemler arasinda cut olanlarin cemini tapan algorithm

            //int sum = 0;
            //int i = 1;

            //while (i<10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //}

            //Console.WriteLine("Cem : " + sum);



            // 1den 10a kimi olan reqemler arasinda tek olanlarin cemini tapan algorithm

            //int sum = 0;

            //for(int i = 1; i < 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine("Cem : " + sum);

            //string name;
            //do
            //{
            //    Console.WriteLine("Adiniz daxil edin:");
            //    name = Console.ReadLine();

            //} while (name.Length <= 4);

            //int i = 1;

            //while (i<10)
            //{
            //    if(i == 5)
            //    {
            //        Console.WriteLine("tapdim " +  i);
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}


            int j = 1;


            while (j<10)
            {
                if(j == 7)
                {
                    Console.WriteLine("Tapdim: " + j);
                    break;
                }
                j++;
            }






        }
    }
}