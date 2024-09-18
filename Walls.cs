using System;
using System.Collections.Generic;

namespace MaduGlebTARpv23
{
    internal class Walls
    {
        List<Figure> wallList;
        private char wallSymbol = '+'; // Символ стены
        private ConsoleColor wallColor = ConsoleColor.Red; // Цвет стены

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // Создание горизонтальных и вертикальных линий
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, wallSymbol);
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, wallSymbol);
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, wallSymbol);
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, wallSymbol);

            // Добавление линий в список стен
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            Console.ForegroundColor = wallColor; // Установка цвета консоли для стен
            foreach (var wall in wallList)
            {
                wall.Draw(); // Отрисовка стены
            }
            Console.ResetColor(); // Сброс цвета консоли
        }
    }
}
