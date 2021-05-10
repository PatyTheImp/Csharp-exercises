using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEscolar
{
    public partial class EditarProfessor : Form
    {
        IGestorProfessores gestor;
        int nif;
        ConsultarProfessor formularioConsultar;

        public EditarProfessor(int nif, ConsultarProfessor formulario)
        {
            InitializeComponent();

            gestor = new GestorProfessores();
            this.nif = nif;
            formularioConsultar = formulario;

            if (gestor.ConsultarProfessor(nif).TipoProfessor() == "EFETIVO")
            {
                ProfessorEfetivo professorEfetivo = (ProfessorEfetivo)gestor.ConsultarProfessor(nif);

                txtbNome.Text = professorEfetivo.Nome;
                txtbNIF.Text = nif.ToString();
                nupdDias.Value = professorEfetivo.DiasServico;
                rbtnEfetivo.Checked = true;

                checkbProfissionalizado.Checked = true;
                checkbProfissionalizado.Enabled = false;
            }
            else
            {
                ProfessorContratado professorContratado = (ProfessorContratado)gestor.ConsultarProfessor(nif);

                txtbNome.Text = professorContratado.Nome;
                txtbNIF.Text = nif.ToString();
                checkbProfissionalizado.Checked = professorContratado.Profissionalizado;
                rbtnContratado.Checked = true;

                nupdDias.Value = 0;
                nupdDias.Enabled = false;
            }
        }

        private void btnInserirProf_Click(object sender, EventArgs e)
        {
            if (txtbNome.Text.Trim() == String.Empty)
                MessageBox.Show("Preencha todos os campos");

            else if (rbtnEfetivo.Checked)
            {
                ProfessorEfetivo professorEfetivo = new(nif, txtbNome.Text, (int)nupdDias.Value);
                bool resultado = gestor.EditarProfessor(professorEfetivo);

                if (resultado)
                {
                    MessageBox.Show("Professor editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formularioConsultar.CarregaProfessores(string.Empty);
                }
                else
                    MessageBox.Show("Algo correu mal", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProfessorContratado professorContratado = new(nif, txtbNome.Text, checkbProfissionalizado.Checked);
                bool resultado = gestor.EditarProfessor(professorContratado);

                if (resultado)
                {
                    MessageBox.Show("Professor editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formularioConsultar.CarregaProfessores(string.Empty);
                }
                else
                    MessageBox.Show("Algo correu mal", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnContratado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnContratado.Checked)
            {
                checkbProfissionalizado.Enabled = true;
                nupdDias.Enabled = false;
                nupdDias.Value = 0;
            }
        }

        private void rbtnEfetivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEfetivo.Checked)
            {
                checkbProfissionalizado.Enabled = false;
                checkbProfissionalizado.Checked = true;
                nupdDias.Enabled = true;
                nupdDias.Value = 0;
            }
        }
    }
}
