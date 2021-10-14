using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Empleado(string nombre, string apellido, string titulo, DateTime fechaIngreso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Titulo = titulo;
            FechaIngreso = fechaIngreso;
        }
    }
}
