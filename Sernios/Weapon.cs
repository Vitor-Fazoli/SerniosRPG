using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sernios
{
    public class Weapon
    {
        public Weapon(bool m, int dmg,int acc,int crt,int r)
        {
            melee = m;
            damage = dmg;
            accuracy = acc;
            crit = crt;
            rare = r;
        }

        bool melee;
        int damage;
        int accuracy;
        int crit;
        int rare;

        Color Raririty()
        {
            switch (rare)
            {
                case 1:
                    return Color.White;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Blue;
                case 4:
                    return Color.Purple;
                case 5:
                    return Color.Orange;
                default:
                    return Color.White;
            }
        }
    }
}
