using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Cat : Animal
    {
        public bool IsWild;

        public override void Eat()
        {
            Console.WriteLine("Eating like a cat");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miyav Miyav");
        }
    }
}
