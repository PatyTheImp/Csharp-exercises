using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Triangulo
    {
        private Ponto pontoA;
        private Ponto pontoB;
        private Ponto pontoC;

        public Triangulo(Ponto pontoA, Ponto pontoB, Ponto pontoC)
        {
            this.pontoA = pontoA;
            this.pontoB = pontoB;
            this.pontoC = pontoC;
        }

        //Segundo contrutor
        public Triangulo(Linha linha, Ponto ponto) : this(linha.PontoA, linha.PontoB, ponto)
        {
            
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

        public Ponto PontoC
        {
            get { return pontoC; }
            set { pontoC = value; }
        }

        public override string ToString()
        {
            return "T( " + pontoA.ToString() + ", " + pontoB.ToString() + ", " + pontoC.ToString() + " )";
        }
    }
}
