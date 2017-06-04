using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Arena_3
{
    class Enemy : Fighter
    {
        public int Gold { get; set; }
        public int Xp { get; set; }
        public Enemy(string name, double health, double attackMax, double armorMax,int xp, int gold)
        {
            this.Name = name;
            this.Health = health;
            this.AttackMax = attackMax;
            this.ArmorMax = armorMax;
            this.Gold = gold;
            this.Xp= xp;
        }

    }
}
