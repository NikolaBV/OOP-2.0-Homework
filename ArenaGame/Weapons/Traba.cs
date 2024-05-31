using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Traba : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public string Type { get; private set; }

        public Traba(string name, string type)
        {
            Name = name;
            AttackDamage = 40;
            BlockingPower = 8;
            Type = type;
        }
    }
}
