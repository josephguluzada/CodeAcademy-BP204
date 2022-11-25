using CustomLibrary;
namespace ClassLibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "yusif";
            MyCustomMathClass myCustomMathClass = new MyCustomMathClass();

            Console.WriteLine(myCustomMathClass.Sum(5, 6));

            myCustomMathClass.ShowDivide(9, 3);


        }
    }
}