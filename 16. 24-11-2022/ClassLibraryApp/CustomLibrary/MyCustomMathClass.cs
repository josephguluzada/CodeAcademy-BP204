using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary
{
    public class MyCustomMathClass
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        internal int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public void ShowDivide(int num1, int num2)
        {
            Console.WriteLine(Divide(num1, num2));
        }

        public void ShowSum(int num1, int num2)
        {
            Console.WriteLine(Sum(num1,num2));
        }
    }
}
