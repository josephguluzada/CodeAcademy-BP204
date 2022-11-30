using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cheetah : Cat, IWildAnimal
    {
        public int Speed { get; set; } = 100;

        public void Destroy()
        {
            Console.WriteLine("Destroy like cheetah");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cheetah sound" + " " + Speed);
        }
    }
}
