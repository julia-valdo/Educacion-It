using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClases.Models
{
    class Teclado
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }

        public Teclado() { }

        public Teclado(string marca, string modelo, string tipo, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Tipo = tipo;
            Precio = precio;
        }
    }
}
