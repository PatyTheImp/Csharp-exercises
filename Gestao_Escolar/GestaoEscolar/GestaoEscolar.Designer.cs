
namespace GestaoEscolar
{
    partial class GestaoEscolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoEscolar));
            this.menuGestao = new System.Windows.Forms.MenuStrip();
            this.NovoProfessorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarProfessorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestao.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGestao
            // 
            this.menuGestao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.menuGestao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoProfessorMenuItem,
            this.ConsultarProfessorMenuItem});
            this.menuGestao.Location = new System.Drawing.Point(0, 0);
            this.menuGestao.Name = "menuGestao";
            this.menuGestao.Size = new System.Drawing.Size(801, 24);
            this.menuGestao.TabIndex = 3;
            this.menuGestao.Text = "menuStrip1";
            this.menuGestao.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuGestao_ItemClicked);
            // 
            // NovoProfessorMenuItem
            // 
            this.NovoProfessorMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NovoProfessorMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.NovoProfessorMenuItem.Name = "NovoProfessorMenuItem";
            this.NovoProfessorMenuItem.Size = new System.Drawing.Size(105, 20);
            this.NovoProfessorMenuItem.Text = "Novo Professor";
            // 
            // ConsultarProfessorMenuItem
            // 
            this.ConsultarProfessorMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConsultarProfessorMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.ConsultarProfessorMenuItem.Name = "ConsultarProfessorMenuItem";
            this.ConsultarProfessorMenuItem.Size = new System.Drawing.Size(127, 20);
            this.ConsultarProfessorMenuItem.Text = "Consultar Professor";
            // 
            // GestaoEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(801, 472);
            this.Controls.Add(this.menuGestao);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGestao;
            this.Name = "GestaoEscolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: GESTÃO ESCOLAR :.";
            this.Load += new System.EventHandler(this.GestaoEscolar_Load);
            this.menuGestao.ResumeLayout(false);
            this.menuGestao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuGestao;
        private System.Windows.Forms.ToolStripMenuItem NovoProfessorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultarProfessorMenuItem;
    }
}