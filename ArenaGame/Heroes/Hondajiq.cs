using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Hondajiq : Hero
    {
        public bool VtecDamage { get; private set; }

        public Hondajiq(string name, double armor, double strength, IWeapon weapon, bool vtecDamage) :
            base(name, armor, strength, weapon)
        {
            VtecDamage = vtecDamage;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            if (VtecDamage)
            {
                damage *= 1.5;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            double reducedDamage = base.Defend(damage);
            // If Vtec is engaged, reduce incoming damage by 20%
            if (VtecDamage)
            {
                reducedDamage *= 0.8;
            }
            return reducedDamage;
        }
    }
}
