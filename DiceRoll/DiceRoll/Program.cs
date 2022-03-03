using System;
using System.Collections.Generic;
namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int player2RandomNum;

            int playerPoints = 0;
            int player2Points = 0;
            int turn;

            Random random = new Random();


            for (turn = 1; turn < 11; turn++)
            {
                Console.WriteLine("SCOREBOARD \nPlayer 1: " + playerPoints + "\nPlayer 2: " + player2Points + "\n\n");
                Console.WriteLine("Turn {0} Press any key to roll your dice!", turn);
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                player2RandomNum = random.Next(1, 7);
                Console.WriteLine("AI Player rolled a " + player2RandomNum);
                

                if (playerRandomNum > player2RandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("\nPlayer 1 Scores!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (playerRandomNum < player2RandomNum)
                {
                    player2Points++;
                    Console.WriteLine("\nPlayer 2 Scores!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nThis round was a draw!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            GameWinner(playerPoints, player2Points);
        }

        private static void GameWinner(int playerPoints, int player2Points)
        {
            if (playerPoints > player2Points)
            {
                Console.WriteLine("Player 1 Score = " + playerPoints + "\nPlayer 2 Score = " + player2Points);
                Console.WriteLine("\nPlayer 1 Wins!");
            }
            else if (player2Points > playerPoints)
            {
                Console.WriteLine("Player 1 Score = " + playerPoints + "\nPlayer 2 Score = " + player2Points);
                Console.WriteLine("\nPlayer 2 Wins!");
            }
        }
    }
}
