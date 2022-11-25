using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Student : Human
    {

        public Student(string name,string surname, byte age): base(name,surname,age)
        {
        }

        public Student(string name, string surname, byte age, double point) : this(name,surname,age)
        {
            this.Point = point;
        }

        public Student(string name, string surname, byte age, double point, double grant) : this(name, surname, age,point)
        {
            this.Grant = grant;
        }



        public double Point;
        public double Grant;

        public void ShowFullData()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age} {this.Point} {this.Grant}");
        }

        public string GetFullData()
        {
            return $"{this.Name} {this.Surname} {this.Age} {this.Point} {this.Grant}";
        }
    }
}
