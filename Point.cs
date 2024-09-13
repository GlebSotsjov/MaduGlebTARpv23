using MaduGlebTARpv23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaduGlebTARpv23
{
    internal class Point
    {
        // Koordinaadid ja sümbol, mis tähistab punkti
        public int x;
        public int y;
        public char sym;

        // Tühi konstruktor, mida saab kasutada vajadusel ilma väärtuste määramiseta
        public Point()
        {
        }

        // Konstruktor, mis määrab punkti koordinaadid ja sümboli
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        // Kopeeriv konstruktor, mis loob uue punkti teise punkti põhjal
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        // Liigutab punkti etteantud suunas ja nihkega
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset; // Liigub paremale
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset; // Liigub vasakule
            }
            else if (direction == Direction.UP)
            {
                y = y - offset; // Liigub üles
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset; // Liigub alla
            }
        }

        // Kontrollib, kas kaks punkti kattuvad (tabavad üksteist)
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        // Joonistab punkti konsoolile
        public void Draw()
        {
            Console.SetCursorPosition(x, y); // Määrab kursori positsiooni
            Console.Write(sym); // Joonistab punkti sümboli
        }

        // Kustutab punkti konsoolilt, asendades selle tühikuga
        public void Clear()
        {
            sym = ' '; // Muudab sümboli tühikuks
            Draw(); // Joonistab punkti uuesti, et see kaoks ekraanilt
        }

        // Ülekirjutatud meetod ToString, mis tagastab punkti koordinaadid ja sümboli
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
