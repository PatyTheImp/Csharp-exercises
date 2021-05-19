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
    public partial class GestaoEscolar : Form
    {
        public GestaoEscolar()
        {
            InitializeComponent();
        }

        //private void btnNovoProfessor_Click(object sender, EventArgs e)
        //{
        //    NovoProfessor novoProfessor = new NovoProfessor();
        //    novoProfessor.MdiParent = this;

        //    novoProfessor.StartPosition = FormStartPosition.Manual;
        //    novoProfessor.Location = new Point(10, 50);
        //    novoProfessor.Show();
        //}

        //private void btnConsultarProf_Click(object sender, EventArgs e)
        //{
        //    ConsultarProfessor consultarProfessor = new ConsultarProfessor();
        //    consultarProfessor.MdiParent = this;

        //    consultarProfessor.StartPosition = FormStartPosition.Manual;
        //    consultarProfessor.Location = new Point(10, 50);
        //    consultarProfessor.Show();
        //}

        private void menuGestao_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == NovoProfessorMenuItem)
            {
                NovoProfessor novoProfessor = new();
                novoProfessor.MdiParent = this;

                novoProfessor.StartPosition = FormStartPosition.CenterScreen;
                novoProfessor.Show();
            }
            else if (e.ClickedItem == ConsultarProfessorMenuItem)
            {
                ConsultarProfessor consultarProfessor = new();
                consultarProfessor.MdiParent = this;

                consultarProfessor.StartPosition = FormStartPosition.CenterScreen;
                consultarProfessor.Show();
            }
            else if (e.ClickedItem == FecharMesMenuItem)
            {
                FecharMes fecharMes = new();
                fecharMes.MdiParent = this;

                fecharMes.StartPosition = FormStartPosition.CenterScreen;
                fecharMes.Show();
            }
        }

        //Para mudar a cor de fundo do container
        private void GestaoEscolar_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(217,163,143);
        }
    }
}
