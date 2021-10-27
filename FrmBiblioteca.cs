using System;
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
    public partial class FrmBiblioteca : Form
    {

        FrmAltaLibros FormAlta;
        FrmConsultaLibros FormConsulta;

        public FrmBiblioteca()
        {
            InitializeComponent();
            Tmr.Enabled = true;
        }

        private void MostrarHora(object sender, EventArgs e)
        {
            LblTimer.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void MnuFicheroAlta_Click(object sender, EventArgs e)
        {
            if (FormAlta == null)
            {
                FormAlta = new FrmAltaLibros();
                FormAlta.MdiParent = this;
                FormAlta.Dock = DockStyle.Fill;
                FormAlta.Show();
                LblHoraActual.Visible = false;
                LblTimer.Visible = false;
            }
            else
                FormAlta.Activate();
        }

        private void MnuFicheroConsulta_Click(object sender, EventArgs e)
        {
            if (FormConsulta == null)
            {
                FormConsulta = new FrmConsultaLibros();

                if(FormAlta!=null)
                    FormConsulta.SetFrmAlta(FormAlta);

                FormConsulta.MdiParent = this;
                FormConsulta.Dock = DockStyle.Fill;
                FormConsulta.Show();
                LblHoraActual.Visible = false;
                LblTimer.Visible = false;
            }
            else
            {
                FormConsulta.SetFrmAlta(FormAlta);
                FormConsulta.Activate();
            }
                
        }

        private void MnuFicheroSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBiblioteca_FormClosing(object sender, FormClosingEventArgs e)
        {
            String mensaje = ("¿Desea realmente salir?");
            String cabecera = ("Salir");
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(mensaje, cabecera, botones);
            if (resultado == DialogResult.No)
                e.Cancel = true;
        }
    }
}
