using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    interface IGestorProfessores
    {
        bool InserirProfessor(Professor professor);
        bool EditarProfessor(Professor professor);
        List<Professor> ConsultarProfessores(string info);
        Professor ConsultarProfessor(int nif);
    }
}
