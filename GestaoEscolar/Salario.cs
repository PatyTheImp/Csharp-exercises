using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class Salario
    {
        private int nifProfessor;
        private double salarioBase;
        private double irs;
        private double segurancaSocial;
        private double subcidioAlimentacao;
        private double salarioLiquido;
        private int ano;
        private int mes;

        public Salario(int nif, double salarioB, double irs, double ss, double sa, double sl, int ano, int mes)
        {
            nifProfessor = nif;
            salarioBase = salarioB;
            this.irs = irs;
            segurancaSocial = ss;
            subcidioAlimentacao = sa;
            salarioLiquido = sl;
            this.ano = ano;
            this.mes = mes;
        }

        public double SalarioLiquido
        {
            get { return salarioLiquido; }
            set { salarioLiquido = value; }
        }

        public int Nif
        {
            get { return nifProfessor; }
            set { nifProfessor = value; }
        }

        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public SqlCommand ComandoInserir()
        {
            SqlCommand command = new("INSERT INTO salario VALUES(@nif, @salarioB, @irs, @ss, @sa, @sl, @ano, @mes);");

            command.Parameters.AddWithValue("@nif", nifProfessor);
            command.Parameters.AddWithValue("@salarioB", salarioBase);
            command.Parameters.AddWithValue("@irs", irs);
            command.Parameters.AddWithValue("@ss", segurancaSocial);
            command.Parameters.AddWithValue("@sa", subcidioAlimentacao);
            command.Parameters.AddWithValue("@sl", salarioLiquido);
            command.Parameters.AddWithValue("@ano", ano);
            command.Parameters.AddWithValue("@mes", mes);

            return command;
        }
    }
}
