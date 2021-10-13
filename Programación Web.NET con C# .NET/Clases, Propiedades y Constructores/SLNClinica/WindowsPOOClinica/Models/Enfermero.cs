using System;

namespace WindowsPOOClinica.Models
{
    public class Enfermero
    {     
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Enfermero() { }

        public Enfermero(string nombre, string apellido, DateTime fechaNacimiento, string domicilio)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Domicilio = domicilio;
        }
    }
}
