using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanDoctor
{
    internal class Human
    {
        private sbyte _age;


        private string _name;
        public string Surname;
        public string Gender;


        public sbyte Age 
        {
            get => _age;
            set 
            { 
                if(value > 0 && value < 150) _age = value;
            } 
        }

        public string Name 
        { 
            get => _name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length > 2)
                {
                    _name = value;
                }
            }
        }



        public string GetInfo()
        {
            return $"{this.Name} {this.Surname} {this.Gender} {this.Age}";
        }

        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }
}
