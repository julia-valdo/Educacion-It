namespace Entidades.Models
{
    public class Paciente:Persona
    {
        public int NroHistoriaClinica { get; set; }

        public Paciente(string apellido, string nombre, int nroHistoriaClinica, string domicilio, string email, string telefono):base(apellido, nombre, domicilio, email, telefono)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        }
    }
}
