namespace Entidades.Models
{
    public abstract class Persona
    {
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Persona(string apellido, string nombre, string domicilio, string email, string telefono)
        {
            Apellido = apellido;
            Nombre = nombre;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
        }
    }
}
