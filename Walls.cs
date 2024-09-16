using System;
using System.Collections.Generic;

namespace MaduGlebTARpv23
{
    internal class Walls
    {
        List<Figure> wallList;
        private Pixel wallPixel = new Pixel('+', ConsoleColor.Red); // Красные стены

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, wallPixel.Symbol);
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, wallPixel.Symbol);
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, wallPixel.Symbol);
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, wallPixel.Symbol);

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
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
