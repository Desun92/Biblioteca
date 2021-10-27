
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
            this.RdbEditorial = new System.Windows.Forms.RadioButton();
            this.RdbAutor = new System.Windows.Forms.RadioButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblAutorEditorial = new System.Windows.Forms.Label();
            this.LblFoto = new System.Windows.Forms.Label();
            this.PctFoto = new System.Windows.Forms.PictureBox();
            this.LstTitulo = new System.Windows.Forms.ListBox();
            this.LstAutorEditorial = new System.Windows.Forms.ListBox();
            this.GrpBoxTipoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
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
            // RdbEditorial
            // 
            this.RdbEditorial.AutoSize = true;
            this.RdbEditorial.Cursor = System.Windows.Forms.Cursors.Default;
            this.RdbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.RdbEditorial.Location = new System.Drawing.Point(7, 57);
            this.RdbEditorial.Name = "RdbEditorial";
            this.RdbEditorial.Size = new System.Drawing.Size(93, 26);
            this.RdbEditorial.TabIndex = 1;
            this.RdbEditorial.Text = "Editorial";
            this.RdbEditorial.UseVisualStyleBackColor = true;
            this.RdbEditorial.CheckedChanged += new System.EventHandler(this.RdbEditorial_CheckedChanged);
            // 
            // RdbAutor
            // 
            this.RdbAutor.AutoSize = true;
            this.RdbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.RdbAutor.Location = new System.Drawing.Point(7, 26);
            this.RdbAutor.Name = "RdbAutor";
            this.RdbAutor.Size = new System.Drawing.Size(71, 26);
            this.RdbAutor.TabIndex = 0;
            this.RdbAutor.Text = "Autor";
            this.RdbAutor.UseVisualStyleBackColor = true;
            this.RdbAutor.CheckedChanged += new System.EventHandler(this.RdbAutor_CheckedChanged);
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
            // PctFoto
            // 
            this.PctFoto.Location = new System.Drawing.Point(538, 199);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(85, 117);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 7;
            this.PctFoto.TabStop = false;
            // 
            // LstTitulo
            // 
            this.LstTitulo.FormattingEnabled = true;
            this.LstTitulo.Location = new System.Drawing.Point(45, 178);
            this.LstTitulo.Name = "LstTitulo";
            this.LstTitulo.Size = new System.Drawing.Size(142, 173);
            this.LstTitulo.TabIndex = 8;
            this.LstTitulo.DoubleClick += new System.EventHandler(this.LstTitulo_DoubleClick);
            // 
            // LstAutorEditorial
            // 
            this.LstAutorEditorial.FormattingEnabled = true;
            this.LstAutorEditorial.Location = new System.Drawing.Point(264, 177);
            this.LstAutorEditorial.Name = "LstAutorEditorial";
            this.LstAutorEditorial.Size = new System.Drawing.Size(142, 173);
            this.LstAutorEditorial.TabIndex = 9;
            this.LstAutorEditorial.Click += new System.EventHandler(this.LstAutorEditorial_Click);
            // 
            // FrmConsultaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.LstAutorEditorial);
            this.Controls.Add(this.LstTitulo);
            this.Controls.Add(this.PctFoto);
            this.Controls.Add(this.LblFoto);
            this.Controls.Add(this.LblAutorEditorial);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GrpBoxTipoConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaLibros";
            this.Text = "Consulta de libros";
            this.GrpBoxTipoConsulta.ResumeLayout(false);
            this.GrpBoxTipoConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
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
        private System.Windows.Forms.PictureBox PctFoto;
        private System.Windows.Forms.ListBox LstTitulo;
        private System.Windows.Forms.ListBox LstAutorEditorial;
    }
}