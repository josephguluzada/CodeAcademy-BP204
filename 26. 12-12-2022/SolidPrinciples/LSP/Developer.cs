using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Developer : Person, IExperience
    {
        public override byte GetAge()
        {
            Console.WriteLine("Developerin Age'i");
            return 10;
        }

        public byte GetExperience()
        {
            Console.WriteLine("Developerin Experiences'i");
            return 10;
        }

        public override string GetFullname()
        {
            Console.WriteLine("Developerin Fullname");
            return "Developerin Fullname";
        }
    }
}
