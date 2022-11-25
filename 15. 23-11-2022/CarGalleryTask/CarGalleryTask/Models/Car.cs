using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGalleryTask.Models
{
    internal class Car
    {
        private static int _counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Speed { get; set; }
        public string CarCode { get; private set; }


        public Car(string name)
        {
            _counter++;
            this.Name = name;
            this.Id = _counter;
            this.CarCode = name.Substring(0, 2).ToUpper() + (1000 + Id);
        }
    }
}
