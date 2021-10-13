using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClases.Models
{
    class Planta
    {
        public string Nombre { get; set; }
        public string Familia { get; set; }
        public string Clase { get; set; }
        public string Orden { get; set; }
 
        public Planta() { }

        public Planta(string nombre, string familia, string clase, string orden)
        {
            Nombre = nombre;
            Familia = familia;
            Clase = clase;
            Orden = orden;
        }
    }
}
