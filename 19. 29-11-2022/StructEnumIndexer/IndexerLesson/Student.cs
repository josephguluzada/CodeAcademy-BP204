using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerLesson
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public double Point { get; set; }


        public override string ToString()
        {
            return $"Id: {Id} Full Name: {FullName} Point: {Point}";
        }
    }
}
