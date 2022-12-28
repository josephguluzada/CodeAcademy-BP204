using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class CustomList<T> where T : class , new()
    {
        public T[] Values = new T[0];


        public void Add(T value)
        {
            Array.Resize(ref Values, Values.Length + 1);
            Values[Values.Length - 1] = value;
        }

        public int Count()
        {
            return Values.Length;
        }

        public T FindByIndex(int index)
        {
            return Values[index];
        }
    }
}
