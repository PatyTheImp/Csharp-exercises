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
    public partial class FecharMes : Form
    {
        private IGestorProfessores gestor;

        public FecharMes()
        {
            InitializeComponent();
            gestor = new GestorProfessores();
            CarregaSalarios();
        }

        private void btnFecharMes_Click(object sender, EventArgs e)
        {
            if (cmbMes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione um mês.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMes.Focus();
            }
            else
            {
                int diasUteis = (int)nupdDiasUteis.Value;
                int ano = (int)nupdAno.Value;
                int mes = cmbMes.SelectedIndex + 1;
                bool resultado = gestor.FecharMes(diasUteis, ano, mes);

                if (resultado)
                {
                    MessageBox.Show("Correu tudo bem", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaSalarios();
                }
                else
                    MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregaSalarios()
        {
            List<Salario> salarios = gestor.ConsultarSalarios();
            lvSalarios.Items.Clear();

            foreach (Salario salario in salarios)
            {
                ListViewItem item = new(salario.Nif.ToString());
                item.SubItems.Add(salario.SalarioBase.ToString());
                item.SubItems.Add(salario.SalarioLiquido.ToString());
                item.SubItems.Add(salario.Mes.ToString());
                item.SubItems.Add(salario.Ano.ToString());

                lvSalarios.Items.Add(item);
            }
        }
    }
}
