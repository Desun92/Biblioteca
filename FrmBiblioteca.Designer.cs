
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
            this.components = new System.ComponentModel.Container();
            this.MnuFichero = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFicheroAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFicheroConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFicheroSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            this.LblHoraActual = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
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
            this.MnuFicheroAlta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MnuFicheroAlta.Size = new System.Drawing.Size(163, 22);
            this.MnuFicheroAlta.Text = "Alta";
            this.MnuFicheroAlta.Click += new System.EventHandler(this.MnuFicheroAlta_Click);
            // 
            // MnuFicheroConsulta
            // 
            this.MnuFicheroConsulta.Name = "MnuFicheroConsulta";
            this.MnuFicheroConsulta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MnuFicheroConsulta.Size = new System.Drawing.Size(163, 22);
            this.MnuFicheroConsulta.Text = "Consulta";
            this.MnuFicheroConsulta.Click += new System.EventHandler(this.MnuFicheroConsulta_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // MnuFicheroSalir
            // 
            this.MnuFicheroSalir.Name = "MnuFicheroSalir";
            this.MnuFicheroSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MnuFicheroSalir.Size = new System.Drawing.Size(163, 22);
            this.MnuFicheroSalir.Text = "Salir";
            this.MnuFicheroSalir.Click += new System.EventHandler(this.MnuFicheroSalir_Click);
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
            // Tmr
            // 
            this.Tmr.Tick += new System.EventHandler(this.MostrarHora);
            // 
            // LblHoraActual
            // 
            this.LblHoraActual.AutoSize = true;
            this.LblHoraActual.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblHoraActual.Location = new System.Drawing.Point(507, 378);
            this.LblHoraActual.Name = "LblHoraActual";
            this.LblHoraActual.Size = new System.Drawing.Size(114, 25);
            this.LblHoraActual.TabIndex = 5;
            this.LblHoraActual.Text = "Hora Actual";
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblTimer.Location = new System.Drawing.Point(627, 378);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(26, 25);
            this.LblTimer.TabIndex = 6;
            this.LblTimer.Text = "A";
            // 
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.LblHoraActual);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBiblioteca";
            this.Text = "Gestión Bibilioteca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBiblioteca_FormClosing);
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
        private System.Windows.Forms.Timer Tmr;
        private System.Windows.Forms.Label LblHoraActual;
        private System.Windows.Forms.Label LblTimer;
    }
}

