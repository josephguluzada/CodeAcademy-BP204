namespace BigO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int counter = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    counter++;
            //    if (numbers[i] == input)
            //    {
            //        Console.WriteLine("axtarilan eded " + i + " indexdedir. Addim sayi: " + counter);
            //        break;
            //    }
            //}

            int[] numbers = {1,6,16,19,22,36,67,89,120,150,200,271,299,301,304,400};
            int input = 150;// axtarilan eded
            int min = 0; // minimum index
            int max = numbers.Length-1; // maximum index
            int counter = 0;
            int mid = default(int);  // orta hisse

            while (min <= max)
            {
                counter++;
                mid = (max + min) / 2;

                if (numbers[mid] == input)
                {
                    Console.WriteLine("axtarilan eded " + mid + " indexdedir.Addim sayi: " + counter);
                    break;
                }
                else if (numbers[mid] > input)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }





        }
    }
}