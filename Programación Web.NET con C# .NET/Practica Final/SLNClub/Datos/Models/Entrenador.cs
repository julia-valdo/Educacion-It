namespace Datos.Models
{
    public class Entrenador:Persona
    {
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Titulo { get; set; }

        public Entrenador() { }
        public Entrenador(int id, string nombre, string apellido, string domicilio, string telefono, string titulo) : base(id, nombre, apellido)
        {
            Domicilio = domicilio;
            Telefono = telefono;
            Titulo = titulo;
        }
    }
}
