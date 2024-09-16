using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaduGlebTARpv23
{
    internal class FoodCreator
    {
        // Mänguvälja laius ja kõrgus
        int mapWidht;
        int mapHeight;
        // Sümbol, mis tähistab toitu
        char sym;

        // Juhusliku arvu generaator
        Random random = new Random();

        // Konstruktor, mis määrab mänguvälja mõõtmed ja toidu sümboli
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidht = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        // Loob toidu juhuslikus kohas mänguväljal
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2); // Juhuslik x-koordinaat (välja äärtest veidi eemal)
            int y = random.Next(2, mapHeight - 2); // Juhuslik y-koordinaat (välja äärtest veidi eemal)
            return new Point(x, y, sym); // Tagastab loodud toidupunkti
        }
    }
}
