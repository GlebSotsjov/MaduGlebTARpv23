using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaduGlebTARpv23
{
    // Klass, mis esindab vertikaalset joont, kasutades kuju (Figure) baasklassi
    internal class VerticalLine : Figure
    {
        // Konstruktor, mis loob vertikaalse joone kindlas asukohas
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();

            // Tsükkel, mis loob punkte x-koordinaadil, liikudes y-suunas üles- või allapoole
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym); // Iga punkt joonistatakse määratud sümboliga
                pList.Add(p); // Lisatakse loendisse, mis esindab kogu joont
            }
        }
    }
}
