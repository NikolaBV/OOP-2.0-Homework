using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Tesla : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public double BladeLength { get; private set; }

        public Tesla(string name, double bladeLength)
        {
            Name = name;
            AttackDamage = 60;
            BlockingPower = 12;
            BladeLength = bladeLength;
        }
    }
}
