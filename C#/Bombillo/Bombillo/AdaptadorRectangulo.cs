using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombillo
{
    class AdaptadorRectangulo : Forma
    {
        private Rectangulo adaptee;

        public AdaptadorRectangulo(Rectangulo rectangle)
        {
            this.adaptee = rectangle;
        }

        public override void dibujar(int x1, int y1, int x2, int y2)
        {
            int x = Math.Min(x1, x2);
            int y = Math.Min(y1, y2);
            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);
            adaptee.draw(x, y, width, height);
        }
    }
}
