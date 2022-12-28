using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationToBinaryXML
{
    [Serializable]
    public class Person : ISerializable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name , typeof(string));
            info.AddValue("Surname", Surname, typeof(string));
            info.AddValue("Age", Age , typeof(byte));
        }

        public Person()
        {

        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Surname = (string)info.GetValue("Surname", typeof(string));
            Age = (byte)info.GetValue("Age", typeof(byte));
        }


        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
}
