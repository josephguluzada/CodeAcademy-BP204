using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializationToBinaryXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Name = "Salam";
            //person.Surname = "Aliyev";
            //person.Age = 70;

            //SerializeToBinary(person);

            //Person person1 = DeserializeToPerson();

            //Console.WriteLine(person1);

            Person person2 = new Person();
            person2.Name = "Jeyhun";
            person2.Surname = "Hacili";
            person2.Age = 7;


            //SerializeToXML(person2);

            Person person3 = DeserializeFromXML();
            Console.WriteLine(person3);

        }

        public static void SerializeToBinary(Person person)
        {
            string path = "C:\\Users\\asus\\Desktop\\Person.dat";
            Stream stream = new FileStream(path, FileMode.Create);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, person);
        }

        public static Person DeserializeToPerson()
        {
            string path = "C:\\Users\\asus\\Desktop\\Person.dat";
            Stream stream = new FileStream(path, FileMode.Open);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            var data = (Person)binaryFormatter.Deserialize(stream);

            return data;
        }

        public static void SerializeToXML(Person person)
        {
            string path = "C:\\Users\\asus\\Desktop\\Person.xml";
            Stream stream = new FileStream(path, FileMode.Create);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            xmlSerializer.Serialize(stream, person);
        }

        public static Person DeserializeFromXML()
        {
            string path = "C:\\Users\\asus\\Desktop\\Person.xml";
            Stream stream = new FileStream(path, FileMode.Open);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            var data =  (Person)xmlSerializer.Deserialize(stream);

            return data;
        }

    }
}