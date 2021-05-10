
namespace GestaoEscolar
{
    partial class NovoProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoProfessor));
            this.gbNovoProfessor = new System.Windows.Forms.GroupBox();
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.rbtnEfetivo = new System.Windows.Forms.RadioButton();
            this.rbtnContratado = new System.Windows.Forms.RadioButton();
            this.checkbProfissionalizado = new System.Windows.Forms.CheckBox();
            this.btnGoEfetivo = new System.Windows.Forms.Button();
            this.nupdDias = new System.Windows.Forms.NumericUpDown();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblNifEfetivo = new System.Windows.Forms.Label();
            this.txtbNomeEfetivo = new System.Windows.Forms.TextBox();
            this.lblNomeEfetivo = new System.Windows.Forms.Label();
            this.gbNovoProfessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDias)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNovoProfessor
            // 
            this.gbNovoProfessor.Controls.Add(this.tbNIF);
            this.gbNovoProfessor.Controls.Add(this.rbtnEfetivo);
            this.gbNovoProfessor.Controls.Add(this.rbtnContratado);
            this.gbNovoProfessor.Controls.Add(this.checkbProfissionalizado);
            this.gbNovoProfessor.Controls.Add(this.btnGoEfetivo);
            this.gbNovoProfessor.Controls.Add(this.nupdDias);
            this.gbNovoProfessor.Controls.Add(this.lblDias);
            this.gbNovoProfessor.Controls.Add(this.lblNifEfetivo);
            this.gbNovoProfessor.Controls.Add(this.txtbNomeEfetivo);
            this.gbNovoProfessor.Controls.Add(this.lblNomeEfetivo);
            this.gbNovoProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(62)))));
            this.gbNovoProfessor.Location = new System.Drawing.Point(12, 12);
            this.gbNovoProfessor.Name = "gbNovoProfessor";
            this.gbNovoProfessor.Size = new System.Drawing.Size(316, 213);
            this.gbNovoProfessor.TabIndex = 0;
            this.gbNovoProfessor.TabStop = false;
            this.gbNovoProfessor.Text = "NOVO PROFESSOR";
            // 
            // tbNIF
            // 
            this.tbNIF.Location = new System.Drawing.Point(103, 53);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(173, 23);
            this.tbNIF.TabIndex = 1;
            // 
            // rbtnEfetivo
            // 
            this.rbtnEfetivo.AutoSize = true;
            this.rbtnEfetivo.Checked = true;
            this.rbtnEfetivo.Location = new System.Drawing.Point(194, 136);
            this.rbtnEfetivo.Name = "rbtnEfetivo";
            this.rbtnEfetivo.Size = new System.Drawing.Size(61, 19);
            this.rbtnEfetivo.TabIndex = 5;
            this.rbtnEfetivo.TabStop = true;
            this.rbtnEfetivo.Text = "Efetivo";
            this.rbtnEfetivo.UseVisualStyleBackColor = true;
            this.rbtnEfetivo.CheckedChanged += new System.EventHandler(this.rbtnEfetivo_CheckedChanged);
            // 
            // rbtnContratado
            // 
            this.rbtnContratado.AutoSize = true;
            this.rbtnContratado.Location = new System.Drawing.Point(103, 136);
            this.rbtnContratado.Name = "rbtnContratado";
            this.rbtnContratado.Size = new System.Drawing.Size(85, 19);
            this.rbtnContratado.TabIndex = 4;
            this.rbtnContratado.TabStop = true;
            this.rbtnContratado.Text = "Contratado";
            this.rbtnContratado.UseVisualStyleBackColor = true;
            this.rbtnContratado.CheckedChanged += new System.EventHandler(this.rbtnContratado_CheckedChanged);
            // 
            // checkbProfissionalizado
            // 
            this.checkbProfissionalizado.AutoSize = true;
            this.checkbProfissionalizado.Checked = true;
            this.checkbProfissionalizado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbProfissionalizado.Enabled = false;
            this.checkbProfissionalizado.Location = new System.Drawing.Point(103, 111);
            this.checkbProfissionalizado.Name = "checkbProfissionalizado";
            this.checkbProfissionalizado.Size = new System.Drawing.Size(115, 19);
            this.checkbProfissionalizado.TabIndex = 3;
            this.checkbProfissionalizado.Text = "Profissionalizado";
            this.checkbProfissionalizado.UseVisualStyleBackColor = true;
            // 
            // btnGoEfetivo
            // 
            this.btnGoEfetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnGoEfetivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoEfetivo.FlatAppearance.BorderSize = 0;
            this.btnGoEfetivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoEfetivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoEfetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.btnGoEfetivo.Location = new System.Drawing.Point(103, 169);
            this.btnGoEfetivo.Name = "btnGoEfetivo";
            this.btnGoEfetivo.Size = new System.Drawing.Size(173, 23);
            this.btnGoEfetivo.TabIndex = 6;
            this.btnGoEfetivo.Text = "INSERIR PROFESSOR";
            this.btnGoEfetivo.UseVisualStyleBackColor = false;
            this.btnGoEfetivo.Click += new System.EventHandler(this.btnGoEfetivo_Click);
            // 
            // nupdDias
            // 
            this.nupdDias.Location = new System.Drawing.Point(103, 82);
            this.nupdDias.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nupdDias.Name = "nupdDias";
            this.nupdDias.Size = new System.Drawing.Size(173, 23);
            this.nupdDias.TabIndex = 2;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(11, 84);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(86, 15);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "Dias de Serviço";
            // 
            // lblNifEfetivo
            // 
            this.lblNifEfetivo.AutoSize = true;
            this.lblNifEfetivo.Location = new System.Drawing.Point(72, 57);
            this.lblNifEfetivo.Name = "lblNifEfetivo";
            this.lblNifEfetivo.Size = new System.Drawing.Size(25, 15);
            this.lblNifEfetivo.TabIndex = 2;
            this.lblNifEfetivo.Text = "NIF";
            // 
            // txtbNomeEfetivo
            // 
            this.txtbNomeEfetivo.Location = new System.Drawing.Point(103, 24);
            this.txtbNomeEfetivo.Name = "txtbNomeEfetivo";
            this.txtbNomeEfetivo.Size = new System.Drawing.Size(173, 23);
            this.txtbNomeEfetivo.TabIndex = 0;
            // 
            // lblNomeEfetivo
            // 
            this.lblNomeEfetivo.AutoSize = true;
            this.lblNomeEfetivo.Location = new System.Drawing.Point(57, 27);
            this.lblNomeEfetivo.Name = "lblNomeEfetivo";
            this.lblNomeEfetivo.Size = new System.Drawing.Size(40, 15);
            this.lblNomeEfetivo.TabIndex = 0;
            this.lblNomeEfetivo.Text = "Nome";
            // 
            // NovoProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(340, 237);
            this.Controls.Add(this.gbNovoProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovoProfessor";
            this.Text = ".: NOVO PROFESSOR :.";
            this.gbNovoProfessor.ResumeLayout(false);
            this.gbNovoProfessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNovoProfessor;
        private System.Windows.Forms.Label lblNifEfetivo;
        private System.Windows.Forms.TextBox txtbNomeEfetivo;
        private System.Windows.Forms.Label lblNomeEfetivo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.NumericUpDown nupdDias;
        private System.Windows.Forms.Button btnGoEfetivo;
        private System.Windows.Forms.CheckBox checkbProfissionalizado;
        private System.Windows.Forms.RadioButton rbtnEfetivo;
        private System.Windows.Forms.RadioButton rbtnContratado;
        private System.Windows.Forms.TextBox tbNIF;
    }
}

