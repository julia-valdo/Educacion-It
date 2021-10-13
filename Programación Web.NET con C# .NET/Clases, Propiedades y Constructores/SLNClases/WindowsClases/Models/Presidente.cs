using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClases.Models
{
    class Presidente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pais { get; set; }
        public string Partido { get; set; }
        public DateTime InicioMandato { get; set; }
        public DateTime FinMandato { get; set; }

        public Presidente() { }

        public Presidente(string nombre, string apellido, string pais, string partido, DateTime inicioMandato, DateTime finMandato)
        {
            Nombre = nombre;
            Apellido = apellido;
            Pais = pais;
            Partido = partido;
            InicioMandato = inicioMandato;
            FinMandato = finMandato;
        }
    }
}
