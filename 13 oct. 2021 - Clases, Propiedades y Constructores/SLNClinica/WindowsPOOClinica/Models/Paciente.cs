using System;

namespace WindowsPOOClinica.Models
{
    public class Paciente
    {
        public int ID { get; set; }
        public int NroHistoriaClinica { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Paciente() { }

        #region constructor con parametros
        public Paciente(string Nombre, string apellido, DateTime fechaNacimiento, string domicilio, int nroHistoriaClinica)
        {
            this.Nombre = Nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Domicilio = domicilio;
            NroHistoriaClinica = nroHistoriaClinica;
        }
        #endregion
    }
}
