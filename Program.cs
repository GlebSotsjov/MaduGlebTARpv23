using System;
using System.Collections.Generic;
using System.Linq;
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

           



            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
