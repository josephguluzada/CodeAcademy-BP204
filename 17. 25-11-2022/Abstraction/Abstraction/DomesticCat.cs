using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class DomesticCat : Cat
    {
        public override void MakeSound()
        {
            Console.WriteLine("Domestic cat sound: i want to eat something");
        }
    }
}
