using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Arena_3
{
    class Battle
    {
        public static bool winner;
        public static void StartFight(Fighter player, Fighter enemy)
        {
            while(true)
            {
                System.Threading.Thread.Sleep(1000);
                if(GetAttackResult(player, enemy) == "gameover")
                {
                    Console.WriteLine("Game Over");
                    winner = true;
                    break;
                }
                if (GetAttackResult(enemy, player) == "gameover")
                {
                    Console.WriteLine("Game Over");
                    winner = false;
                    break;
                }
            }

        }
        public static string GetAttackResult(Fighter fighterA, Fighter fighterB)
        {
            double fighterADmg = fighterA.Attack();
            double fighterBMit = fighterB.Mitigate();

            double dmg2FighterB = fighterADmg - fighterBMit;

            if (dmg2FighterB > 0)
            {
                fighterB.Health = fighterB.Health - dmg2FighterB;
            }
            else dmg2FighterB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                fighterA.Name,fighterB.Name,dmg2FighterB);

            Console.WriteLine("{0} Has {1} Health \n", fighterB.Name, fighterB.Health);

            if (fighterB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorius \n",
                    fighterB.Name, fighterA.Name);
                return "gameover";
            }
            else return "continue";
        }


    }
}
