using System;

namespace Entidades.Models
{
    public class Publicador
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Publicador(int id, string apellido, string nombre, string ciudad, DateTime fechaNacimiento)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            Ciudad = ciudad;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
