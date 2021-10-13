using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConcesionaria.Models
{
    public class Moto
    {
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Matricula { get; set; }
        public int Año { get; set; }

        public Moto(string modelo, string color, string matricula, int año)
        {
            Modelo = modelo;
            Color = color;
            Matricula = matricula;
            Año = año;
        }
    }
}
