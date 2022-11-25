using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Contructor
{
    internal class Teacher
    {
        public Teacher()
        {

        }
        public Teacher(string name)
        {
            this.Name = name;
        }

        public Teacher(string name,string surname) : this(name)
        {
            this.Surname = surname;
        }



        public string Name;
        public string Surname;
        public byte Age;
        public string Profession;
        public double Salary;
    }
}
