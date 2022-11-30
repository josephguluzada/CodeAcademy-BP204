using ExceptionProject.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject
{
    internal class Student
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length >=3)
                {
                    _name = value;
                }
                else
                {
                    throw new InvalidNameLengthException("Adin uzunlugu 3 ve ya daha cox olmalidir!");
                }
            }
        }
        public byte Age { get; set; }
    }
}
