using System;

namespace Entidades
{
    public class Autor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }        
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Autor(string nombre, string apellido, string domicilio, string ciudad, string pais, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Ciudad = ciudad;
            Pais = pais;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
