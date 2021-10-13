using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConcesionaria.Models
{
    public class Camioneta
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int NroPuertas { get; set; }
        public string Matricula { get; set; }
        public int Año { get; set; }

        public Camioneta(string marca, string modelo, string color, int nroPuertas, string matricula, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            NroPuertas = nroPuertas;
            Matricula = matricula;
            Año = año;
        }
    }
}
