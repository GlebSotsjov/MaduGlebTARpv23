using MaduGlebTARpv23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaduGlebTARpv23
{
    internal class Snake : Figure
    {
        // Suund, kuhu madu liigub
        Direction direction;

        // Konstruktor, mis loob mao kindla pikkusega ja määratud suunaga
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();

            // Loome mao, liikudes sabast mööda keha edasi
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction); // Liigub igas iteratsioonis etteantud suunas
                pList.Add(p); // Lisame punktid, mis moodustavad mao keha
            }
        }

        // Meetod, mis liigutab madu edasi
        public void Move()
        {
            Point tail = pList.First(); // Võtame esimese punkti (saba)
            pList.Remove(tail); // Eemaldame saba
            Point head = GetNextPoint(); // Leiame uue pea
            pList.Add(head); // Lisame uue pea loendisse

            tail.Clear(); // Kustutame saba ekraanilt
            head.Draw(); // Joonistame uue pea ekraanile
        }

        // Leiab järgmise punkti, kuhu madu liigub
        public Point GetNextPoint()
        {
            Point head = pList.Last(); // Võtame praeguse pea
            Point nextPoint = new Point(head); // Loome uue punkti, mis on pea kloon
            nextPoint.Move(1, direction); // Liigutame uue punkti edasi praeguses suunas
            return nextPoint;
        }

        // Kontrollib, kas madu on oma sabaga kokku põrganud
        public bool IsHitTail()
        {
            var head = pList.Last(); // Saab pea
            for (int i = 0; i < pList.Count - 2; i++) // Kontrollib kõiki teisi kehaosi, välja arvatud pea
            {
                if (head.IsHit(pList[i])) // Kui pea kattub mõne kehaga, on mäng läbi
                    return true;
            }
            return false;
        }

        // Kontrollib, kas kasutaja vajutas klahvi ja muudab suunda vastavalt
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        // Kontrollib, kas madu sööb toidu
        public bool Eat(Point food)
        {
            Point head = GetNextPoint(); // Saab järgmise liikumispunkti
            if (head.IsHit(food)) // Kui see punkt kattub toiduga
            {
                food.sym = head.sym; // Muudame toidupunkti mao osaks
                pList.Add(food); // Lisame toidupunkti mao keha loendisse
                return true; // Mao pikkus kasvab
            }
            else
                return false; // Ei söö toitu
        }
    }
}
