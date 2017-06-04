using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Arena_3
{
    public abstract class Fighter
    {
        public string Name { get; set; } = "Fighter";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double ArmorMax { get; set; } = 0;

        Random rdm = new Random();
        public Fighter(string name = "Warrior", double health = 0, double attackMax = 0, double armorMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            ArmorMax = armorMax;
        }
        public double Attack()
        {
            return rdm.Next(1, (int)AttackMax);
        }
        public double Mitigate()
        {
            return rdm.Next(1, (int)ArmorMax);
        }
    }
}
