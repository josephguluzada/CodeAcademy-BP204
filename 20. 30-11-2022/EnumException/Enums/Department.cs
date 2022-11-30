using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Department
    {
        public string Name { get; set; }
        public Person[] People;

        public Department()
        {
            People = Array.Empty<Person>();
        }

        public void AddPerson(Person person)
        {
            Array.Resize(ref People, People.Length + 1);
            People[^1] = person;
        }

        //public void AddPerson(Person[] people)
        //{
        //    for (int i = 0; i < people.Length; i++)
        //    {
        //        AddPerson(people[i]);
        //    }
        //}

        public void AddPerson(params Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                AddPerson(people[i]);
            }
        }

        public void AddPerson(Person person,ref Person[] newArr)
        {
            Array.Resize(ref newArr, newArr.Length + 1);
            newArr[^1] = person;
        }

        public Person[] GetPeopleByPosition(string value)
        {
            Person[] wantedPeople = new Person[0];
            for (int i = 0; i < People.Length; i++)
            {
                if (People[i].Position.ToString().ToLower() == value.ToLower().Trim())
                {
                    AddPerson(People[i],ref wantedPeople);
                }
            }
            return wantedPeople;
        }

        public Person[] GetPeopleByPosition(int value)
        {
            Person[] wantedPeople = new Person[0];
            for (int i = 0; i < People.Length; i++)
            {
                if ((int)People[i].Position == value)
                {
                    AddPerson(People[i], ref wantedPeople);
                }
            }
            return wantedPeople;
        }
    }
}
