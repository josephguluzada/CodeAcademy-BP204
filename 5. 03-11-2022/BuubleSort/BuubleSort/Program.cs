namespace BuubleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 223,412,3, 2, 1, 6, 4, 15, 13, 23, 21,0 ,21};
            int counter = 0;
            // Bubble sort

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = 0; k < numbers.Length-1-i; k++)
                {
                counter++;
                    if (numbers[k] > numbers[k + 1])
                    {
                        int temp = numbers[k];
                        numbers[k] = numbers[k + 1];
                        numbers[k + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Dovr sayi: " + counter);
        }
    }
}