using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoDeAtendimento
{
    public partial class Form1 : Form
    {
        public Queue<string> prioritaria;
        public Queue<string> geral;
        char letraG, letraP;
        string numG, numP;
        int contador;

        public Form1()
        {
            InitializeComponent();

            prioritaria = new Queue<string>();
            geral = new Queue<string>();
            letraG = 'A'; 
            letraP = 'A';
            numG = "00"; 
            numP = "00";
            contador = 0;
        }

        private void btnPrioritario_Click(object sender, EventArgs e)
        {
            //Imprime na label a senha atual
            lblSenha.Text = "P - " + letraP + numP;
            prioritaria.Enqueue("P - " + letraP + numP); //Acrescenta á fila, a senha.

            //Se a parte numérica da senha for diferente de 99, soma-se 1, 
            //e não se altera a parte alfabética.
            if (numP != "99")
                //Se o número for menor que 10, acrescenta-se um zero á esquerda.
                numP = int.Parse(numP) + 1 < 10 ? "0" + Convert.ToString(int.Parse(numP) + 1) : Convert.ToString(int.Parse(numP) + 1);

            //Caso a parte numérica seja igual a 99, reseta-se o número 
            //e altera-se a parte alfabética.
            else
            {
                numP = "00";
                //Se a letraP for Z, reseta-se a letraP.
                letraP = letraP == 'Z' ? 'A' : Convert.ToChar((int)letraP + 1);
            }
        }

        private void btnBalcao1_Click(object sender, EventArgs e)
        {
            //Visto que a ordem de atendimento é 3 senhas prioritárias para 1 geral,
            //verifica-se se o contador de senhas prioritárias chegou ao limite, caso não tenha chegado ao limite e
            //houver senhas prioritárias, é imprimido na label da vez, a senha prioritária que se encontra no inicio da fila.
            //Isso também acontece se não houver nenhuma senha geral e houver prioritárias, independentemente do valor do contador.
            if ((contador < 3 && prioritaria.Count > 0) || (prioritaria.Count > 0 && geral.Count == 0))
            {
                lblVez.Text = prioritaria.Peek() + "\nBalcão 1";
                prioritaria.Dequeue();
                contador++;
            }
            //Caso haja pelo menos uma senha geral. Se o valor do contador tenha chegado ao limite, 
            //ou se não houver senhas prioritárias, é imprimido na label da vez, a senha geral que se encontra no inicio da fila.
            else if (geral.Count > 0)
            {
                lblVez.Text = geral.Peek() + "\nBalcão 1";
                geral.Dequeue();
                contador = 0;
            }
            //Caso não haja nenhuma senha nas filas, imprime-se uma mensagem a informar o acontecimento.
            else
                lblVez.Text = "Não há ninguém na fila.";
        }

        private void btnBalcao2_Click(object sender, EventArgs e)
        {
            //Mesma lógica que em btnBalcao1_Click
            if ((contador < 3 && prioritaria.Count > 0) || (prioritaria.Count > 0 && geral.Count == 0))
            {
                lblVez.Text = prioritaria.Peek() + "\nBalcão 2";
                prioritaria.Dequeue();
                contador++;
            }
            else if (geral.Count > 0)
            {
                lblVez.Text = geral.Peek() + "\nBalcão 2";
                geral.Dequeue();
                contador = 0;
            }
            else
                lblVez.Text = "Não há ninguém na fila.";
        }

        private void btnBalcao3_Click(object sender, EventArgs e)
        {
            //Mesma lógica que em btnBalcao1_Click
            if ((contador < 3 && prioritaria.Count > 0) || (prioritaria.Count > 0 && geral.Count == 0))
            {
                lblVez.Text = prioritaria.Peek() + "\nBalcão 3";
                prioritaria.Dequeue();
                contador++;
            }
            else if (geral.Count > 0)
            {
                lblVez.Text = geral.Peek() + "\nBalcão 3";
                geral.Dequeue();
                contador = 0;
            }
            else
                lblVez.Text = "Não há ninguém na fila.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGeral_Click(object sender, EventArgs e)
        {
            //Mesma lógica do btnPrioritario_Click
            lblSenha.Text = "G - " + letraG + numG;
            geral.Enqueue("G - " + letraG + numG); 

            if (numG != "99")
                numG = int.Parse(numG) + 1 < 10 ? "0" + Convert.ToString(int.Parse(numG) + 1) : Convert.ToString(int.Parse(numG) + 1);

            else
            {
                numG = "00";
                letraG = letraG == 'Z' ? 'A' : Convert.ToChar((int)letraG + 1);
            }
        }
    }
}
