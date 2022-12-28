using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string Fullname { get; set; }

        static Student()
        {
            _id = 0;
        }

        public Student()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Fullname: {Fullname}";
        }
    }
}
