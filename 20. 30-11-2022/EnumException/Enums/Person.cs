using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Person
    {
        public string Fullname { get; set; }
        public byte Age { get; set; }
        public Position Position { get; set; } // Boss, Engineer, Employee




        public override string ToString()
        {
            return $"Fullname: {Fullname} - Position: {Position}";
        }
    }
}
