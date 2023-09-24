using System;
using role_games;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)



        {
            Menu();
        }

        static void Play(Personnaly myPlayer)


        {

            Monster monster = new Monster("Wedragona");
            bool victory = true;
            bool next = false;

            while (!monster.IsDead())

                {

                // Tour du monstre 
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                monster.Attack(myPlayer);
                Console.WriteLine();
                Console.ReadKey(true);

                if (myPlayer.IsDead())
                {
                    victory = false;
                    break;
                }
                // Tour du personnage
                Console.ForegroundColor = ConsoleColor.Green;
                myPlayer.Attack(monster);
                Console.WriteLine();
                Console.ReadKey(true);

                if (victory)
                {
                    myPlayer.experienceWin(5);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine();
                    Console.WriteLine(myPlayer.Features());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();

                    while(!next)
                    {
                        Console.WriteLine("Next Room ? (O/N) ");
                        string touch = Console.ReadLine().ToUpper();

                        if (touch == "O")
                        {
                            next = true;
                            Play(myPlayer);
                        }
                        else if (touch == "N")
                        {
                            Environment.Exit(0);
                        }
                    }
                }

                else
                {

                    myPlayer.experienceWin(5);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine();
                    Console.WriteLine("It's lost...");
                    Console.ReadKey();
                }
            }
           


        }


        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The Dark Game");
            Console.WriteLine();
            Console.WriteLine("Choose your class : ");
            Console.WriteLine("1. The Warrior");
            Console.WriteLine("2. The Sorcerer");
            Console.WriteLine("2. The Archer");
            Console.WriteLine("4. Exit");
            Console.WriteLine();


            switch (Console.Read())
            {
                case '1': // Utilisez des caractères simples (apostrophes) pour les valeurs de caractères
                    Console.WriteLine("You chose the warrior !!");
                    Console.WriteLine();
                    Play(new Warrior("Pentiminax"));
                    break; // N'oubliez pas de mettre des "break" pour sortir du switch après chaque cas.

                case '2':
                    Console.WriteLine("You chose the Sorcerer !!");
                    Console.WriteLine();
                    Play(new Sorcerer("Pentiminax"));
                    break;

                case '3':
                    Console.WriteLine("You chose the Archer !!");
                    Console.WriteLine();
                    Play(new Archer("Pentiminax"));
                    break;

                case '4':
                    break;

                default:
                    Console.WriteLine("Invalid choice"); // Gérez le cas où l'utilisateur entre une valeur non valide.
                    break;
            }



        }
    }
}