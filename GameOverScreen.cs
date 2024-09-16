using System;

namespace MaduGlebTARpv23
{
    public class GameOverScreen
    {
        // Метод для отображения экрана окончания игры
        public void DisplayGameOver(int finalScore)
        {
            Console.Clear(); // Очищаем экран перед выводом сообщения

            Console.SetCursorPosition(30, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═══════════════════════════╗");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("║       ИГРА ОКОНЧЕНА       ║");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("╚═══════════════════════════╝");

            Console.SetCursorPosition(30, 14);
            Console.WriteLine($"  Ваш счёт: {finalScore:D3}  ");

            Console.SetCursorPosition(30, 16);
            Console.WriteLine("  Нажмите 'R' для перезапуска ");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("  Нажмите 'Q' для выхода     ");

            Console.ResetColor();
        }

        // Метод для ожидания нажатия клавиши и возврата выбранного действия
        public bool HandleInput()
        {
            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.R)
                {
                    return true; // Перезапуск
                }
                else if (key == ConsoleKey.Q)
                {
                    return false; // Выход
                }
            }
        }
    }
}
