using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class StudentList
    {
        public Student[] Students = new Student[0];


        public void Add(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public int Count()
        {
            return Students.Length;
        }

        public Student FindByIndex(int index)
        {
            return Students[index];
        }


        //public void Add(params Student[] students)
        //{
        //    foreach (Student std in students)
        //    {
        //        Add(std);
        //    }
        //}
    }
}
