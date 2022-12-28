using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Teacher : Person, IExperience
    {
        public override byte GetAge()
        {
            Console.WriteLine("Teacherin Age'i");
            return 10;
        }

        public byte GetExperience()
        {
            Console.WriteLine("Teacherin  Experiences'i");
            return 10;
        }

        public override string GetFullname()
        {
            Console.WriteLine("TEacherin Fullname");
            return "Teacherin  Fullname";
        }
    }
}
