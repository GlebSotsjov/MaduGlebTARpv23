using System;

namespace MaduGlebTARpv23
{
    public class ScoreCounter
    {
        private int score;

        public ScoreCounter()
        {
            score = 0;
        }

        public void IncreaseScore()
        {
            score++;
        }

        public void DisplayScore()
        {
            // Shift the display further to the right
            Console.SetCursorPosition(85, 1); // Adjust the X coordinate to shift right
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════╗");
            Console.SetCursorPosition(85, 2);
            Console.WriteLine($"║  Score: {score:D3} ║");
            Console.SetCursorPosition(85, 3);
            Console.WriteLine("╚═════════════╝");
            Console.ResetColor();
        }

        public int GetScore()
        {
            return score;
        }
    }
}
