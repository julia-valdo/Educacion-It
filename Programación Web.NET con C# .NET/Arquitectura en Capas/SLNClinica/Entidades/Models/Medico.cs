namespace Entidades.Models
{
    public class Medico
    {
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Especialidad { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Medico(string apellido, string nombre, string matricula, string especialidad, string domicilio, string email, string telefono)
        {
            Apellido = apellido;
            Nombre = nombre;
            Matricula = matricula;
            Especialidad = especialidad;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
        }
    }
}
