using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Weapon
    {
        public int BulletCount { get; set; }
        public int BulletCapacity { get; set; }
        public int DechargeTime { get; set; }

        public void Reload()
        {
            Console.WriteLine(BulletCount = BulletCapacity);
        }
    }
}
