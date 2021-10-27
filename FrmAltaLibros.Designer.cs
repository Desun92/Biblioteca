
namespace Biblioteca
{
    partial class FrmAltaLibros
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.LblNuevo = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.ChkNuevo = new System.Windows.Forms.CheckBox();
            this.LblFotoPortada = new System.Windows.Forms.Label();
            this.PctFoto = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCargarFoto = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(75, 71);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(60, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Titulo";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.Location = new System.Drawing.Point(76, 119);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(59, 25);
            this.LblAutor.TabIndex = 1;
            this.LblAutor.Text = "Autor";
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblEditorial.Location = new System.Drawing.Point(76, 169);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(81, 25);
            this.LblEditorial.TabIndex = 2;
            this.LblEditorial.Text = "Editorial";
            // 
            // LblNuevo
            // 
            this.LblNuevo.AutoSize = true;
            this.LblNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblNuevo.Location = new System.Drawing.Point(76, 219);
            this.LblNuevo.Name = "LblNuevo";
            this.LblNuevo.Size = new System.Drawing.Size(69, 25);
            this.LblNuevo.TabIndex = 3;
            this.LblNuevo.Text = "Nuevo";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(236, 75);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(162, 20);
            this.TxtTitulo.TabIndex = 4;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(236, 123);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(162, 20);
            this.TxtAutor.TabIndex = 5;
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(236, 173);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(162, 20);
            this.TxtEditorial.TabIndex = 6;
            // 
            // ChkNuevo
            // 
            this.ChkNuevo.AutoSize = true;
            this.ChkNuevo.Location = new System.Drawing.Point(236, 226);
            this.ChkNuevo.Name = "ChkNuevo";
            this.ChkNuevo.Size = new System.Drawing.Size(15, 14);
            this.ChkNuevo.TabIndex = 7;
            this.ChkNuevo.UseVisualStyleBackColor = true;
            // 
            // LblFotoPortada
            // 
            this.LblFotoPortada.AutoSize = true;
            this.LblFotoPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblFotoPortada.Location = new System.Drawing.Point(537, 70);
            this.LblFotoPortada.Name = "LblFotoPortada";
            this.LblFotoPortada.Size = new System.Drawing.Size(124, 25);
            this.LblFotoPortada.TabIndex = 8;
            this.LblFotoPortada.Text = "Foto Portada";
            // 
            // PctFoto
            // 
            this.PctFoto.Location = new System.Drawing.Point(557, 119);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(85, 117);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 9;
            this.PctFoto.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(81, 284);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(76, 34);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(236, 284);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(70, 34);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCargarFoto
            // 
            this.BtnCargarFoto.Location = new System.Drawing.Point(557, 284);
            this.BtnCargarFoto.Name = "BtnCargarFoto";
            this.BtnCargarFoto.Size = new System.Drawing.Size(76, 34);
            this.BtnCargarFoto.TabIndex = 12;
            this.BtnCargarFoto.Text = "Cargar Foto";
            this.BtnCargarFoto.UseVisualStyleBackColor = true;
            this.BtnCargarFoto.Click += new System.EventHandler(this.BtnCargarFoto_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FrmAltaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.BtnCargarFoto);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.PctFoto);
            this.Controls.Add(this.LblFotoPortada);
            this.Controls.Add(this.ChkNuevo);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.LblNuevo);
            this.Controls.Add(this.LblEditorial);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de libros";
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Label LblNuevo;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.CheckBox ChkNuevo;
        private System.Windows.Forms.Label LblFotoPortada;
        private System.Windows.Forms.PictureBox PctFoto;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCargarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}