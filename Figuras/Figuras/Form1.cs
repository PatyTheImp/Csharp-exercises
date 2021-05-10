using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        private List<Ponto> pontos;
        private List<Linha> linhas;
        private List<Triangulo> triangulos;
        private List<Triangulo> triangPraPreencher;

        Graphics graphPanel;
        private Brush pincel;

        public Form1()
        {
            InitializeComponent();
            pontos = new List<Ponto>();
            linhas = new List<Linha>();
            triangulos = new List<Triangulo>();
            triangPraPreencher = new List<Triangulo>();

            graphPanel = pnlDesenho.CreateGraphics();
            pincel = new SolidBrush(Color.Black);
        }

        public void CarregaCombobox(ComboBox cmb, List<object> lista)
        {
            cmb.Items.Clear();
            cmb.Items.AddRange(lista.ToArray());
        }

        private void btnCriarPonto_Click(object sender, EventArgs e)
        {
            int x = (int)nupdX.Value;
            int y = (int)nupdY.Value;

            Ponto p = new Ponto(x, y);
            pontos.Add(p);

            CarregaCombobox(cmbPontos, new List<object>(pontos));
            CarregaCombobox(cmbPontoA, new List<object>(pontos));
            CarregaCombobox(cmbPontoB, new List<object>(pontos));
            CarregaCombobox(cmbPontoA2, new List<object>(pontos));
            CarregaCombobox(cmbPontoB2, new List<object>(pontos));
            CarregaCombobox(cmbPontoC, new List<object>(pontos));
            CarregaCombobox(cmbPontoParaTri, new List<object>(pontos));

            MessageBox.Show("Ponto criado com sucesso");
        }

        private void btnDesenharPonto_Click(object sender, EventArgs e)
        {
            int indice = cmbPontos.SelectedIndex;

            if (indice >= 0)
            {
                Ponto p = pontos[indice];
                Pen caneta = new Pen(Color.Black);
                graphPanel.DrawEllipse(caneta, p.X, p.Y, 5, 5);
                graphPanel.FillEllipse(pincel, p.X, p.Y, 5, 5);
            }
            else
                MessageBox.Show("Escolha um ponto da lista");
        }

        private void btn_criar_linha_Click(object sender, EventArgs e)
        {
            int indiceA = cmbPontoA.SelectedIndex;
            int indiceB = cmbPontoB.SelectedIndex;

            if (indiceA >= 0 && indiceB >= 0)
            {
                Ponto a = pontos[indiceA];
                Ponto b = pontos[indiceB];

                Linha l = new Linha(a, b);
                linhas.Add(l);

                CarregaCombobox(cmbLinhas, new List<object>(linhas));
                CarregaCombobox(cmbLinhaParaTri, new List<object>(linhas));

                MessageBox.Show("Linha criada com sucesso");
            }
            else
                MessageBox.Show("Escolha dois pontos");
        }

        private void btn_desenhar_linha_Click(object sender, EventArgs e)
        {
            int indice = cmbLinhas.SelectedIndex;
            int espessura = (int)nupdEspessuraLinha.Value;

            if (indice >= 0)
            {
                if (espessura > 0)
                {
                    Linha l = linhas[indice];
                    Pen caneta = new Pen(Color.Black, espessura);
                    graphPanel.DrawLine(caneta, l.PontoA.X, l.PontoA.Y, l.PontoB.X, l.PontoB.Y);
                }
                else
                    MessageBox.Show("Escolha uma espessura para a linha");
            }
            else
                MessageBox.Show("Escolha uma linha da lista");
        }

        private void btnCriarTriangulo_Click(object sender, EventArgs e)
        {
            int indiceA = cmbPontoA2.SelectedIndex;
            int indiceB = cmbPontoB2.SelectedIndex;
            int indiceC = cmbPontoC.SelectedIndex;

            if (indiceA >= 0 && indiceB >= 0 && indiceC >= 0)
            {
                Ponto a = pontos[indiceA];
                Ponto b = pontos[indiceB];
                Ponto c = pontos[indiceC];

                Triangulo t = new Triangulo(a, b, c);
                triangulos.Add(t);

                CarregaCombobox(cmbTriangulos, new List<object>(triangulos));

                MessageBox.Show("Triângulo criado com sucesso");
            }
            else
                MessageBox.Show("Escolha três pontos");
        }

        private void btnCriarTri2_Click(object sender, EventArgs e)
        {
            int indiceP = cmbPontoParaTri.SelectedIndex;
            int indiceL = cmbLinhaParaTri.SelectedIndex;

            if (indiceP >= 0 && indiceL >= 0)
            {
                Ponto p = pontos[indiceP];
                Linha l = linhas[indiceL];

                Triangulo t = new Triangulo(l, p);
                triangulos.Add(t);

                CarregaCombobox(cmbTriangulos, new List<object>(triangulos));

                MessageBox.Show("Triângulo criado com sucesso");
            }
            else
                MessageBox.Show("Escolha três pontos");
        }

        private void btnDesenharTriangulo_Click_1(object sender, EventArgs e)
        {
            int indice = cmbTriangulos.SelectedIndex;
            int espessura = (int)nupdEspessuraTri.Value;

            if (indice >= 0)
            {
                if (espessura > 0)
                {
                    Triangulo t = triangulos[indice];
                    triangPraPreencher.Add(t);
                    CarregaCombobox(cmb_triang_preencher, new List<object>(triangPraPreencher));
                    Pen caneta = new Pen(Color.Black, espessura);

                    //graphPanel.DrawLine(caneta, t.PontoA.X, t.PontoA.Y, t.PontoB.X, t.PontoB.Y);
                    //graphPanel.DrawLine(caneta, t.PontoA.X, t.PontoA.Y, t.PontoC.X, t.PontoC.Y);
                    //graphPanel.DrawLine(caneta, t.PontoC.X, t.PontoC.Y, t.PontoB.X, t.PontoB.Y);

                    Point pA = new Point(t.PontoA.X, t.PontoA.Y);
                    Point pB = new Point(t.PontoB.X, t.PontoB.Y);
                    Point pC = new Point(t.PontoC.X, t.PontoC.Y);
                    Point[] points = { pA, pB, pC };

                    graphPanel.DrawPolygon(caneta, points);
                }
                else
                    MessageBox.Show("Escolha uma espessura para o triângulo");
            }
            else
                MessageBox.Show("Escolha um triângulo da lista");
        }

        //Preenche um triângulo já desenhado 
        //com uma cor escolhida pelo utilizador
        private void btn_preencher_Click_1(object sender, EventArgs e)
        {
            int indice = cmb_triang_preencher.SelectedIndex;

            if (indice >= 0)
            {
                //Ativa a caixa de diálogo de escolha de cor. Se for escolhido uma cor e o botão OK
                //for primido, o triângulo escolhido é preenchido com essa cor
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Triangulo t = triangPraPreencher[indice];
                    //Foi necessário priar um Point[] para poder usar o método FillPolygon
                    Point pA = new Point(t.PontoA.X, t.PontoA.Y);
                    Point pB = new Point(t.PontoB.X, t.PontoB.Y);
                    Point pC = new Point(t.PontoC.X, t.PontoC.Y);
                    Point[] points = { pA, pB, pC };

                    Brush preenchimento = new SolidBrush(colorDialog.Color);

                    //Método que preenche o triângulo
                    graphPanel.FillPolygon(preenchimento, points);
                }
            }
            else
                MessageBox.Show("Escolha um triângulo da lista");
        }

        //Muda cor de fundo do painel
        private void btnCorDeFundo_Click_1(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pnlDesenho.BackColor = colorDialog.Color;
            }
        }

        //Limpa o painel
        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            //Cor de fundo do painel
            graphPanel.Clear(pnlDesenho.BackColor);
        }
    }
}
