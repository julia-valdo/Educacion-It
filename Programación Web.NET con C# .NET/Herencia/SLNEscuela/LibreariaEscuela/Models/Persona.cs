using System;

namespace LibreariaEscuela.Models
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(string nombre, string apellido, int dni, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
