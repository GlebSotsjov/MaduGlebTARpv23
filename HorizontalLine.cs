using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaduGlebTARpv23
{
    // Klass, mis esindab horisontaalset joont ja pärib kuju (Figure) baasklassi
    internal class HorizontalLine : Figure
    {
        // Konstruktor, mis loob horisontaalse joone kindlas asukohas
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            // Tsükkel, mis loob punkte y-koordinaadil, liikudes x-suunas vasakult paremale
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym); // Iga punkt joonistatakse määratud sümboliga
                pList.Add(p); // Lisab punkti loendisse, mis esindab kogu joont
            }
        }
    }
}
