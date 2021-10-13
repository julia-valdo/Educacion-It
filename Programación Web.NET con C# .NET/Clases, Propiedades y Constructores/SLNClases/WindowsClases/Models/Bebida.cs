using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClases.Models
{
    class Bebida
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Calorias { get; set; }
        public int Sodio { get; set; }

        public Bebida() { }

        public Bebida(string nombre, string tipo, int calorias, int sodio)
        {
            Nombre = nombre;
            Tipo = tipo;
            Calorias = calorias;
            Sodio = sodio;
        }
    }    
}
