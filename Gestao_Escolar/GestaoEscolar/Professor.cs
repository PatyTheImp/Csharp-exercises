using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    abstract class  Professor
    {
        protected int nif;
        protected string nome;
        protected int escalao;
        private static int[] escaloes = new int[] { 1000, 1500, 2000, 3000, 4000, 5000, 6000, 7000, 8000 };

        public int Nif 
        {
            get { return nif; } 
            set { nif = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Escalao
        {
            get { return escalao; }
            set { escalao = value; }
        }

        public Professor(int nif, string nome, int escalao)
        {
            this.nif = nif;
            this.nome = nome;
            this.escalao = escalao;
        }

        public override string ToString()
        {
            return nif + " - " + nome + " - Escalão: " + escalao;
        }

        public static int EscalaoPorDiasServico(int dias)
        {
            if (dias < escaloes[0])
                return 1;
            if (dias < escaloes[1])
                return 2;
            if (dias < escaloes[2])
                return 3;
            if (dias < escaloes[3])
                return 4;
            if (dias < escaloes[4])
                return 5;
            if (dias < escaloes[5])
                return 6;
            if (dias < escaloes[6])
                return 7;
            if (dias < escaloes[7])
                return 8;
            if (dias < escaloes[8])
                return 9;
            return 10;
        }

        public abstract string TipoProfessor();
        public abstract SqlCommand ComandoInserir();
        public abstract SqlCommand ComandoEditar();
    }
}
