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
        // Koordinaadid ja s�mbol, mis t�histab punkti
        public int x;
        public int y;
        public char sym;

        // T�hi konstruktor, mida saab kasutada vajadusel ilma v��rtuste m��ramiseta
        public Point()
        {
        }

        // Konstruktor, mis m��rab punkti koordinaadid ja s�mboli
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        // Kopeeriv konstruktor, mis loob uue punkti teise punkti p�hjal
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
                y = y - offset; // Liigub �les
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset; // Liigub alla
            }
        }

        // Kontrollib, kas kaks punkti kattuvad (tabavad �ksteist)
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        // Joonistab punkti konsoolile
        public void Draw()
        {
            Console.SetCursorPosition(x, y); // M��rab kursori positsiooni
            Console.Write(sym); // Joonistab punkti s�mboli
        }

        // Kustutab punkti konsoolilt, asendades selle t�hikuga
        public void Clear()
        {
            sym = ' '; // Muudab s�mboli t�hikuks
            Draw(); // Joonistab punkti uuesti, et see kaoks ekraanilt
        }

        // �lekirjutatud meetod ToString, mis tagastab punkti koordinaadid ja s�mboli
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
