using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Glock18 : Weapon, IAutomaticWeapon, ISingleWeapon
    {
        public void Fire()
        {
            BulletCount = 0;
        }

        public void Shoot()
        {
            BulletCount -= 1;
        }
    }
}
