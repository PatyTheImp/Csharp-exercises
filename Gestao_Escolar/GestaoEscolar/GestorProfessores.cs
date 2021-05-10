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
    }
}
