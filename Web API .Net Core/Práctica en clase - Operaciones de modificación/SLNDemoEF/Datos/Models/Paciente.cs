using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Paciente")] //EntityFramework cuando crea la tabla la llama Paciente
    public class Paciente
    {
        public int Id { get; set; }

        [Required] //NOT NULL
        [Column(TypeName = "varchar")] //Tipo de dato de SQL Server
        [MaxLength(50)] //Longitud
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        public int NroHistoriaClinica { get; set; }

        public int MedicoId { get; set; } //ForeignKey clave externa

        //Propiedad de navegacion:
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
    }
}
