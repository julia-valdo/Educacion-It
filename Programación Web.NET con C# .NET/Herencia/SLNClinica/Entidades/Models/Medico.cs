namespace Entidades.Models
{
    public class Medico:Persona
    {   
        public string Matricula { get; set; }
        public string Especialidad { get; set; }

        public Medico(string apellido, string nombre, string matricula, string especialidad, string domicilio, string email, string telefono):base(apellido, nombre, domicilio, email, telefono)
        {
            Matricula = matricula;
            Especialidad = especialidad;
        }
    }
}
