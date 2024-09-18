using System;
using System.Threading;

namespace MaduGlebTARpv23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(110, 25);

            ScoreDatabase scoreDatabase = new ScoreDatabase();
            bool playAgain = true;

            while (playAgain)
            {
                // Отображаем меню
                MenuScreen menuScreen = new MenuScreen();
                string playerName = menuScreen.DisplayMenu();

                if (!string.IsNullOrEmpty(playerName))
                {
                    // Запускаем игру
                    playAgain = StartGame(playerName, scoreDatabase);
                }
                else
                {
                    playAgain = false;
                }
            }

            // Выводим самый высокий рекорд
            var highScore = scoreDatabase.GetHighScore();
            Console.Clear();
            Console.SetCursorPosition(30, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Наивысший рекорд: {highScore.playerName} с {highScore.score} очками.");
            Console.ResetColor();
            Console.ReadLine();
        }

        static bool StartGame(string playerName, ScoreDatabase scoreDatabase)
        {
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '#');
            Point food = foodCreator.CreateFood();
            food.Draw();

            ScoreCounter scoreCounter = new ScoreCounter();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    scoreCounter.IncreaseScore();
                }
                else
                {
                    snake.Move();
                }

                scoreCounter.DisplayScore();
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            GameOverScreen gameOverScreen = new GameOverScreen();
            gameOverScreen.DisplayGameOver(scoreCounter.GetScore());

            // Сохранение результата в базу данных
            scoreDatabase.SaveScore(playerName, scoreCounter.GetScore());

            return gameOverScreen.HandleInput();
        }
    }
}
