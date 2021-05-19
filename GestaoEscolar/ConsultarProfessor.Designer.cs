
namespace GestaoEscolar
{
    partial class ConsultarProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProfessor));
            this.lvConsultar = new System.Windows.Forms.ListView();
            this.columnNIF = new System.Windows.Forms.ColumnHeader();
            this.columnNome = new System.Windows.Forms.ColumnHeader();
            this.columnEscalao = new System.Windows.Forms.ColumnHeader();
            this.columnProfissionalizado = new System.Windows.Forms.ColumnHeader();
            this.columnDias = new System.Windows.Forms.ColumnHeader();
            this.columnTipo = new System.Windows.Forms.ColumnHeader();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.txtbConsultar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvConsultar
            // 
            this.lvConsultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvConsultar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNIF,
            this.columnNome,
            this.columnEscalao,
            this.columnProfissionalizado,
            this.columnDias,
            this.columnTipo});
            this.lvConsultar.FullRowSelect = true;
            this.lvConsultar.GridLines = true;
            this.lvConsultar.HideSelection = false;
            this.lvConsultar.Location = new System.Drawing.Point(12, 45);
            this.lvConsultar.Name = "lvConsultar";
            this.lvConsultar.Size = new System.Drawing.Size(681, 266);
            this.lvConsultar.TabIndex = 0;
            this.lvConsultar.UseCompatibleStateImageBehavior = false;
            this.lvConsultar.View = System.Windows.Forms.View.Details;
            this.lvConsultar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvConsultar_MouseDoubleClick);
            // 
            // columnNIF
            // 
            this.columnNIF.Text = "NIF";
            this.columnNIF.Width = 112;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 112;
            // 
            // columnEscalao
            // 
            this.columnEscalao.Text = "Escalão";
            this.columnEscalao.Width = 112;
            // 
            // columnProfissionalizado
            // 
            this.columnProfissionalizado.Text = "Profissionalizado";
            this.columnProfissionalizado.Width = 112;
            // 
            // columnDias
            // 
            this.columnDias.Text = "Dias de Serviço";
            this.columnDias.Width = 112;
            // 
            // columnTipo
            // 
            this.columnTipo.Text = "Tipo de Professor";
            this.columnTipo.Width = 112;
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(62)))));
            this.lblConsultar.Location = new System.Drawing.Point(12, 18);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(124, 15);
            this.lblConsultar.TabIndex = 1;
            this.lblConsultar.Text = "Consultar professores:";
            // 
            // txtbConsultar
            // 
            this.txtbConsultar.Location = new System.Drawing.Point(142, 15);
            this.txtbConsultar.Name = "txtbConsultar";
            this.txtbConsultar.Size = new System.Drawing.Size(187, 23);
            this.txtbConsultar.TabIndex = 2;
            this.txtbConsultar.TextChanged += new System.EventHandler(this.txtbConsultar_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.btnConsultar.Location = new System.Drawing.Point(335, 16);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.btnEditar.Location = new System.Drawing.Point(608, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ConsultarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(707, 323);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtbConsultar);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.lvConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: CONSULTAR PROFESSORES :.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvConsultar;
        private System.Windows.Forms.ColumnHeader columnNIF;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.TextBox txtbConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ColumnHeader columnEscalao;
        private System.Windows.Forms.ColumnHeader columnProfissionalizado;
        private System.Windows.Forms.ColumnHeader columnDias;
        private System.Windows.Forms.ColumnHeader columnTipo;
        private System.Windows.Forms.Button btnEditar;
    }
}