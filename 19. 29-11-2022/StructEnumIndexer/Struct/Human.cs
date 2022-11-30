using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal struct Human  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Human(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }


    interface IPerson
    {
        public byte Age { get; set; }
    }
}
