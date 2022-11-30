using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Course
    {
        public string Name { get; set; }
        public Person[] People;

        public Course()
        {
            People = Array.Empty<Person>();
        }

        public void AddPerson(Person person)
        {
            Array.Resize(ref People, People.Length + 1);
            People[^1] = person;
        }

        public void AddPerson(params Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                AddPerson(people[i]);
            }
        }

        public void AddPerson(ref Person[] newArray , Person person)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[^1] = person;
        }



        public Person[] GetPeopleByPosition(string positionName)
        {
            Person[] wantedPeople = new Person[0];
            for (int i = 0; i < People.Length; i++)
            {
                if (People[i].PositionName.ToString().ToLower() == positionName.ToLower().Trim())
                {
                    AddPerson(ref wantedPeople, People[i]);
                }
            }
            return wantedPeople;
        }

        public Person[] GetPeopleByPosition(int positionNo)
        {
            Person[] wantedPeople = new Person[0];
            for (int i = 0; i < People.Length; i++)
            {
                if ((int)People[i].PositionName == positionNo)
                {
                    AddPerson(ref wantedPeople, People[i]);
                }
            }
            return wantedPeople;
        }


    }
}
