using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerLesson
{
    internal class Course
    {
        public string Name { get; set; }
        private Student[] _students;

        public Student this[int index]
        {
            get
            {
                return _students[index];
            }
            set
            {
                _students[index] = value;
            }
        }

        public Student this[int index,string name]
        {
            get
            {
                return _students[index];
            }
            set
            {
                _students[index] = value;
            }
        }

        public Course()
        {
            _students = new Student[6];
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[^1] = student;
        }
    }
}
