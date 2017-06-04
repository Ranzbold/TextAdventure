using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Arena_3
{
    class Game
    {

        public static void StartGame()
        {
            setCharName();
   
            
        }
        public static void setCharName()
        {
            Console.Write("Hallo Abenteurer, wie ist dein Name: ");


            PlayerStats.CharacterName = Console.ReadLine();
            Console.WriteLine("Hallo {0}", PlayerStats.CharacterName);
            Intro();
        }
        public static void Intro()
        {
            Random rdm = new Random();
            Fighter player = new Player(PlayerStats.CharacterName, 100, 15, 5,50);
            for (int i = 0; i < 3; i++)
            {
                int hp = rdm.Next(80, 120);
                int atk = rdm.Next(5, 15);
                int armor = rdm.Next(2, 10);
                Dialog("Ein Wilder Bär greift dich an!", ConsoleColor.Cyan);
                Enemy enemy = new Enemy("Bär", hp, atk, armor, 50, 50);
                Battle.StartFight(player, enemy);
                if (!Battle.winner)
                {
                    Defeat();
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                PlayerStats.Gold += enemy.Gold;
                PlayerStats.XP += enemy.Xp;
                Dialog(ConsoleColor.Green, enemy.Xp, enemy.Gold);


                Console.ReadKey();
            }
            Dialog("Erster Dungeon geschafft blub", ConsoleColor.Green);
            Console.ReadKey();
 
        }
        public static void Defeat()
        {
            Dialog("Defeat", ConsoleColor.Red);
        }
        public static void Dialog(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Dialog(ConsoleColor color, int xp, int gold)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Du erhälst {0} XP und {1} Gold",xp,gold);
            Console.WriteLine("Du hast nun insgesamt {0} XP und {1} Gold", PlayerStats.XP, PlayerStats.Gold);
            Console.ResetColor();

        }
        public static string BattleDialog(string message, ConsoleColor color, Player player)
        {
            String a;
            do
            {
                Console.WriteLine("Du hast folgende Optionen:");
                Console.WriteLine("Normaler Angriff: 1-{0} DMG : a", player.AttackMax);
                Console.WriteLine("Vampirschlag 1-{0} DMG : b", player.AttackMax + 5);
                a = Console.ReadLine();
            } while ((a != "a") && (a!= "b"));
            switch(a)
            {
                case "a": return "normal";
                case "b": return "vamp";
                default:  return "normal";
            }
                 
        }


    }
}
