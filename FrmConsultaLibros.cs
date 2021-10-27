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
    public partial class FrmConsultaLibros : Form
    {

        FrmAltaLibros FormAlta;
        ArrayList ListaLibros = new ArrayList();
        ArrayList ListaAutores = new ArrayList();
        ArrayList ListaEditoriales = new ArrayList();
        ArrayList ListaTitulos = new ArrayList();

        public FrmConsultaLibros()
        {
            InitializeComponent();
            RdbAutor.Checked = false;
            RdbEditorial.Checked = false;
        }

        public void SetFrmAlta(FrmAltaLibros alta)
        {
            this.FormAlta = alta;
        }

        private void RdbAutor_CheckedChanged(object sender, EventArgs e)
        {
            if (FormAlta != null && RdbAutor.Checked==true)
            {
                RdbAutor.Checked = true;
                RdbEditorial.Checked = false;
                bool esta = false; 
                ListaLibros = FormAlta.GetListaLibros();

                foreach(Libro libro in ListaLibros)
                {
                    string autor = libro.GetAutor();
                    foreach(string nombreAutor in ListaAutores)
                    {
                        esta = false;
                        if(nombreAutor==autor)
                        {
                            esta = true;
                            break;
                        }
                    }
                    if (!esta)
                    {
                        ListaAutores.Add(libro.GetAutor());
                        ListaAutores.Sort();
                    }
                }

                LstAutorEditorial.DataSource = null;
                LstAutorEditorial.DataSource = ListaAutores;
            }
            else if(FormAlta == null && RdbAutor.Checked==true)
            {
                RdbAutor.Checked = true;
                RdbEditorial.Checked = false;
                MessageBox.Show("No hay datos que mostrar");
            }
        }

        private void RdbEditorial_CheckedChanged(object sender, EventArgs e)
        {
            if (FormAlta != null && RdbEditorial.Checked == true)
            {
                RdbAutor.Checked = false;
                RdbEditorial.Checked = true;
                bool esta = false;
                ListaLibros = FormAlta.GetListaLibros();

                foreach (Libro libro in ListaLibros)
                {
                    string editorial = libro.GetEditorial();
                    foreach (string nombreEditorial in ListaEditoriales)
                    {
                        esta = false;
                        if (nombreEditorial == editorial)
                        {
                            esta = true;
                            break;
                        }
                    }
                    if (!esta)
                    {
                        ListaEditoriales.Add(libro.GetEditorial());
                        ListaEditoriales.Sort();
                    }
                }

                LstAutorEditorial.DataSource = null;
                LstAutorEditorial.DataSource = ListaEditoriales;
            }
            else if (FormAlta == null && RdbEditorial.Checked == true)
            {
                RdbAutor.Checked = false;
                RdbEditorial.Checked = true;
                MessageBox.Show("No hay datos que mostrar");
            }
        }

        private void LstAutorEditorial_Click(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox) sender;
            string autorEditorial = listBox.SelectedItem.ToString();
            ListaLibros = FormAlta.GetListaLibros();
            ListaTitulos.Clear();
            bool rdbAutor = false;
            bool rdbEditorial = false;
            string titulo;
            bool esta = false;

            if (RdbAutor.Checked == true)
                rdbAutor = true;

            foreach(Libro libro in ListaLibros)
            {
                if (rdbAutor == true)
                {
                    if (libro.GetAutor() == autorEditorial)
                    {
                        ListaTitulos.Add(libro.GetTitulo());
                    }
                }
                else
                {
                    if (libro.GetEditorial() == autorEditorial)
                    {
                        ListaTitulos.Add(libro.GetTitulo());
                    }
                }
            }
            ListaTitulos.Sort();
            LstTitulo.DataSource = null;
            LstTitulo.DataSource = ListaTitulos;
        }

        private void LstTitulo_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            string titulo = listBox.SelectedItem.ToString();

            foreach(Libro libro in ListaLibros)
            {
                if(libro.GetTitulo() == titulo)
                {
                    string ruta = libro.GetRutaPortada();
                    PctFoto.Image = Image.FromFile(ruta);
                    break;
                }
            }
        }
    }
}
