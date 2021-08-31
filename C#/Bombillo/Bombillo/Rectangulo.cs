using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombillo
{
    class Rectangulo
    {
        public void draw(int x, int y, int width, int height)
        {
            Console.WriteLine("Rectangulo con punto de coordenadas de izquierda hacia abajo (" + x + ";" + y + "), ancho: " + width + ", largo: " + height);
            Console.Read();
        }
    }
}
