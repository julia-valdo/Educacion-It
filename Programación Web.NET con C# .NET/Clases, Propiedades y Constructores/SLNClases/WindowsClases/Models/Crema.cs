using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClases.Models
{
    class Crema
    {
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public int Contenido { get; set; }

        public Crema() { }

        public Crema(string marca, string tipo, double precio, int contenido)
        {
            Marca = marca;
            Tipo = tipo;
            Precio = precio;
            Contenido = contenido;
        }
    }
}
