using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClases.Models
{
    class SistemaOperativo
    {
        public string Nombre { get; set; }
        public string Desarrollador { get; set; }
        public string Nucleo { get; set; }
        public DateTime Lanzamiento { get; set; }

        public SistemaOperativo() { }

        public SistemaOperativo(string nombre, string desarrollador, string nucleo, DateTime lanzamiento)
        {
            Nombre = nombre;
            Desarrollador = desarrollador;
            Nucleo = nucleo;
            Lanzamiento = lanzamiento;
        }
    }
}
