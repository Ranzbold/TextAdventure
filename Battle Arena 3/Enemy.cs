using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Arena_3
{
    class Enemy : Fighter
    {
        public double Gold { get; set; }
        public double Xp { get; set; }
        public int Level { get; set; }
        public Enemy(string name, double health, double attackMax, double armorMax,int xp, int gold, int level)
        {
            this.Level = level;
            this.Name = name;
            this.Health = EnemyUtils.calculateScaling(health,level);
            this.AttackMax = EnemyUtils.calculateScaling(attackMax, level);
            this.ArmorMax = EnemyUtils.calculateScaling(armorMax, level);
            this.Gold = EnemyUtils.calculateScaling(gold, level);
            this.Xp = EnemyUtils.calculateScaling(xp, level);

        }

    }
}
