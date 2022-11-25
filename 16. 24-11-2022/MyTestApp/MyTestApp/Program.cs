using CustomLibrary;

namespace MyTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCustomMathClass myCustomMathClass = new MyCustomMathClass();

            myCustomMathClass.ShowDivide(81, 9);
            myCustomMathClass.Sum(8, 7);
            myCustomMathClass.ShowSum(9, 7);
        }
    }
}