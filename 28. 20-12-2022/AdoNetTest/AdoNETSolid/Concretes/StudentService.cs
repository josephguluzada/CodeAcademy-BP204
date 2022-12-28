using AdoNETSolid.Abstracts;
using AdoNETSolid.Models;
using System.Data;

namespace AdoNETSolid.Concretes
{
    public class StudentService : IService<Student>
    {
        public void Create(Student model)
        {
            int check = SQLManager.Execute($"INSERT INTO Students VALUES ('{model.Fullname}', {model.Age}, {model.Grant},{model.GroupId})");
            if (check > 0) Console.WriteLine("Inserted!");
            else Console.WriteLine("Error!");
        }

        public void Delete(int id)
        {
            int check = SQLManager.Execute($"DELETE FROM Students WHERE Id = {id}");
            if (check > 0) Console.WriteLine("Deleted!");
            else Console.WriteLine("Error!");
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();

            var datas = SQLManager.ReadAll("SELECT * FROM Students");

            foreach (DataRow row in datas.Rows)
            {
                students.Add(new Student { Id = Convert.ToInt32(row[0]), Fullname = row[1].ToString(), Age = Convert.ToInt32(row[2]), Grant = Convert.ToDecimal(row[3]), GroupId = Convert.ToInt32(row[4]) });
            }

            return students;
        }
    }
}
