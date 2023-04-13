using System;
using Bowling_Game;

namespace Bowling_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var bowlingGame = new BowlingGame();

            bowlingGame.Roll(4);
            bowlingGame.Roll(4);
            Console.WriteLine("Score: " + bowlingGame.Score());

            var bowlingGame1 = new BowlingGame();
            bowlingGame1.Roll(4);
            bowlingGame1.Roll(6);
            bowlingGame1.Roll(5);
            bowlingGame1.Roll(0);
            Console.WriteLine("Score: " + bowlingGame1.Score());

            var bowlingGame2 = new BowlingGame();
            bowlingGame2.Roll(10);
            bowlingGame2.Roll(5);
            bowlingGame2.Roll(4);
            Console.WriteLine("Score: " + bowlingGame2.Score());

            var bowlingGame3 = new BowlingGame();
            bowlingGame3.Roll(10);
            bowlingGame3.Roll(10);
            bowlingGame3.Roll(10);
            Console.WriteLine("Score: " + bowlingGame3.Score());

            Console.ReadLine();
        }
    }
}
