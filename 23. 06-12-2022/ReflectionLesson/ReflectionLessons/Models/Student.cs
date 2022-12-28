using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLessons.Models
{
    public class Student
    {
        private int _id;
        public static int Counter;
        public int Id { 
            get => _id;
            set
            {
                _id = value;
            }
        }
        public string Name { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Hello, BB201");
        }
    }
}
