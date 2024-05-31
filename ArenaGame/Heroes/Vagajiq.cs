using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Vagajiq : Hero
    {
        public int SmokeDamage { get; private set; }

        public Vagajiq(string name, double armor, double strength, IWeapon weapon, int smokeDamage) :
            base(name, armor, strength, weapon)
        {
            SmokeDamage = smokeDamage;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            return damage + SmokeDamage;
        }

        public override double Defend(double damage)
        {
            double reducedDamage = base.Defend(damage);
            if (SmokeDamage > 0)
            {
                reducedDamage *= 0.9;
            }
            return reducedDamage;
        }
    }
}
