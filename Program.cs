using System;
using System.Threading;

namespace MaduGlebTARpv23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(110, 25);

            bool playAgain = true; // Флаг для перезапуска игры

            while (playAgain)
            {
                playAgain = StartGame(); // Запуск игры, возвращает true для перезапуска
            }

            Console.Clear(); // Очищаем экран перед завершением программы
            Console.SetCursorPosition(30, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Спасибо за игру!");
            Console.ResetColor();
            Console.ReadLine();
        }

        // Основная логика игры
        static bool StartGame()
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
                    break; // Игра окончена, выходим из цикла
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    scoreCounter.IncreaseScore(); // Увеличиваем счёт
                }
                else
                {
                    snake.Move();
                }

                scoreCounter.DisplayScore(); // Отображаем счёт
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            // Когда игра окончена, отображаем экран завершения
            GameOverScreen gameOverScreen = new GameOverScreen();
            gameOverScreen.DisplayGameOver(scoreCounter.GetScore());

            // Обрабатываем ввод: перезапуск или выход
            return gameOverScreen.HandleInput();
        }
    }
}
