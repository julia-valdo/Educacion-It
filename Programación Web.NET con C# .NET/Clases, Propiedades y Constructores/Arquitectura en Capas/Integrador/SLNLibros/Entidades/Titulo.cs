using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Titulo
    {
        public string NombreAutor { get; set; }
        public string _Titulo { get; set; }
        public string Categoria { get; set; }
        public string Notas { get; set; }
        public double Precio { get; set; }

        public Titulo(string nombreAutor, string titulo, string categoria, string notas, double precio)
        {
            NombreAutor = nombreAutor;
            _Titulo = titulo;
            Categoria = categoria;
            Notas = notas;
            Precio = precio;
        }
    }
}
