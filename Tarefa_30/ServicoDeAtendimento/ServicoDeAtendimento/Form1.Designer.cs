
namespace ServicoDeAtendimento
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
            this.btnGeral = new System.Windows.Forms.Button();
            this.btnPrioritario = new System.Windows.Forms.Button();
            this.btnBalcao1 = new System.Windows.Forms.Button();
            this.btnBalcao2 = new System.Windows.Forms.Button();
            this.btnBalcao3 = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTituloSenhas = new System.Windows.Forms.Label();
            this.lblTituloBalcao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeral
            // 
            this.btnGeral.Location = new System.Drawing.Point(12, 213);
            this.btnGeral.Name = "btnGeral";
            this.btnGeral.Size = new System.Drawing.Size(75, 23);
            this.btnGeral.TabIndex = 0;
            this.btnGeral.Text = "Geral";
            this.btnGeral.UseVisualStyleBackColor = true;
            this.btnGeral.Click += new System.EventHandler(this.btnGeral_Click);
            // 
            // btnPrioritario
            // 
            this.btnPrioritario.Location = new System.Drawing.Point(93, 213);
            this.btnPrioritario.Name = "btnPrioritario";
            this.btnPrioritario.Size = new System.Drawing.Size(75, 23);
            this.btnPrioritario.TabIndex = 1;
            this.btnPrioritario.Text = "Prioritária";
            this.btnPrioritario.UseVisualStyleBackColor = true;
            this.btnPrioritario.Click += new System.EventHandler(this.btnPrioritario_Click);
            // 
            // btnBalcao1
            // 
            this.btnBalcao1.Location = new System.Drawing.Point(351, 213);
            this.btnBalcao1.Name = "btnBalcao1";
            this.btnBalcao1.Size = new System.Drawing.Size(75, 23);
            this.btnBalcao1.TabIndex = 2;
            this.btnBalcao1.Text = "Balcão 1";
            this.btnBalcao1.UseVisualStyleBackColor = true;
            this.btnBalcao1.Click += new System.EventHandler(this.btnBalcao1_Click);
            // 
            // btnBalcao2
            // 
            this.btnBalcao2.Location = new System.Drawing.Point(432, 213);
            this.btnBalcao2.Name = "btnBalcao2";
            this.btnBalcao2.Size = new System.Drawing.Size(75, 23);
            this.btnBalcao2.TabIndex = 3;
            this.btnBalcao2.Text = "Balcão 2";
            this.btnBalcao2.UseVisualStyleBackColor = true;
            this.btnBalcao2.Click += new System.EventHandler(this.btnBalcao2_Click);
            // 
            // btnBalcao3
            // 
            this.btnBalcao3.Location = new System.Drawing.Point(513, 213);
            this.btnBalcao3.Name = "btnBalcao3";
            this.btnBalcao3.Size = new System.Drawing.Size(75, 23);
            this.btnBalcao3.TabIndex = 4;
            this.btnBalcao3.Text = "Balcão 3";
            this.btnBalcao3.UseVisualStyleBackColor = true;
            this.btnBalcao3.Click += new System.EventHandler(this.btnBalcao3_Click);
            // 
            // lblVez
            // 
            this.lblVez.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVez.AutoSize = true;
            this.lblVez.Location = new System.Drawing.Point(432, 113);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(0, 15);
            this.lblVez.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(62, 113);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(0, 15);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloSenhas
            // 
            this.lblTituloSenhas.AutoSize = true;
            this.lblTituloSenhas.Font = new System.Drawing.Font("Wide Latin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloSenhas.Location = new System.Drawing.Point(12, 15);
            this.lblTituloSenhas.Name = "lblTituloSenhas";
            this.lblTituloSenhas.Size = new System.Drawing.Size(101, 18);
            this.lblTituloSenhas.TabIndex = 7;
            this.lblTituloSenhas.Text = "Senhas";
            this.lblTituloSenhas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloBalcao
            // 
            this.lblTituloBalcao.AutoSize = true;
            this.lblTituloBalcao.Font = new System.Drawing.Font("Wide Latin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloBalcao.Location = new System.Drawing.Point(279, 15);
            this.lblTituloBalcao.Name = "lblTituloBalcao";
            this.lblTituloBalcao.Size = new System.Drawing.Size(309, 18);
            this.lblTituloBalcao.TabIndex = 8;
            this.lblTituloBalcao.Text = "Balcões de Atendimento";
            this.lblTituloBalcao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 257);
            this.Controls.Add(this.lblTituloBalcao);
            this.Controls.Add(this.lblTituloSenhas);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.btnBalcao3);
            this.Controls.Add(this.btnBalcao2);
            this.Controls.Add(this.btnBalcao1);
            this.Controls.Add(this.btnPrioritario);
            this.Controls.Add(this.btnGeral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeral;
        private System.Windows.Forms.Button btnPrioritario;
        private System.Windows.Forms.Button btnBalcao1;
        private System.Windows.Forms.Button btnBalcao2;
        private System.Windows.Forms.Button btnBalcao3;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTituloSenhas;
        private System.Windows.Forms.Label lblTituloBalcao;
    }
}

