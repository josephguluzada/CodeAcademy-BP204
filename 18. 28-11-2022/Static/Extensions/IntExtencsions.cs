using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class IntExtencsions
    {
        public static int Add(this int num1, int num2)
        {
            return num1 + num2;
        }

        public static int MultiplyByTen(this int num1)
        {
            return num1 * 10;
        }
    }
}
