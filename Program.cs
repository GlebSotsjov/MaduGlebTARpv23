using MaduGlebTARpv23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaduGlebTARpv23
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Määrab konsooli akna suuruse
            Console.SetWindowSize(80, 25);

            // Loob mänguvälja seinad ja joonistab need ekraanile
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Loob mao alguspunkti ja suuna ning joonistab mao
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            // Loob toidu mänguväljale ja joonistab selle
            FoodCreator foodCreator = new FoodCreator(80, 25, '#');
            Point food = foodCreator.CreateFood();
            food.Draw();

            // Mängu peamine tsükkel
            while (true)
            {
                // Kui madu põrkab seina või oma sabaga, mäng lõpeb
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                // Kui madu sööb toidu, luuakse uus toit
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    // Kui madu ei söö toitu, liigub edasi
                    snake.Move();
                }

                // Paus mängu tsüklis
                Thread.Sleep(100);

                // Kontrollib, kas klahvivajutus on saadaval, ja muudab suunda
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key); // Mao liikumise juhtimine klaviatuuriga
                }
            }

            // Ootab, et kasutaja vajutaks Enter, et programm sulgeda
            Console.ReadLine();
        }
    }
}
