using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Linha
    {
        //Agregação/Composição
        private Ponto pontoA;
        private Ponto pontoB;

        public Linha(Ponto pontoA, Ponto pontoB)
        {
            this.pontoA = pontoA;
            this.pontoB = pontoB;
        }

        public Ponto PontoA
        {
            get { return pontoA; }
            set { pontoA = value; }
        }

        public Ponto PontoB
        {
            get { return pontoB; }
            set { pontoB = value; }
        }

        public override string ToString()
        {
            return "L( " + pontoA.ToString() + ", " + pontoB.ToString() + " )";
        }
    }
}
