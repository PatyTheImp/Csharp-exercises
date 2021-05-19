
namespace GestaoEscolar
{
    partial class FecharMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FecharMes));
            this.btnFecharMes = new System.Windows.Forms.Button();
            this.lblDiasUteis = new System.Windows.Forms.Label();
            this.lvSalarios = new System.Windows.Forms.ListView();
            this.columnNif = new System.Windows.Forms.ColumnHeader();
            this.columnSalarioBase = new System.Windows.Forms.ColumnHeader();
            this.columnSalarioLiquido = new System.Windows.Forms.ColumnHeader();
            this.columnMes = new System.Windows.Forms.ColumnHeader();
            this.columnAno = new System.Windows.Forms.ColumnHeader();
            this.nupdDiasUteis = new System.Windows.Forms.NumericUpDown();
            this.lblMes = new System.Windows.Forms.Label();
            this.nupdAno = new System.Windows.Forms.NumericUpDown();
            this.lblAno = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDiasUteis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFecharMes
            // 
            this.btnFecharMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnFecharMes.FlatAppearance.BorderSize = 0;
            this.btnFecharMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharMes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFecharMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.btnFecharMes.Location = new System.Drawing.Point(495, 14);
            this.btnFecharMes.Name = "btnFecharMes";
            this.btnFecharMes.Size = new System.Drawing.Size(85, 23);
            this.btnFecharMes.TabIndex = 9;
            this.btnFecharMes.Text = "Fechar Mês";
            this.btnFecharMes.UseVisualStyleBackColor = false;
            this.btnFecharMes.Click += new System.EventHandler(this.btnFecharMes_Click);
            // 
            // lblDiasUteis
            // 
            this.lblDiasUteis.AutoSize = true;
            this.lblDiasUteis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(62)))));
            this.lblDiasUteis.Location = new System.Drawing.Point(12, 17);
            this.lblDiasUteis.Name = "lblDiasUteis";
            this.lblDiasUteis.Size = new System.Drawing.Size(58, 15);
            this.lblDiasUteis.TabIndex = 6;
            this.lblDiasUteis.Text = "Dias Úteis";
            // 
            // lvSalarios
            // 
            this.lvSalarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSalarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNif,
            this.columnSalarioBase,
            this.columnSalarioLiquido,
            this.columnMes,
            this.columnAno});
            this.lvSalarios.FullRowSelect = true;
            this.lvSalarios.GridLines = true;
            this.lvSalarios.HideSelection = false;
            this.lvSalarios.Location = new System.Drawing.Point(12, 44);
            this.lvSalarios.Name = "lvSalarios";
            this.lvSalarios.Size = new System.Drawing.Size(568, 266);
            this.lvSalarios.TabIndex = 5;
            this.lvSalarios.UseCompatibleStateImageBehavior = false;
            this.lvSalarios.View = System.Windows.Forms.View.Details;
            // 
            // columnNif
            // 
            this.columnNif.Text = "NIF";
            this.columnNif.Width = 112;
            // 
            // columnSalarioBase
            // 
            this.columnSalarioBase.Text = "Salário Base";
            this.columnSalarioBase.Width = 112;
            // 
            // columnSalarioLiquido
            // 
            this.columnSalarioLiquido.Text = "Salário Líquido";
            this.columnSalarioLiquido.Width = 112;
            // 
            // columnMes
            // 
            this.columnMes.Text = "Mês";
            this.columnMes.Width = 112;
            // 
            // columnAno
            // 
            this.columnAno.Text = "Ano";
            this.columnAno.Width = 112;
            // 
            // nupdDiasUteis
            // 
            this.nupdDiasUteis.Location = new System.Drawing.Point(76, 12);
            this.nupdDiasUteis.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nupdDiasUteis.Name = "nupdDiasUteis";
            this.nupdDiasUteis.Size = new System.Drawing.Size(73, 23);
            this.nupdDiasUteis.TabIndex = 10;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(62)))));
            this.lblMes.Location = new System.Drawing.Point(173, 17);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(29, 15);
            this.lblMes.TabIndex = 11;
            this.lblMes.Text = "Mês";
            // 
            // nupdAno
            // 
            this.nupdAno.Location = new System.Drawing.Point(383, 12);
            this.nupdAno.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nupdAno.Name = "nupdAno";
            this.nupdAno.Size = new System.Drawing.Size(73, 23);
            this.nupdAno.TabIndex = 14;
            this.nupdAno.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(62)))));
            this.lblAno.Location = new System.Drawing.Point(348, 17);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 15);
            this.lblAno.TabIndex = 13;
            this.lblAno.Text = "Ano";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cmbMes.Location = new System.Drawing.Point(208, 14);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 23);
            this.cmbMes.TabIndex = 15;
            // 
            // FecharMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(586, 326);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.nupdAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.nupdDiasUteis);
            this.Controls.Add(this.btnFecharMes);
            this.Controls.Add(this.lblDiasUteis);
            this.Controls.Add(this.lvSalarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FecharMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: FECHAR MÊS :.";
            ((System.ComponentModel.ISupportInitialize)(this.nupdDiasUteis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecharMes;
        private System.Windows.Forms.Label lblDiasUteis;
        private System.Windows.Forms.ListView lvSalarios;
        private System.Windows.Forms.ColumnHeader columnNif;
        private System.Windows.Forms.ColumnHeader columnSalarioLiquido;
        private System.Windows.Forms.ColumnHeader columnProfissionalizado;
        private System.Windows.Forms.ColumnHeader columnDias;
        private System.Windows.Forms.ColumnHeader columnTipo;
        private System.Windows.Forms.NumericUpDown nupdDiasUteis;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.NumericUpDown nupdAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ColumnHeader columnSalarioBase;
        private System.Windows.Forms.ColumnHeader columnMes;
        private System.Windows.Forms.ColumnHeader columnAno;
    }
}