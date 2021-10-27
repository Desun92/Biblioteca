using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmAltaLibros : Form
    {

        private ArrayList listaLibros = new ArrayList();
        bool vacio = true;
        string rutaImagen="";

        public FrmAltaLibros()
        {
            InitializeComponent();
        }

        public ArrayList GetListaLibros()
        {
            return this.listaLibros;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Libro libroNuevo = null;
            bool error = false;
            bool esta = false;

            if (PctFoto.Image != null)
            {
                if(TxtAutor.Text!= "" && TxtTitulo.Text!= "" && TxtEditorial.Text != "")
                {
                    libroNuevo = new Libro(TxtTitulo.Text, TxtAutor.Text, TxtEditorial.Text, ChkNuevo.Checked, rutaImagen);
                }
                else
                {
                    MessageBox.Show("Faltan campos por rellenar");
                    error = true;
                }
            }
            else
            {
                if (TxtAutor.Text != "" && TxtTitulo.Text != "" && TxtEditorial.Text != "")
                {
                    libroNuevo = new Libro(TxtTitulo.Text, TxtAutor.Text, TxtEditorial.Text, ChkNuevo.Checked);
                }
                else
                {
                    MessageBox.Show("Faltan campos por rellenar");
                    error = true;
                }
            }
            
            if (!vacio && !error)
            {
                foreach (Libro libro in listaLibros)
                {
                    if (libro.GetTitulo() == libroNuevo.GetTitulo())
                    {
                        esta = true;
                        break;
                    }
                }
                if (!esta)
                {
                    listaLibros.Add(libroNuevo);
                    MessageBox.Show("Libro añadido");
                }
                else
                    MessageBox.Show("El libro ya está en la base de datos");
            }
            else if(!error)
            {
                listaLibros.Add(libroNuevo);
                MessageBox.Show("Libro añadido");
                vacio = false;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtAutor.Clear();
            TxtEditorial.Clear();
            TxtTitulo.Clear();
            if (ChkNuevo.Checked == true)
                ChkNuevo.Checked = false;
            PctFoto.Image = null;
        }

        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog.FileName;
                    PctFoto.Image = Image.FromFile(imagen);
                    rutaImagen = imagen;
                }
            }
            catch
            {
                MessageBox.Show("El archivo no es del tipo soportado");
            }
        }
    }
}
