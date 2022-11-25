namespace CSharpIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //while (i<=100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int j = 0;
            //do
            //{
            //    Console.WriteLine(j);
            //    j++;
            //} while (j<=100);


            //string name;

            //while (name.Length <7)
            //{
            //    Console.WriteLine("Yalnisdir,yeniden daxil edin");
            //    name = Console.ReadLine();
            //}
            //bool check = true;
            //do
            //{
            //    if (check == true) Console.Write("Enter the name: ");
            //    else Console.Write("Wrong,repeat again: ");

            //    name = Console.ReadLine();
            //    check = false;
            //} while (name.Length <7);

            //Console.WriteLine("Welcome " +name);

            //for (int i = 0, j = 0; i <= 100; i++,j--)
            //{
            //    if(i == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i + " " + j);
            //}

            int i = 0;
            for (; ;)
            {
                Console.WriteLine("Infinity loop");
                if(i == 10)
                {
                    break;
                }

                i++;
            }


        }
    }
}