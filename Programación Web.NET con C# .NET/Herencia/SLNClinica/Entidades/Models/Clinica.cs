namespace Entidades.Models
{
    public class Clinica
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Clinica() { }
        public Clinica(string nombre, string domicilio, string email, string telefono)
        {
            Nombre = nombre;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
        }
    }
}
