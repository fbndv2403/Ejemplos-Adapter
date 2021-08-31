using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombillo
{
    class Linea
    {
        public void draw(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Linea del punto A(" + x1 + ";" + y1 + "), al punto B(" + x2 + ";" + y2 + ")");
            Console.ReadLine();
        }
    }
}
