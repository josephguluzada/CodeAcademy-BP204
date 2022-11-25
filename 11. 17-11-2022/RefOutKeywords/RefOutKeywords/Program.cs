namespace RefOutKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            //int b = a;
            //b = 9;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //ChangeValueRef(ref a);
            ChangeValueOut(out a);

            Console.WriteLine("After method: " + a);

            //int[] numbers1 = { 1, 2, 3, 4, 5, 6, };
            //int[] numbers2 = { 1, 2, 3, 4, 5, 6, };
            //int[] numbers2 = numbers1;
            //numbers2[0]l = 60;
            //numbers1[numbers1.Length - 1] = 100;

            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    Console.WriteLine(numbers1[i]);
            //}
            //Console.WriteLine("=====================================");
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}
        }

        static void ChangeValueRef(ref int b)
        {
            b = 50;
            Console.WriteLine("From method: " + b);
        }

        static void ChangeValueOut(out int b)
        {
            b = 90;
            Console.WriteLine("From method: " + b);
        }

    }
}