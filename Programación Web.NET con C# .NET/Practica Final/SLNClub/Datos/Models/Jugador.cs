using System;

namespace Datos.Models
{
    public class Jugador:Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public string Puesto { get; set; }

        public Jugador() { }
        public Jugador(int id, string nombre, string apellido, DateTime fechaNacimiento, string puesto) : base(id, nombre, apellido)
        {
            FechaNacimiento = fechaNacimiento;
            Puesto = puesto;
        }
    }
}
