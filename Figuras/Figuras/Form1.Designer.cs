
namespace Figuras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbPONTOS = new System.Windows.Forms.GroupBox();
            this.btnDesenharPonto = new System.Windows.Forms.Button();
            this.cmbPontos = new System.Windows.Forms.ComboBox();
            this.btnCriarPonto = new System.Windows.Forms.Button();
            this.nupdY = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.nupdX = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.pnlDesenho = new System.Windows.Forms.Panel();
            this.gbLINHAS = new System.Windows.Forms.GroupBox();
            this.nupdEspessuraLinha = new System.Windows.Forms.NumericUpDown();
            this.lblEspessuraLinha = new System.Windows.Forms.Label();
            this.cmbPontoA = new System.Windows.Forms.ComboBox();
            this.cmbPontoB = new System.Windows.Forms.ComboBox();
            this.btn_desenhar_linha = new System.Windows.Forms.Button();
            this.cmbLinhas = new System.Windows.Forms.ComboBox();
            this.btn_criar_linha = new System.Windows.Forms.Button();
            this.lblPontoB = new System.Windows.Forms.Label();
            this.lblPontoA = new System.Windows.Forms.Label();
            this.gbTRIANGULOS = new System.Windows.Forms.GroupBox();
            this.cmbPontoC = new System.Windows.Forms.ComboBox();
            this.lblPontoC = new System.Windows.Forms.Label();
            this.cmbPontoA2 = new System.Windows.Forms.ComboBox();
            this.cmbPontoB2 = new System.Windows.Forms.ComboBox();
            this.btnCriarTriangulo = new System.Windows.Forms.Button();
            this.lblPontoB2 = new System.Windows.Forms.Label();
            this.lblPontoA2 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.gbTriLinhaPonto = new System.Windows.Forms.GroupBox();
            this.cmbPontoParaTri = new System.Windows.Forms.ComboBox();
            this.cmbLinhaParaTri = new System.Windows.Forms.ComboBox();
            this.btnCriarTri2 = new System.Windows.Forms.Button();
            this.lblLinhaParaTri = new System.Windows.Forms.Label();
            this.lblPontoParaTri = new System.Windows.Forms.Label();
            this.gbDesenharTri = new System.Windows.Forms.GroupBox();
            this.cmbTriangulos = new System.Windows.Forms.ComboBox();
            this.btnDesenharTriangulo = new System.Windows.Forms.Button();
            this.lblEspessuraTri = new System.Windows.Forms.Label();
            this.nupdEspessuraTri = new System.Windows.Forms.NumericUpDown();
            this.btnCorDeFundo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.cmb_triang_preencher = new System.Windows.Forms.ComboBox();
            this.gbExtra = new System.Windows.Forms.GroupBox();
            this.gbPONTOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdX)).BeginInit();
            this.gbLINHAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEspessuraLinha)).BeginInit();
            this.gbTRIANGULOS.SuspendLayout();
            this.gbTriLinhaPonto.SuspendLayout();
            this.gbDesenharTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEspessuraTri)).BeginInit();
            this.gbExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPONTOS
            // 
            this.gbPONTOS.Controls.Add(this.btnDesenharPonto);
            this.gbPONTOS.Controls.Add(this.cmbPontos);
            this.gbPONTOS.Controls.Add(this.btnCriarPonto);
            this.gbPONTOS.Controls.Add(this.nupdY);
            this.gbPONTOS.Controls.Add(this.lblY);
            this.gbPONTOS.Controls.Add(this.nupdX);
            this.gbPONTOS.Controls.Add(this.lblX);
            this.gbPONTOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbPONTOS.Location = new System.Drawing.Point(12, 12);
            this.gbPONTOS.Name = "gbPONTOS";
            this.gbPONTOS.Size = new System.Drawing.Size(246, 174);
            this.gbPONTOS.TabIndex = 0;
            this.gbPONTOS.TabStop = false;
            this.gbPONTOS.Text = "PONTOS";
            // 
            // btnDesenharPonto
            // 
            this.btnDesenharPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesenharPonto.Location = new System.Drawing.Point(6, 142);
            this.btnDesenharPonto.Name = "btnDesenharPonto";
            this.btnDesenharPonto.Size = new System.Drawing.Size(233, 23);
            this.btnDesenharPonto.TabIndex = 6;
            this.btnDesenharPonto.Text = "DESENHAR PONTO";
            this.btnDesenharPonto.UseVisualStyleBackColor = true;
            this.btnDesenharPonto.Click += new System.EventHandler(this.btnDesenharPonto_Click);
            // 
            // cmbPontos
            // 
            this.cmbPontos.FormattingEnabled = true;
            this.cmbPontos.Location = new System.Drawing.Point(6, 113);
            this.cmbPontos.Name = "cmbPontos";
            this.cmbPontos.Size = new System.Drawing.Size(233, 23);
            this.cmbPontos.TabIndex = 5;
            // 
            // btnCriarPonto
            // 
            this.btnCriarPonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCriarPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPonto.Location = new System.Drawing.Point(6, 84);
            this.btnCriarPonto.Name = "btnCriarPonto";
            this.btnCriarPonto.Size = new System.Drawing.Size(233, 23);
            this.btnCriarPonto.TabIndex = 4;
            this.btnCriarPonto.Text = "CRIAR PONTO";
            this.btnCriarPonto.UseVisualStyleBackColor = false;
            this.btnCriarPonto.Click += new System.EventHandler(this.btnCriarPonto_Click);
            // 
            // nupdY
            // 
            this.nupdY.Location = new System.Drawing.Point(26, 55);
            this.nupdY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupdY.Name = "nupdY";
            this.nupdY.Size = new System.Drawing.Size(213, 23);
            this.nupdY.TabIndex = 3;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(6, 57);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 15);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y";
            // 
            // nupdX
            // 
            this.nupdX.Location = new System.Drawing.Point(26, 26);
            this.nupdX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupdX.Name = "nupdX";
            this.nupdX.Size = new System.Drawing.Size(213, 23);
            this.nupdX.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 28);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 15);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // pnlDesenho
            // 
            this.pnlDesenho.BackColor = System.Drawing.Color.White;
            this.pnlDesenho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDesenho.Location = new System.Drawing.Point(264, 12);
            this.pnlDesenho.Name = "pnlDesenho";
            this.pnlDesenho.Size = new System.Drawing.Size(750, 387);
            this.pnlDesenho.TabIndex = 7;
            // 
            // gbLINHAS
            // 
            this.gbLINHAS.Controls.Add(this.nupdEspessuraLinha);
            this.gbLINHAS.Controls.Add(this.lblEspessuraLinha);
            this.gbLINHAS.Controls.Add(this.cmbPontoA);
            this.gbLINHAS.Controls.Add(this.cmbPontoB);
            this.gbLINHAS.Controls.Add(this.btn_desenhar_linha);
            this.gbLINHAS.Controls.Add(this.cmbLinhas);
            this.gbLINHAS.Controls.Add(this.btn_criar_linha);
            this.gbLINHAS.Controls.Add(this.lblPontoB);
            this.gbLINHAS.Controls.Add(this.lblPontoA);
            this.gbLINHAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbLINHAS.Location = new System.Drawing.Point(12, 192);
            this.gbLINHAS.Name = "gbLINHAS";
            this.gbLINHAS.Size = new System.Drawing.Size(246, 207);
            this.gbLINHAS.TabIndex = 7;
            this.gbLINHAS.TabStop = false;
            this.gbLINHAS.Text = "LINHAS";
            // 
            // nupdEspessuraLinha
            // 
            this.nupdEspessuraLinha.Location = new System.Drawing.Point(79, 112);
            this.nupdEspessuraLinha.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdEspessuraLinha.Name = "nupdEspessuraLinha";
            this.nupdEspessuraLinha.Size = new System.Drawing.Size(159, 23);
            this.nupdEspessuraLinha.TabIndex = 10;
            // 
            // lblEspessuraLinha
            // 
            this.lblEspessuraLinha.AutoSize = true;
            this.lblEspessuraLinha.Location = new System.Drawing.Point(6, 115);
            this.lblEspessuraLinha.Name = "lblEspessuraLinha";
            this.lblEspessuraLinha.Size = new System.Drawing.Size(67, 15);
            this.lblEspessuraLinha.TabIndex = 9;
            this.lblEspessuraLinha.Text = "ESPESSURA";
            // 
            // cmbPontoA
            // 
            this.cmbPontoA.FormattingEnabled = true;
            this.cmbPontoA.Location = new System.Drawing.Point(69, 25);
            this.cmbPontoA.Name = "cmbPontoA";
            this.cmbPontoA.Size = new System.Drawing.Size(171, 23);
            this.cmbPontoA.TabIndex = 8;
            // 
            // cmbPontoB
            // 
            this.cmbPontoB.FormattingEnabled = true;
            this.cmbPontoB.Location = new System.Drawing.Point(68, 54);
            this.cmbPontoB.Name = "cmbPontoB";
            this.cmbPontoB.Size = new System.Drawing.Size(172, 23);
            this.cmbPontoB.TabIndex = 7;
            // 
            // btn_desenhar_linha
            // 
            this.btn_desenhar_linha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desenhar_linha.Location = new System.Drawing.Point(8, 176);
            this.btn_desenhar_linha.Name = "btn_desenhar_linha";
            this.btn_desenhar_linha.Size = new System.Drawing.Size(232, 23);
            this.btn_desenhar_linha.TabIndex = 6;
            this.btn_desenhar_linha.Text = "DESENHAR LINHA";
            this.btn_desenhar_linha.UseVisualStyleBackColor = true;
            this.btn_desenhar_linha.Click += new System.EventHandler(this.btn_desenhar_linha_Click);
            // 
            // cmbLinhas
            // 
            this.cmbLinhas.FormattingEnabled = true;
            this.cmbLinhas.Location = new System.Drawing.Point(6, 147);
            this.cmbLinhas.Name = "cmbLinhas";
            this.cmbLinhas.Size = new System.Drawing.Size(232, 23);
            this.cmbLinhas.TabIndex = 5;
            // 
            // btn_criar_linha
            // 
            this.btn_criar_linha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criar_linha.Location = new System.Drawing.Point(7, 83);
            this.btn_criar_linha.Name = "btn_criar_linha";
            this.btn_criar_linha.Size = new System.Drawing.Size(232, 23);
            this.btn_criar_linha.TabIndex = 4;
            this.btn_criar_linha.Text = "CRIAR LINHA";
            this.btn_criar_linha.UseVisualStyleBackColor = true;
            this.btn_criar_linha.Click += new System.EventHandler(this.btn_criar_linha_Click);
            // 
            // lblPontoB
            // 
            this.lblPontoB.AutoSize = true;
            this.lblPontoB.Location = new System.Drawing.Point(7, 57);
            this.lblPontoB.Name = "lblPontoB";
            this.lblPontoB.Size = new System.Drawing.Size(56, 15);
            this.lblPontoB.TabIndex = 2;
            this.lblPontoB.Text = "PONTO B";
            // 
            // lblPontoA
            // 
            this.lblPontoA.AutoSize = true;
            this.lblPontoA.Location = new System.Drawing.Point(6, 28);
            this.lblPontoA.Name = "lblPontoA";
            this.lblPontoA.Size = new System.Drawing.Size(57, 15);
            this.lblPontoA.TabIndex = 0;
            this.lblPontoA.Text = "PONTO A";
            // 
            // gbTRIANGULOS
            // 
            this.gbTRIANGULOS.Controls.Add(this.cmbPontoC);
            this.gbTRIANGULOS.Controls.Add(this.lblPontoC);
            this.gbTRIANGULOS.Controls.Add(this.cmbPontoA2);
            this.gbTRIANGULOS.Controls.Add(this.cmbPontoB2);
            this.gbTRIANGULOS.Controls.Add(this.btnCriarTriangulo);
            this.gbTRIANGULOS.Controls.Add(this.lblPontoB2);
            this.gbTRIANGULOS.Controls.Add(this.lblPontoA2);
            this.gbTRIANGULOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbTRIANGULOS.Location = new System.Drawing.Point(12, 405);
            this.gbTRIANGULOS.Name = "gbTRIANGULOS";
            this.gbTRIANGULOS.Size = new System.Drawing.Size(246, 148);
            this.gbTRIANGULOS.TabIndex = 9;
            this.gbTRIANGULOS.TabStop = false;
            this.gbTRIANGULOS.Text = "TRIÂNGULOS COM 3 PONTOS";
            // 
            // cmbPontoC
            // 
            this.cmbPontoC.FormattingEnabled = true;
            this.cmbPontoC.Location = new System.Drawing.Point(69, 83);
            this.cmbPontoC.Name = "cmbPontoC";
            this.cmbPontoC.Size = new System.Drawing.Size(170, 23);
            this.cmbPontoC.TabIndex = 10;
            // 
            // lblPontoC
            // 
            this.lblPontoC.AutoSize = true;
            this.lblPontoC.Location = new System.Drawing.Point(6, 86);
            this.lblPontoC.Name = "lblPontoC";
            this.lblPontoC.Size = new System.Drawing.Size(57, 15);
            this.lblPontoC.TabIndex = 9;
            this.lblPontoC.Text = "PONTO C";
            // 
            // cmbPontoA2
            // 
            this.cmbPontoA2.FormattingEnabled = true;
            this.cmbPontoA2.Location = new System.Drawing.Point(69, 25);
            this.cmbPontoA2.Name = "cmbPontoA2";
            this.cmbPontoA2.Size = new System.Drawing.Size(170, 23);
            this.cmbPontoA2.TabIndex = 8;
            // 
            // cmbPontoB2
            // 
            this.cmbPontoB2.FormattingEnabled = true;
            this.cmbPontoB2.Location = new System.Drawing.Point(69, 54);
            this.cmbPontoB2.Name = "cmbPontoB2";
            this.cmbPontoB2.Size = new System.Drawing.Size(170, 23);
            this.cmbPontoB2.TabIndex = 7;
            // 
            // btnCriarTriangulo
            // 
            this.btnCriarTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarTriangulo.Location = new System.Drawing.Point(6, 113);
            this.btnCriarTriangulo.Name = "btnCriarTriangulo";
            this.btnCriarTriangulo.Size = new System.Drawing.Size(233, 23);
            this.btnCriarTriangulo.TabIndex = 4;
            this.btnCriarTriangulo.Text = "CRIAR TRIÂNGULO";
            this.btnCriarTriangulo.UseVisualStyleBackColor = true;
            this.btnCriarTriangulo.Click += new System.EventHandler(this.btnCriarTriangulo_Click);
            // 
            // lblPontoB2
            // 
            this.lblPontoB2.AutoSize = true;
            this.lblPontoB2.Location = new System.Drawing.Point(6, 57);
            this.lblPontoB2.Name = "lblPontoB2";
            this.lblPontoB2.Size = new System.Drawing.Size(56, 15);
            this.lblPontoB2.TabIndex = 2;
            this.lblPontoB2.Text = "PONTO B";
            // 
            // lblPontoA2
            // 
            this.lblPontoA2.AutoSize = true;
            this.lblPontoA2.Location = new System.Drawing.Point(6, 28);
            this.lblPontoA2.Name = "lblPontoA2";
            this.lblPontoA2.Size = new System.Drawing.Size(57, 15);
            this.lblPontoA2.TabIndex = 0;
            this.lblPontoA2.Text = "PONTO A";
            // 
            // gbTriLinhaPonto
            // 
            this.gbTriLinhaPonto.Controls.Add(this.cmbPontoParaTri);
            this.gbTriLinhaPonto.Controls.Add(this.cmbLinhaParaTri);
            this.gbTriLinhaPonto.Controls.Add(this.btnCriarTri2);
            this.gbTriLinhaPonto.Controls.Add(this.lblLinhaParaTri);
            this.gbTriLinhaPonto.Controls.Add(this.lblPontoParaTri);
            this.gbTriLinhaPonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbTriLinhaPonto.Location = new System.Drawing.Point(264, 405);
            this.gbTriLinhaPonto.Name = "gbTriLinhaPonto";
            this.gbTriLinhaPonto.Size = new System.Drawing.Size(246, 149);
            this.gbTriLinhaPonto.TabIndex = 11;
            this.gbTriLinhaPonto.TabStop = false;
            this.gbTriLinhaPonto.Text = "TRIÂNGULOS COM LINHA E PONTO";
            // 
            // cmbPontoParaTri
            // 
            this.cmbPontoParaTri.FormattingEnabled = true;
            this.cmbPontoParaTri.Location = new System.Drawing.Point(70, 38);
            this.cmbPontoParaTri.Name = "cmbPontoParaTri";
            this.cmbPontoParaTri.Size = new System.Drawing.Size(170, 23);
            this.cmbPontoParaTri.TabIndex = 8;
            // 
            // cmbLinhaParaTri
            // 
            this.cmbLinhaParaTri.FormattingEnabled = true;
            this.cmbLinhaParaTri.Location = new System.Drawing.Point(69, 78);
            this.cmbLinhaParaTri.Name = "cmbLinhaParaTri";
            this.cmbLinhaParaTri.Size = new System.Drawing.Size(170, 23);
            this.cmbLinhaParaTri.TabIndex = 7;
            // 
            // btnCriarTri2
            // 
            this.btnCriarTri2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarTri2.Location = new System.Drawing.Point(6, 113);
            this.btnCriarTri2.Name = "btnCriarTri2";
            this.btnCriarTri2.Size = new System.Drawing.Size(233, 23);
            this.btnCriarTri2.TabIndex = 4;
            this.btnCriarTri2.Text = "CRIAR TRIÂNGULO";
            this.btnCriarTri2.UseVisualStyleBackColor = true;
            this.btnCriarTri2.Click += new System.EventHandler(this.btnCriarTri2_Click);
            // 
            // lblLinhaParaTri
            // 
            this.lblLinhaParaTri.AutoSize = true;
            this.lblLinhaParaTri.Location = new System.Drawing.Point(6, 81);
            this.lblLinhaParaTri.Name = "lblLinhaParaTri";
            this.lblLinhaParaTri.Size = new System.Drawing.Size(42, 15);
            this.lblLinhaParaTri.TabIndex = 2;
            this.lblLinhaParaTri.Text = "LINHA";
            // 
            // lblPontoParaTri
            // 
            this.lblPontoParaTri.AutoSize = true;
            this.lblPontoParaTri.Location = new System.Drawing.Point(7, 41);
            this.lblPontoParaTri.Name = "lblPontoParaTri";
            this.lblPontoParaTri.Size = new System.Drawing.Size(49, 15);
            this.lblPontoParaTri.TabIndex = 0;
            this.lblPontoParaTri.Text = "PONTO ";
            // 
            // gbDesenharTri
            // 
            this.gbDesenharTri.Controls.Add(this.cmbTriangulos);
            this.gbDesenharTri.Controls.Add(this.btnDesenharTriangulo);
            this.gbDesenharTri.Controls.Add(this.lblEspessuraTri);
            this.gbDesenharTri.Controls.Add(this.nupdEspessuraTri);
            this.gbDesenharTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbDesenharTri.Location = new System.Drawing.Point(516, 405);
            this.gbDesenharTri.Name = "gbDesenharTri";
            this.gbDesenharTri.Size = new System.Drawing.Size(246, 149);
            this.gbDesenharTri.TabIndex = 15;
            this.gbDesenharTri.TabStop = false;
            this.gbDesenharTri.Text = "DESENHAR TRIÂNGULO";
            // 
            // cmbTriangulos
            // 
            this.cmbTriangulos.FormattingEnabled = true;
            this.cmbTriangulos.Location = new System.Drawing.Point(6, 37);
            this.cmbTriangulos.Name = "cmbTriangulos";
            this.cmbTriangulos.Size = new System.Drawing.Size(233, 23);
            this.cmbTriangulos.TabIndex = 5;
            // 
            // btnDesenharTriangulo
            // 
            this.btnDesenharTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesenharTriangulo.Location = new System.Drawing.Point(6, 113);
            this.btnDesenharTriangulo.Name = "btnDesenharTriangulo";
            this.btnDesenharTriangulo.Size = new System.Drawing.Size(233, 23);
            this.btnDesenharTriangulo.TabIndex = 6;
            this.btnDesenharTriangulo.Text = "DESENHAR TRIÂNGULO";
            this.btnDesenharTriangulo.UseVisualStyleBackColor = true;
            this.btnDesenharTriangulo.Click += new System.EventHandler(this.btnDesenharTriangulo_Click_1);
            // 
            // lblEspessuraTri
            // 
            this.lblEspessuraTri.AutoSize = true;
            this.lblEspessuraTri.Location = new System.Drawing.Point(7, 81);
            this.lblEspessuraTri.Name = "lblEspessuraTri";
            this.lblEspessuraTri.Size = new System.Drawing.Size(67, 15);
            this.lblEspessuraTri.TabIndex = 11;
            this.lblEspessuraTri.Text = "ESPESSURA";
            // 
            // nupdEspessuraTri
            // 
            this.nupdEspessuraTri.Location = new System.Drawing.Point(80, 78);
            this.nupdEspessuraTri.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdEspessuraTri.Name = "nupdEspessuraTri";
            this.nupdEspessuraTri.Size = new System.Drawing.Size(159, 23);
            this.nupdEspessuraTri.TabIndex = 12;
            // 
            // btnCorDeFundo
            // 
            this.btnCorDeFundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorDeFundo.Location = new System.Drawing.Point(6, 86);
            this.btnCorDeFundo.Name = "btnCorDeFundo";
            this.btnCorDeFundo.Size = new System.Drawing.Size(233, 23);
            this.btnCorDeFundo.TabIndex = 19;
            this.btnCorDeFundo.Text = "MUDAR COR DE FUNDO DO PAINEL";
            this.btnCorDeFundo.UseVisualStyleBackColor = true;
            this.btnCorDeFundo.Click += new System.EventHandler(this.btnCorDeFundo_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(6, 116);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(233, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "LIMPAR PAINEL";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btn_preencher
            // 
            this.btn_preencher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preencher.Location = new System.Drawing.Point(6, 57);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(233, 23);
            this.btn_preencher.TabIndex = 17;
            this.btn_preencher.Text = "PREENCHER TRIÂNGULO";
            this.btn_preencher.UseVisualStyleBackColor = true;
            this.btn_preencher.Click += new System.EventHandler(this.btn_preencher_Click_1);
            // 
            // cmb_triang_preencher
            // 
            this.cmb_triang_preencher.FormattingEnabled = true;
            this.cmb_triang_preencher.Location = new System.Drawing.Point(6, 28);
            this.cmb_triang_preencher.Name = "cmb_triang_preencher";
            this.cmb_triang_preencher.Size = new System.Drawing.Size(233, 23);
            this.cmb_triang_preencher.TabIndex = 16;
            // 
            // gbExtra
            // 
            this.gbExtra.Controls.Add(this.cmb_triang_preencher);
            this.gbExtra.Controls.Add(this.btn_preencher);
            this.gbExtra.Controls.Add(this.btnCorDeFundo);
            this.gbExtra.Controls.Add(this.btnLimpar);
            this.gbExtra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbExtra.Location = new System.Drawing.Point(768, 405);
            this.gbExtra.Name = "gbExtra";
            this.gbExtra.Size = new System.Drawing.Size(246, 149);
            this.gbExtra.TabIndex = 16;
            this.gbExtra.TabStop = false;
            this.gbExtra.Text = "EXTRAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1027, 565);
            this.Controls.Add(this.gbExtra);
            this.Controls.Add(this.gbDesenharTri);
            this.Controls.Add(this.gbTriLinhaPonto);
            this.Controls.Add(this.gbTRIANGULOS);
            this.Controls.Add(this.gbLINHAS);
            this.Controls.Add(this.pnlDesenho);
            this.Controls.Add(this.gbPONTOS);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = ".: FIGURAS :.";
            this.gbPONTOS.ResumeLayout(false);
            this.gbPONTOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdX)).EndInit();
            this.gbLINHAS.ResumeLayout(false);
            this.gbLINHAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEspessuraLinha)).EndInit();
            this.gbTRIANGULOS.ResumeLayout(false);
            this.gbTRIANGULOS.PerformLayout();
            this.gbTriLinhaPonto.ResumeLayout(false);
            this.gbTriLinhaPonto.PerformLayout();
            this.gbDesenharTri.ResumeLayout(false);
            this.gbDesenharTri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEspessuraTri)).EndInit();
            this.gbExtra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPONTOS;
        private System.Windows.Forms.NumericUpDown nupdY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.NumericUpDown nupdX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.ComboBox cmbPontos;
        private System.Windows.Forms.Button btnCriarPonto;
        private System.Windows.Forms.Button btnDesenharPonto;
        private System.Windows.Forms.Panel pnlDesenho;
        private System.Windows.Forms.GroupBox gbLINHAS;
        private System.Windows.Forms.Button btn_desenhar_linha;
        private System.Windows.Forms.ComboBox cmbLinhas;
        private System.Windows.Forms.Button btn_criar_linha;
        private System.Windows.Forms.Label lblPontoB;
        private System.Windows.Forms.Label lblPontoA;
        private System.Windows.Forms.ComboBox cmbPontoA;
        private System.Windows.Forms.ComboBox cmbPontoB;
        private System.Windows.Forms.GroupBox gbTRIANGULOS;
        private System.Windows.Forms.ComboBox cmbPontoA2;
        private System.Windows.Forms.ComboBox cmbPontoB2;
        private System.Windows.Forms.Button btnDesenharTriangulos;
        private System.Windows.Forms.Button btnCriarTriangulo;
        private System.Windows.Forms.Label lblPontoB2;
        private System.Windows.Forms.Label lblPontoA2;
        private System.Windows.Forms.ComboBox cmbPontoC;
        private System.Windows.Forms.Label lblLinhaC;
        private System.Windows.Forms.Label lblPontoC;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox gbTriLinhaPonto;
        private System.Windows.Forms.ComboBox cmbPontoParaTri;
        private System.Windows.Forms.ComboBox cbLinhaParaTri;
        private System.Windows.Forms.Button btnCriarTri2;
        private System.Windows.Forms.Label lblLinhaParaTri;
        private System.Windows.Forms.Label lblPontoParaTri;
        private System.Windows.Forms.ComboBox cmbLinhaParaTri;
        private System.Windows.Forms.Label lblEspessuraLinha;
        private System.Windows.Forms.NumericUpDown nupdEspessuraLinha;
        private System.Windows.Forms.GroupBox gbDesenharTri;
        private System.Windows.Forms.ComboBox cmbTriangulos;
        private System.Windows.Forms.Button btnDesenharTriangulo;
        private System.Windows.Forms.Label lblEspessuraTri;
        private System.Windows.Forms.NumericUpDown nupdEspessuraTri;
        private System.Windows.Forms.Button btnCorDeFundo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btn_preencher;
        private System.Windows.Forms.ComboBox cmb_triang_preencher;
        private System.Windows.Forms.GroupBox gbExtra;
    }
}

