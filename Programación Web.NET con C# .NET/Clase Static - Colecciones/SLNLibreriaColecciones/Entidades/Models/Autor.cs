using System;

namespace Entidades.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Autor(int id, string apellido, string nombre, string nacionalidad, string ciudad, DateTime fechaNacimiento)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            Nacionalidad = nacionalidad;
            Ciudad = ciudad;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
