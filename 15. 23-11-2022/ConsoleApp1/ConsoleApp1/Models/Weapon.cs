using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Weapon
    {

        public Weapon(int bulletcapacity, int bulletCount, double dechargeTime,bool isAuto )
        {
            this.Bulletcapacity = bulletcapacity;
            this.BulletCount = bulletCount;
            this.DechargeTime = dechargeTime;
            this.IsAuto = isAuto;
        }
        public int Bulletcapacity { get; set; } // daragimizin tutumu
        public int BulletCount { get; set; } // hal-hazirda gulle sayi
        public double DechargeTime { get; set; } // daragin umumi gullelerini bosalma saniyesi
        public bool IsAuto { get; set; } // avtomatik/tekli modu

        public void Shoot() // tek atis
        {
            Console.WriteLine("Atis edildi: dish");
            // mentiqler
        }
        public void Fire() // coxlu atis
        {
            Console.WriteLine("Atisler edildi: dish*6");
            // mentiqler
        }

        public int GetRemainBulletCount() // tam dolmasi ucun gulle sayini tapan
        {
            Console.WriteLine("5 gulle");
            // mentiq
            return 0;
        }

        public void Reload() // tam dolduran method
        {
            Console.WriteLine("Reload olundu");
            //mentiq
        }

        public void ChangeFireMode() // modu deyisen method(a/t)
        {
            Console.WriteLine("Mod deyisildi");
            //mentiq
        }

    }
}
