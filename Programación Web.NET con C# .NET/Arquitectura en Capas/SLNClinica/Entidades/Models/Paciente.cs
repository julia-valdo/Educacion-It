namespace Entidades.Models
{
    public class Paciente
    {
        public int ID { get; set; }
        public int NroHistoriaClinica { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }        
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Paciente() { }
        public Paciente(string apellido, string nombre, int nroHistoriaClinica, string domicilio, string email, string telefono)
        {
            Apellido = apellido;
            Nombre = nombre;
            NroHistoriaClinica = nroHistoriaClinica;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
        }
    }
}
