using System;

namespace LibreariaEscuela.Models
{
    public class Profesor:Persona
    {
        public string Titulo { get; set; }

        public Profesor(string nombre, string apellido, int dni, string titulo, DateTime fechaNacimiento) : base(nombre, apellido, dni, fechaNacimiento)
        {
            Titulo = titulo;
        }
    }
}
