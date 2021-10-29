using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Medico")]
    public class Medico
    {
        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }

        //Propiedad de navegacion:
        public List<Paciente> Pacientes { get; set; }

        public int EspecialidadId { get; set; }

        [ForeignKey("EspecialidadId")]
        public Especialidad Especialidad { get; set; }
    }
}
