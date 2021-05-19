using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class ProfessorContratado : Professor
    {
        private bool profissionalizado;

        public bool Profissionalizado
        {
            get { return profissionalizado; }
            set { profissionalizado = value; }
        }

        public ProfessorContratado(int nif, string nome, bool profissionalizado)
            :base(nif, nome, profissionalizado ? 1 : 0)
        {
            this.profissionalizado = profissionalizado;
        }

        public override string TipoProfessor()
        {
            return "CONTRATADO";
        }

        public override SqlCommand ComandoInserir()
        {
            SqlCommand command = new("INSERT INTO professor VALUES(@nif, @nome, @escalao, @profissionalizacao, @dias_de_servico, @tipo_professor);");

            command.Parameters.AddWithValue("@nif", nif);
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@escalao", escalao);
            command.Parameters.AddWithValue("@profissionalizacao", profissionalizado);
            command.Parameters.AddWithValue("@dias_de_servico", 0);
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
            command.Parameters.AddWithValue("@profissionalizacao", profissionalizado);
            command.Parameters.AddWithValue("@dias_de_servico", 0);
            command.Parameters.AddWithValue("@tipo_professor", TipoProfessor());

            return command;
        }
    }
}
