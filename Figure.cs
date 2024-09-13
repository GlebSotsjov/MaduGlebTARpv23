using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaduGlebTARpv23
{
    internal class Figure
    {
        // Loend punktidest, mis kujundit (näiteks madu, seina jne) moodustavad
        protected List<Point> pList;

        // Joonistab kõik punktid, mis kuuluvad kujundi juurde
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw(); // Iga punkt kutsub oma enda joonistusmeetodi
            }
        }

        // Kontrollib, kas antud kujund põrkub teise kujundiga
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p)) // Kontrollib, kas kujundis olev punkt on tabanud teise kujundi mõnda punkti
                    return true;
            }
            return false;
        }

        // Kontrollib, kas konkreetne punkt on tabanud kujundit
        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point)) // Kui mõni kujundi punkt kattub antud punktiga, tagastab true
                    return true;
            }
            return false;
        }
    }
}
