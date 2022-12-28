using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class TeacherList
    {
        public Teacher[] Teachers = new Teacher[0];


        public void Add(Teacher student)
        {
            Array.Resize(ref Teachers, Teachers.Length + 1);
            Teachers[Teachers.Length - 1] = student;
        }

        public int Count()
        {
            return Teachers.Length;
        }

        public Teacher FindByIndex(int index)
        {
            return Teachers[index];
        }
    }
}
