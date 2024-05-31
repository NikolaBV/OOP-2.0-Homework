using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class AK47 : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public bool ExtendedClip { get; private set; }

        public AK47(string name, bool extendedClip)
        {
            Name = name;
            AttackDamage = 50;
            BlockingPower = 5;
            ExtendedClip = extendedClip;
        }
    }
}
