namespace BP204_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var number = 24;

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine(number + " ededi cutdur");
            //}
            //else
            //{
            //    Console.WriteLine(number + " ededi tekdir");
            //}

            //var age = 17;

            //if (age > 18)
            //{
            //    Console.WriteLine("qebul olundunuz");
            //}
            //else if(age == 18)
            //{
            //    Console.WriteLine("Tebrikler,qebul oldunuz");
            //}
            //else
            //{
            //    Console.WriteLine("Yasiniz catmir");
            //}

            #region Switch
            //var choice = 8;
            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Bazar ertesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Cersenbe Axsami");
            //        break;
            //    case 3:
            //        Console.WriteLine("Cersenbe");
            //        break;
            //    case 4:
            //        Console.WriteLine("Cume Axsami");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cume");
            //        break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("Hefte sonu");
            //        break;
            //    default:
            //        Console.WriteLine("Bele hefte gunu yoxdur");
            //        break;
            //}
            #endregion

            var number = 0;

            if(number == 0)
            {
                Console.WriteLine("eded 0a beraberdir");
            }
            else if (number > 0)
            {
                Console.WriteLine("Eded musbetdir");
            }
            else
            {
                Console.WriteLine("Eded menfidir");
            }

        }
    }
}