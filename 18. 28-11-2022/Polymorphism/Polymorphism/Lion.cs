using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Lion : Cat , IWildAnimal
    {
        public void Destroy()
        {
            Console.WriteLine("Destroy like lion");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Lion sound");
        }
    }
}
