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

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            HorizontalLine Line = new HorizontalLine(5,10,8,'+'); /* 5.34 vid */
            Line.Drow();

            Console.ReadLine();
        }
    }
}
