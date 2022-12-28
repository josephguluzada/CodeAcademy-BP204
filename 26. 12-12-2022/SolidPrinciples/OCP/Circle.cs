using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Circle : Figure
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
