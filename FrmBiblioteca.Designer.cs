
namespace Biblioteca
{
    partial class FrmBiblioteca
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MnuFichero = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFicheroAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFicheroConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFicheroSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuFichero
            // 
            this.MnuFichero.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFicheroAlta,
            this.MnuFicheroConsulta,
            this.toolStripSeparator1,
            this.MnuFicheroSalir});
            this.MnuFichero.Name = "MnuFichero";
            this.MnuFichero.Size = new System.Drawing.Size(58, 20);
            this.MnuFichero.Text = "Fichero";
            // 
            // MnuFicheroAlta
            // 
            this.MnuFicheroAlta.Name = "MnuFicheroAlta";
            this.MnuFicheroAlta.Size = new System.Drawing.Size(180, 22);
            this.MnuFicheroAlta.Text = "Alta";
            // 
            // MnuFicheroConsulta
            // 
            this.MnuFicheroConsulta.Name = "MnuFicheroConsulta";
            this.MnuFicheroConsulta.Size = new System.Drawing.Size(180, 22);
            this.MnuFicheroConsulta.Text = "Consulta";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuFicheroSalir
            // 
            this.MnuFicheroSalir.Name = "MnuFicheroSalir";
            this.MnuFicheroSalir.Size = new System.Drawing.Size(180, 22);
            this.MnuFicheroSalir.Text = "Salir";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichero});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBiblioteca";
            this.Text = "Gestión Bibilioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem MnuFichero;
        private System.Windows.Forms.ToolStripMenuItem MnuFicheroAlta;
        private System.Windows.Forms.ToolStripMenuItem MnuFicheroConsulta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuFicheroSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

