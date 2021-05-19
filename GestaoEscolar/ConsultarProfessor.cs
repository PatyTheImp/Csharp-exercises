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
    public partial class ConsultarProfessor : Form
    {
        private IGestorProfessores gestor;

        public ConsultarProfessor()
        {
            InitializeComponent();
            gestor = new GestorProfessores();
            CarregaProfessores(string.Empty);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaProfessores(txtbConsultar.Text);
        }

        //Visibilidade public para poder chamar este método em outro formulario (para poder atualizar a tabela depois de editar)
        public void CarregaProfessores(string info)
        {
            List<Professor> professores = gestor.ConsultarProfessores(info);
            lvConsultar.Items.Clear();

            foreach (Professor p in professores)
            {
                ListViewItem item = new(p.Nif.ToString());
                item.SubItems.Add(p.Nome);
                item.SubItems.Add(p.Escalao.ToString());
                if (p.Escalao > 0)
                    item.SubItems.Add("sim"); 
                else
                    item.SubItems.Add("não");
                if (p is ProfessorEfetivo)
                    item.SubItems.Add(((ProfessorEfetivo)p).DiasServico.ToString());
                else
                    item.SubItems.Add("não se aplica");
                item.SubItems.Add(p.TipoProfessor());

                lvConsultar.Items.Add(item);
            }
        }

        private void txtbConsultar_TextChanged(object sender, EventArgs e)
        {
            if (txtbConsultar.Text.Length > 2)
                CarregaProfessores(txtbConsultar.Text);
            else
                CarregaProfessores(string.Empty);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvConsultar.SelectedItems.Count <= 0)
                MessageBox.Show("Selecione um professor da lista", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int nif = Int32.Parse(lvConsultar.SelectedItems[0].SubItems[0].Text);

                EditarProfessor editar = new(nif, this);
                editar.MdiParent = this.MdiParent;

                editar.StartPosition = FormStartPosition.CenterScreen;
                editar.Show();
            }           
        }

        private void lvConsultar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvConsultar.SelectedItems.Count <= 0)
                MessageBox.Show("Selecione um professor da lista", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int nif = Int32.Parse(lvConsultar.SelectedItems[0].SubItems[0].Text);

                EditarProfessor editar = new(nif, this);
                editar.MdiParent = this.MdiParent;

                editar.StartPosition = FormStartPosition.CenterScreen;
                editar.Show();
            }
        }
    }
}
