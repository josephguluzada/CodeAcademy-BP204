using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Models
{
    internal class Teacher
    {
        private string _name;

        public string Name 
        { 
            get => _name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            }
        }
    }
}
