using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMathLibrary
{
    public class CustomMath
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sum(int num1, int num2,int num3)
        {
            return num1 + num2 + num3;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public void ShowDivide(int num1, int num2)
        {
            Console.WriteLine(Divide(num1,num2));
        }

       
    }
}
