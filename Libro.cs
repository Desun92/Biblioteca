using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        private String Titulo;
        private String Autor;
        private String Editorial;
        private Boolean Nuevo;

        public Libro(String titulo, String autor, String editorial, Boolean nuevo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editorial = editorial;
            this.Nuevo = nuevo;
        }

        public String GetTitulo()
        {
            return this.Titulo;
        }

        public String GetAutor()
        {
            return this.Autor;
        }

        public String GetEditorial()
        {
            return this.Editorial;
        }

        public Boolean GetNuevo()
        {
            return this.Nuevo;
        }
    }
}
