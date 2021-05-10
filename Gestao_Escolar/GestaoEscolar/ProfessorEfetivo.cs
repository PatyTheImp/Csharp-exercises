using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestaoEscolar
{
    class ProfessorEfetivo : Professor
    {
        private int diasServico;

        public int DiasServico
        {
            get { return diasServico; }
            set { diasServico = value; }
        }

        public ProfessorEfetivo(int nif, string nome, int dias) 
            : base(nif, nome, EscalaoPorDiasServico(dias))
        {
            diasServico = dias;
        }

        public override string TipoProfessor()
        {
            return "EFETIVO";
        }

        public override SqlCommand ComandoInserir()
        {
            SqlCommand command = new("INSERT INTO professor VALUES(@nif, @nome, @escalao, @profissionalizacao, @dias_de_servico, @tipo_professor);");

            command.Parameters.AddWithValue("@nif", nif);
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@escalao", escalao);
            command.Parameters.AddWithValue("@profissionalizacao", 1);
            command.Parameters.AddWithValue("@dias_de_servico", diasServico);
            command.Parameters.AddWithValue("@tipo_professor", TipoProfessor());

            return command;
        }

        public override SqlCommand ComandoEditar()
        {
            SqlCommand command = new("UPDATE professor SET nome = @nome, escalao = @escalao, profissionalizacao = @profissionalizacao, " +
                "dias_de_servico = @dias_de_servico, tipo_professor = @tipo_professor WHERE nif = @nif");

            command.Parameters.AddWithValue("@nif", nif);
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@escalao", escalao);
            command.Parameters.AddWithValue("@profissionalizacao", 1);
            command.Parameters.AddWithValue("@dias_de_servico", diasServico);
            command.Parameters.AddWithValue("@tipo_professor", TipoProfessor());

            return command;
        }
    }
}
