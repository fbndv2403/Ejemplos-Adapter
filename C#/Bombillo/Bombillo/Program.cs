using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombillo
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma[] shapes = { new AdaptadorRectangulo(new Rectangulo()), new AdapterLinea(new Linea()) };
            int x1 = 10, y1 = 20;
            int x2 = 30, y2 = 60;
            foreach (Forma shape in shapes )
            {
                shape.dibujar(x1, y1, x2, y2);
            }
        }
    }
}
