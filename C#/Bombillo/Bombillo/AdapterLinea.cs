using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombillo
{
    class AdapterLinea:Forma
    {
        private Linea adaptee;

        public AdapterLinea(Linea line)
        {
            this.adaptee = line;
        }


        public override void dibujar(int x1, int y1, int x2, int y2)
        {
            adaptee.draw(x1, y1, x2, y2);
        }
    }
}
