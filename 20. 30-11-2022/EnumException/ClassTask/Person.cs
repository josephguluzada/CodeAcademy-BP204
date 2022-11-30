using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Person
    {
        public string Fullname { get; set; }
        public Position PositionName { get; set; }



        public override string ToString()
        {
            return $"Fullname: {Fullname} Position: {PositionName}";
        }
    }
}
