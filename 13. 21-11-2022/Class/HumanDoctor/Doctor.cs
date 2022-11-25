using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanDoctor
{
    internal class Doctor : Human
    {
        private double _experience;
        public string Speciality = null!;


        public double Experience 
        {
            get => _experience;
            set 
            {
                if(value >0 && value < 65) _experience = value;
            } 
        }

        public string GetInfo()
        {
            return $"{this.Name} {this.Surname} {this.Gender} {this.Age} {this.Speciality} {this.Experience}";
        }

        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }
}
