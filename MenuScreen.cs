using System;

namespace MaduGlebTARpv23
{
    public class MenuScreen
    {
        public string DisplayMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════╗");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("║            ЗМЕЙКА          ║");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("╚════════════════════════════╝");

            Console.SetCursorPosition(30, 14);
            Console.WriteLine("  Нажмите 'Enter' чтобы начать");

            Console.SetCursorPosition(30, 16);
            Console.WriteLine("  Введите ваше имя: ");
            Console.SetCursorPosition(30, 17);
            Console.ResetColor();

            // Считывание никнейма игрока
            string playerName = Console.ReadLine();

            // Очищаем экран после того, как игрок ввел имя и нажал Enter
            Console.Clear();

            return playerName;
        }
    }
}
