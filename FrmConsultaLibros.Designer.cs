
namespace Biblioteca
{
    partial class FrmConsultaLibros
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
            this.GrpBoxTipoConsulta = new System.Windows.Forms.GroupBox();
            this.RdbAutor = new System.Windows.Forms.RadioButton();
            this.RdbEditorial = new System.Windows.Forms.RadioButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblAutorEditorial = new System.Windows.Forms.Label();
            this.LblFoto = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtAutorEditorial = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrpBoxTipoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxTipoConsulta
            // 
            this.GrpBoxTipoConsulta.Controls.Add(this.RdbEditorial);
            this.GrpBoxTipoConsulta.Controls.Add(this.RdbAutor);
            this.GrpBoxTipoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GrpBoxTipoConsulta.Location = new System.Drawing.Point(38, 31);
            this.GrpBoxTipoConsulta.Name = "GrpBoxTipoConsulta";
            this.GrpBoxTipoConsulta.Size = new System.Drawing.Size(473, 83);
            this.GrpBoxTipoConsulta.TabIndex = 1;
            this.GrpBoxTipoConsulta.TabStop = false;
            this.GrpBoxTipoConsulta.Text = "Tipo Consulta";
            // 
            // RdbAutor
            // 
            this.RdbAutor.AutoSize = true;
            this.RdbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.RdbAutor.Location = new System.Drawing.Point(7, 26);
            this.RdbAutor.Name = "RdbAutor";
            this.RdbAutor.Size = new System.Drawing.Size(71, 26);
            this.RdbAutor.TabIndex = 0;
            this.RdbAutor.TabStop = true;
            this.RdbAutor.Text = "Autor";
            this.RdbAutor.UseVisualStyleBackColor = true;
            // 
            // RdbEditorial
            // 
            this.RdbEditorial.AutoSize = true;
            this.RdbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.RdbEditorial.Location = new System.Drawing.Point(7, 57);
            this.RdbEditorial.Name = "RdbEditorial";
            this.RdbEditorial.Size = new System.Drawing.Size(93, 26);
            this.RdbEditorial.TabIndex = 1;
            this.RdbEditorial.TabStop = true;
            this.RdbEditorial.Text = "Editorial";
            this.RdbEditorial.UseVisualStyleBackColor = true;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblTitulo.Location = new System.Drawing.Point(40, 149);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(60, 25);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Titulo";
            // 
            // LblAutorEditorial
            // 
            this.LblAutorEditorial.AutoSize = true;
            this.LblAutorEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblAutorEditorial.Location = new System.Drawing.Point(259, 149);
            this.LblAutorEditorial.Name = "LblAutorEditorial";
            this.LblAutorEditorial.Size = new System.Drawing.Size(144, 25);
            this.LblAutorEditorial.TabIndex = 3;
            this.LblAutorEditorial.Text = "Autor / Editorial";
            // 
            // LblFoto
            // 
            this.LblFoto.AutoSize = true;
            this.LblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblFoto.Location = new System.Drawing.Point(521, 149);
            this.LblFoto.Name = "LblFoto";
            this.LblFoto.Size = new System.Drawing.Size(124, 25);
            this.LblFoto.TabIndex = 4;
            this.LblFoto.Text = "Foto Portada";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(45, 178);
            this.TxtTitulo.Multiline = true;
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(186, 203);
            this.TxtTitulo.TabIndex = 5;
            // 
            // TxtAutorEditorial
            // 
            this.TxtAutorEditorial.Location = new System.Drawing.Point(264, 177);
            this.TxtAutorEditorial.Multiline = true;
            this.TxtAutorEditorial.Name = "TxtAutorEditorial";
            this.TxtAutorEditorial.Size = new System.Drawing.Size(186, 203);
            this.TxtAutorEditorial.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(538, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 117);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsultaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtAutorEditorial);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.LblFoto);
            this.Controls.Add(this.LblAutorEditorial);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GrpBoxTipoConsulta);
            this.Name = "FrmConsultaLibros";
            this.Text = "Consulta de libros";
            this.GrpBoxTipoConsulta.ResumeLayout(false);
            this.GrpBoxTipoConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxTipoConsulta;
        private System.Windows.Forms.RadioButton RdbAutor;
        private System.Windows.Forms.RadioButton RdbEditorial;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblAutorEditorial;
        private System.Windows.Forms.Label LblFoto;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtAutorEditorial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}