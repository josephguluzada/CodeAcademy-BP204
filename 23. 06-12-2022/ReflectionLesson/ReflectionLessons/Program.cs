using ReflectionLessons.Models;
using System.Reflection;

namespace ReflectionLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            //var type1 = typeof(Student);
            Student student = new();
            student.Name = "Murad Dayan daa ";

            foreach (Type type in assembly.GetTypes())
            {
                if(type == typeof(Student))
                {
                    Console.WriteLine("Type: ");
                    Console.WriteLine("\t" + type.Name);
                    //Console.WriteLine("Propety: ");
                    //foreach (PropertyInfo property in type.GetProperties())
                    //{
                    //    Console.WriteLine("\t" + property.Name);
                    //}

                    Console.WriteLine("Field: ");
                    foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static))
                    {
                        if(field.Name == "_id")
                        {
                            field.SetValue(student, 99);
                        }

                        Console.WriteLine("\t" + field.Name + "   " + field.GetValue(student));
                    }

                    //Console.WriteLine("Method: ");
                    //foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
                    //{
                    //    Console.WriteLine("\t" + method);
                    //}
                }
            }



        }
    }
}