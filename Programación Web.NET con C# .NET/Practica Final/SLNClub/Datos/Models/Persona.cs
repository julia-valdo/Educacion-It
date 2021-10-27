﻿namespace Datos.Models
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona() { }
        public Persona(int id , string nombre, string apellido) 
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
