
namespace GestaoEscolar
{
    partial class EditarProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProfessor));
            this.gbEditarProfessor = new System.Windows.Forms.GroupBox();
            this.txtbNIF = new System.Windows.Forms.TextBox();
            this.rbtnEfetivo = new System.Windows.Forms.RadioButton();
            this.rbtnContratado = new System.Windows.Forms.RadioButton();
            this.checkbProfissionalizado = new System.Windows.Forms.CheckBox();
            this.btnInserirProf = new System.Windows.Forms.Button();
            this.nupdDias = new System.Windows.Forms.NumericUpDown();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblNifEfetivo = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.lblNomeEfetivo = new System.Windows.Forms.Label();
            this.gbEditarProfessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDias)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEditarProfessor
            // 
            this.gbEditarProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
            this.gbEditarProfessor.Controls.Add(this.txtbNIF);
            this.gbEditarProfessor.Controls.Add(this.rbtnEfetivo);
            this.gbEditarProfessor.Controls.Add(this.rbtnContratado);
            this.gbEditarProfessor.Controls.Add(this.checkbProfissionalizado);
            this.gbEditarProfessor.Controls.Add(this.btnInserirProf);
            this.gbEditarProfessor.Controls.Add(this.nupdDias);
            this.gbEditarProfessor.Controls.Add(this.lblDias);
            this.gbEditarProfessor.Controls.Add(this.lblNifEfetivo);
            this.gbEditarProfessor.Controls.Add(this.txtbNome);
            this.gbEditarProfessor.Controls.Add(this.lblNomeEfetivo);
            this.gbEditarProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(62)))));
            this.gbEditarProfessor.Location = new System.Drawing.Point(12, 12);
            this.gbEditarProfessor.Name = "gbEditarProfessor";
            this.gbEditarProfessor.Size = new System.Drawing.Size(316, 213);
            this.gbEditarProfessor.TabIndex = 1;
            this.gbEditarProfessor.TabStop = false;
            this.gbEditarProfessor.Text = "EDITAR PROFESSOR";
            // 
            // txtbNIF
            // 
            this.txtbNIF.Enabled = false;
            this.txtbNIF.Location = new System.Drawing.Point(103, 53);
            this.txtbNIF.Name = "txtbNIF";
            this.txtbNIF.ReadOnly = true;
            this.txtbNIF.Size = new System.Drawing.Size(173, 23);
            this.txtbNIF.TabIndex = 1;
            // 
            // rbtnEfetivo
            // 
            this.rbtnEfetivo.AutoSize = true;
            this.rbtnEfetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
            this.rbtnEfetivo.Checked = true;
            this.rbtnEfetivo.Location = new System.Drawing.Point(194, 136);
            this.rbtnEfetivo.Name = "rbtnEfetivo";
            this.rbtnEfetivo.Size = new System.Drawing.Size(61, 19);
            this.rbtnEfetivo.TabIndex = 5;
            this.rbtnEfetivo.TabStop = true;
            this.rbtnEfetivo.Text = "Efetivo";
            this.rbtnEfetivo.UseVisualStyleBackColor = false;
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
            // btnInserirProf
            // 
            this.btnInserirProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnInserirProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirProf.FlatAppearance.BorderSize = 0;
            this.btnInserirProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirProf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserirProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.btnInserirProf.Location = new System.Drawing.Point(103, 169);
            this.btnInserirProf.Name = "btnInserirProf";
            this.btnInserirProf.Size = new System.Drawing.Size(173, 23);
            this.btnInserirProf.TabIndex = 6;
            this.btnInserirProf.Text = "EDITAR PROFESSOR";
            this.btnInserirProf.UseVisualStyleBackColor = false;
            this.btnInserirProf.Click += new System.EventHandler(this.btnInserirProf_Click);
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
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(103, 24);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(173, 23);
            this.txtbNome.TabIndex = 0;
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
            // EditarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(340, 237);
            this.Controls.Add(this.gbEditarProfessor);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(62)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: EDITAR PROFESSOR :.";
            this.gbEditarProfessor.ResumeLayout(false);
            this.gbEditarProfessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEditarProfessor;
        private System.Windows.Forms.TextBox txtbNIF;
        private System.Windows.Forms.RadioButton rbtnEfetivo;
        private System.Windows.Forms.RadioButton rbtnContratado;
        private System.Windows.Forms.CheckBox checkbProfissionalizado;
        private System.Windows.Forms.Button btnInserirProf;
        private System.Windows.Forms.NumericUpDown nupdDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblNifEfetivo;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblNomeEfetivo;
    }
}