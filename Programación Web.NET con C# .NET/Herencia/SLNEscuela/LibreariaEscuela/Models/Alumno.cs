using System;

namespace LibreariaEscuela.Models
{
    public class Alumno:Persona
    {
        public int NroLegajo { get; set; }

        public Alumno(string nombre, string apellido, int dni, int nroLegajo, DateTime fechaNacimiento):base(nombre, apellido, dni, fechaNacimiento)
        {
            NroLegajo = nroLegajo;
        }
    }
}
