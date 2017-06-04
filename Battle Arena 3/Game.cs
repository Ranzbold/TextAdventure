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
            try
            {
                Player.CharacterName = Console.ReadLine();
                Console.WriteLine("Hallo {0}",Player.CharacterName);
                Intro();
            }
            catch (Exception)
            {

                Console.WriteLine("Ein Fehler ist aufgetreten");               
            }
        }
        public static void Intro()
        {
            Random rdm = new Random();
            Fighter strolch = new Fighter(Player.CharacterName, 150, 15, 5);
            for (int i = 0; i < 3; i++)
            {
                int hp = rdm.Next(80, 120);
                int atk = rdm.Next(5, 15);
                int armor = rdm.Next(2, 10);
                Dialog("Ein Wilder Bär greift dich an!", ConsoleColor.Cyan);
                Enemy enemy = new Enemy("Bär", hp, atk, armor, 50, 50);
                Battle.StartFight(strolch, enemy);
                if (!Battle.winner)
                {
                    Defeat();
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Player.Gold += enemy.Gold;
                Player.XP += enemy.Xp;
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
            Console.WriteLine("Du hast nun insgesamt {0} XP und {1} Gold", Player.XP, Player.Gold);
            Console.ResetColor();

        }


    }
}
