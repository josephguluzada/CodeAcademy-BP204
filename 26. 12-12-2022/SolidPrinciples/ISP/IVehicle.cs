using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
       
        void Drive();
    }
}
