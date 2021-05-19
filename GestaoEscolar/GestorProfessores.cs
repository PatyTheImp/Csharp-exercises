using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestaoEscolar
{
    class GestorProfessores : IGestorProfessores
    {
        private SqlConnection connection;

        public GestorProfessores()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\OneDrive\informática\tarefas\Csharp\GestaoEscolarV2\GestaoEscolar\ProfsDB.mdf;Integrated Security=True");
        } 

        public List<Professor> ConsultarProfessores(string info)
        {
            List<Professor> professores = new List<Professor>();
            string query = "SELECT * FROM professor";

            if (info != string.Empty)
            {
                query += " WHERE nome LIKE '" + info + "%' OR tipo_professor LIKE '" + info + "%' OR CAST(nif AS NVARCHAR(MAX)) LIKE '" + info + "%'";
            }

            SqlCommand sql = new(query);
            //sql.Parameters.AddWithValue("@info", info);
            sql.Connection = connection;
            connection.Open();
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Professor professor = null;

                int nif = int.Parse(sqlDataReader["nif"].ToString());
                string nome = sqlDataReader["nome"].ToString();
                bool profissionalizado = bool.Parse(sqlDataReader["profissionalizacao"].ToString());
                int diasDeServico = int.Parse(sqlDataReader["dias_de_servico"].ToString());
                string tipoProfessor = sqlDataReader["tipo_professor"].ToString();

                if (tipoProfessor == "EFETIVO")
                    professor = new ProfessorEfetivo(nif, nome, diasDeServico);
                else
                    professor = new ProfessorContratado(nif, nome, profissionalizado);

                professores.Add(professor);
            }
            connection.Close();

            return professores;
        }

        //Método para indentificar professor para propósitos de edição 
        public Professor ConsultarProfessor(int nif)
        {
            Professor professor = null;

            connection.Open();
            SqlCommand sql = new("SELECT * FROM professor WHERE nif = @nif", connection);
            sql.Parameters.AddWithValue("@nif", nif);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            if (sqlDataReader.Read())
            {
                int profNif = int.Parse(sqlDataReader["nif"].ToString());
                string nome = sqlDataReader["nome"].ToString();
                bool profissionalizado = bool.Parse(sqlDataReader["profissionalizacao"].ToString());
                int diasDeServico = int.Parse(sqlDataReader["dias_de_servico"].ToString());
                string tipoProfessor = sqlDataReader["tipo_professor"].ToString();

                if (tipoProfessor == "EFETIVO")
                    professor = new ProfessorEfetivo(profNif, nome, diasDeServico);
                else
                    professor = new ProfessorContratado(profNif, nome, profissionalizado);
            }

            connection.Close();

            return professor;
        }

        public bool InserirProfessor(Professor professor)
        {
            SqlCommand command = professor.ComandoInserir();
            command.Connection = connection;
            int rows = 0;

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();
            }
           catch (SqlException)
            {
                connection.Close();
                return false;
            }

            return rows > 0;
        }

        public bool InserirSalario(Salario salario)
        {
            SqlCommand command = salario.ComandoInserir();
            command.Connection = connection;
            int rows = 0;

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException)
            {
                connection.Close();
                return false;
            }

            return rows > 0;
        }

        public bool EditarProfessor(Professor professor)
        {
            SqlCommand command = professor.ComandoEditar();
            command.Connection = connection;
            int rows = 0;

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException)
            {
                connection.Close();
                return false;
            }

            return rows > 0;
        }

        public bool FecharMes(int diasUteis, int ano, int mes)
        {
            List<Professor> professors = ConsultarProfessores(string.Empty);
            bool tudoBem = true;

            foreach (Professor prof in professors)
            {
                Salario salario = prof.CalculoSalario(diasUteis, ano, mes);
                //Se por alguma razão, algum ou alguns dos salários não forem adcionados a base de dados, este método retorna 
                //false para indicar que não correu tudo bem.
                if (!InserirSalario(salario))
                    tudoBem = false;
            }

            return tudoBem;
        }

        public List<Salario> ConsultarSalarios()
        {
            List<Salario> salarios = new();

            SqlCommand sql = new("SELECT * FROM salario", connection);
            connection.Open();
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int nif = int.Parse(sqlDataReader["nif"].ToString());
                double sb = double.Parse(sqlDataReader["salario_base"].ToString());
                double irs = double.Parse(sqlDataReader["irs"].ToString());
                double segurancaSocial = double.Parse(sqlDataReader["seguranca_social"].ToString());
                double subcidioAlimentacao = double.Parse(sqlDataReader["subcidio_alimentacao"].ToString());
                double salarioLiquido = double.Parse(sqlDataReader["salario_liquido"].ToString());
                int ano = int.Parse(sqlDataReader["ano"].ToString());
                int mes = int.Parse(sqlDataReader["mes"].ToString());

                Salario salario = new(nif, sb, irs, segurancaSocial, subcidioAlimentacao, salarioLiquido, ano, mes);
                salarios.Add(salario);
            }
            connection.Close();

            return salarios;
        }
    }
}
