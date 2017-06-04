using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Arena_3
{
    class Player : Fighter
    {
        public double Mana { get; set; }

        public Player(string name = "Warrior", double health = 0, double attackMax = 0, double armorMax = 0, double mana = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            ArmorMax = armorMax;
            Mana = mana;
        }

    }
}
