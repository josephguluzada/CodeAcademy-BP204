using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface IEnginable
    {
        double LBS { get; set; }
        double FuelCapacity { get; set; }

        void AddFuel(double fuel);
    }
}
