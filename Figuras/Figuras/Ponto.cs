using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Ponto
    {
        //Atributos
        private int x;
        private int y;

        //Construtor
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Propriedades
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        //Polimorfismo
        public override string ToString()
        {
            return "P(" + x + ", " + y + ")";
        }
    }
}
