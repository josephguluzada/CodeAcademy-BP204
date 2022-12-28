using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class AreaCalculator
    {
        public double Area(Figure figure)
        {
           return figure.Area();
        }

        //public double Area(object figure)
        //{
        //    double area = 0;
        //    if(figure is Triangle)
        //    {
        //        Triangle triangle = (Triangle)figure;
        //        area = (triangle.Height * triangle.Side) / 2;
        //    }else if(figure is Circle)
        //    {
        //        Circle circle = (Circle)figure;
        //        area = circle.Radius * circle.Radius * Math.PI;
        //    }

        //    return area;
        //}
    }
}
