using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Dog : Animal
    {
        public bool HasCollar;

        public override void Eat()
        {
            Console.WriteLine("Eating like a dog");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hav Hav");
        }
    }
}
