using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaduGlebTARpv23
{
    internal class Walls
    {
        // Seinaelementide loend, mis hoiab mänguvälja seinte kujundeid
        List<Figure> wallList;

        // Konstruktor, mis loob mänguvälja seinad
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // Ülemine horisontaalne sein
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            // Alumine horisontaalne sein
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            // Vasak vertikaalne sein
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            // Parem vertikaalne sein
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            // Lisame kõik seinad loendisse
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        // Kontrollib, kas kujund (näiteks madu) põrkab vastu seina
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

        // Joonistab kõik seinad ekraanile
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
