using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MaduGlebTARpv23
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Point p1 = new Point(1,3, '*');
            p1.Draw();
           
 //int x1 = 1; // вид данных int только целые числа
 // вид данных char только буквы
            Point p2 = new Point(4,5,'#');
            p2.Draw();

            Point p3 = new Point(2, 6, '*');
            p3.Draw();

            Point p5 = new Point(3, 8, '*');
            p5.Draw();

            Point p7 = new Point(5, 1, '*');
            p7.Draw();

            Point p4 = new Point(3, 6, '#');
            p4.Draw();

            Point p6 = new Point(7, 1, '#');
            p6.Draw();

            Point p8 = new Point(4, 7, '#');
            p8.Draw();

            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            foreach (int i in numlist)
            { 
                Console.WriteLine(i);
            }

            numlist.RemoveAt(0);

            List<Point> pList = new List<Point>();
            
            pList.Add(p1 );

            pList.Add(p2);

            pList.Add(p3);

            pList.Add(p4);

            pList.Add(p5);

            pList.Add(p6);

            pList.Add(p7);

            pList.Add(p8);



            Console.ReadLine();
        }
    }
}
