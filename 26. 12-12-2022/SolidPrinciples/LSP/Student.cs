using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Student : Person
    {
        public override byte GetAge()
        {
            Console.WriteLine("Studentin Age'i");
            return 10;
        }

        public override string GetFullname()
        {
            Console.WriteLine("Studentin Fullname");
            return "Studentin Fullname";
        }
    }
}
