using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreariaEscuela.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public string Titulo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Profesor() { }
        public Profesor(string nombre, string apellido, int dni, string titulo, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Titulo = titulo;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
