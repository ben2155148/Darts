using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string y_n = "";
            while (y_n != "n")
            {

                Console.WriteLine("Welcome to Darts!\nSelect a game: ");
                string[] games = { "501", "301", "end" };
                printGames(games);

                string game_select = Console.ReadLine();
                Console.WriteLine();

                int p1_score = 0;
                int p2_score = 0;
                int player_turn = 1;

                switch (game_select)
                {
                    case "1":
                        {
                            Console.WriteLine("Game 501 Selected!");
                            p1_score = 501;
                            p2_score = 501;
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Game 301 Selected!");
                            p1_score = 301;
                            p2_score = 301;
                            break;
                        }
                }

                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("Let the game begin!");

                string[] dart_scores = new string[3];

                while (p1_score != 0 && p2_score != 0)
                {
                    Console.WriteLine("Player " + player_turn + ", enter your dart scores!");

                    Console.Write("Dart 1: ");
                    dart_scores[0] = Console.ReadLine(); 

                    Console.Write("Dart 2: ");
                    dart_scores[1] = Console.ReadLine();

                    Console.Write("Dart 3: ");
                    dart_scores[2] = Console.ReadLine();


                    if (player_turn == 1)
                    {
                        p1_score = Calculate_Score(dart_scores, p1_score);
                        Console.WriteLine("Player 1 Score: " + p1_score);
                        player_turn = 2;
                        Console.WriteLine();
                    }
                    else if (player_turn == 2)
                    {
                        p2_score = Calculate_Score(dart_scores, p2_score);
                        Console.WriteLine("Player 2 Score: " + p2_score);
                        player_turn = 1;
                        Console.WriteLine();
                    }
                }
                if (p1_score == 0)
                {
                    Console.WriteLine("Player 1 wins!\nPlay again?");
                }
                else if (p2_score == 0)
                {
                    Console.WriteLine("Player 2 wins!\nPlay again?");
                }
                y_n = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public static void printGames(string[] games)
        {
            for (int i = 1; i < games.Length; i++)
            {
                Console.WriteLine(i + ". " + games[i - 1]);
            }
        }

        public static int Calculate_Score(string[] dart_scores, int score)
        {
            int temp = score;
            for (int i = 0; i < dart_scores.Length; i++)
            {
                temp = temp - Int32.Parse(dart_scores[i]);
            }

            if (temp < 0)
            {
                Console.WriteLine("Bust!");
                temp = score;
            }

            return temp;
        }
    }
}
