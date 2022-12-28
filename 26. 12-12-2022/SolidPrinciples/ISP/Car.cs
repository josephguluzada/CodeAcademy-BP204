using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Car : IVehicle , IEnginable
    {
        public string Brand { get ; set ; }
        public string Model { get; set; }
        public double LBS { get; set; }
        public double FuelCapacity { get; set; }

        public void AddFuel(double fuel)
        {
            Console.WriteLine("Add Fuel");
        }

        public void Drive()
        {
            Console.WriteLine("Drive");
        }
    }
}
