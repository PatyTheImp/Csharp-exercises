using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    abstract class Professor
    {
        protected int nif;
        protected string nome;
        protected int escalao;
        private static int[] escaloes = new int[] { 1000, 1500, 2000, 3000, 4000, 5000, 6000, 7000, 8000 };
        private static double[] salarios = new double[] { 1250, 1500, 1700, 1900, 2100, 2400, 2700, 3000, 3300, 3700, 4000 };

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

        public static double SalarioPorEscalao(int escal)
        {
            for (int i = 0; i < 10; i++)
            {
                if (escal == i)
                    return salarios[i];
            }
            return salarios[10];
        }

        public static double TaxaIRS(double salario)
        {
            if (salario <= 1800)
                return .12;
            if (salario <= 2500)
                return .15;
            return .2;
        }

        //Caso o mês seja 7 ou 11 o salario base é calculado em dobro. No mês 7 não recebe sa e no mês 8 recebe sa
        public Salario CalculoSalario(int diasUteis, int ano, int mes)
        {
            double salarioBase = SalarioPorEscalao(escalao);
            double irs = TaxaIRS(salarioBase) * salarioBase;
            double ss = salarioBase * .11;
            double sa = 4.77 * diasUteis;
            double salarioLiquido;

            if (mes == 7)
                salarioLiquido = salarioBase * 2 - irs - ss;
            else if (mes == 11)
                salarioLiquido = salarioBase * 2 - irs - ss + sa;
            else
                salarioLiquido = salarioBase - irs - ss + sa;

            Salario salario = new(nif, salarioBase, irs, ss, sa, salarioLiquido, ano, mes);

            return salario;
        }

        public abstract string TipoProfessor();
        public abstract SqlCommand ComandoInserir();
        public abstract SqlCommand ComandoEditar();
    }
}
