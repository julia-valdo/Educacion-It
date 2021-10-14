using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreariaEscuela.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public int NroLegajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Alumno() { }
        public Alumno(string nombre, string apellido, int dni, int nroLegajo, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            NroLegajo = nroLegajo;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
