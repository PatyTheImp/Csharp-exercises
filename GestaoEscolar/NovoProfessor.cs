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
    public partial class NovoProfessor : Form
    {
        IGestorProfessores gestor;

        public NovoProfessor()
        {
            InitializeComponent();
            gestor = new GestorProfessores();
        }

        private void btnGoEfetivo_Click(object sender, EventArgs e)
        {
            if (txtbNomeEfetivo.Text.Trim() == "" || tbNIF.Text.Trim() == "")
                MessageBox.Show("Preencha todos os campos");
            else if (Int32.TryParse(tbNIF.Text, out int nif) && tbNIF.Text.Length == 9)
            {
                if (rbtnEfetivo.Checked)
                {
                    Professor professorEfetivo = new ProfessorEfetivo(nif, txtbNomeEfetivo.Text, (int)nupdDias.Value);
                    bool resultado = gestor.InserirProfessor(professorEfetivo);

                    if (resultado)
                        MessageBox.Show("Professor insirido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Algo correu mal", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Professor professorContratado = new ProfessorContratado(nif, txtbNomeEfetivo.Text, checkbProfissionalizado.Checked);
                    bool resultado = gestor.InserirProfessor(professorContratado);

                    if (resultado)
                        MessageBox.Show("Professor insirido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Algo correu mal", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("O NIF tem de ser composto apenas por números e tem de ter 9 dígitos");
        }

        private void rbtnContratado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnContratado.Checked)
            {
                checkbProfissionalizado.Enabled = true;
                checkbProfissionalizado.Checked = false;
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
