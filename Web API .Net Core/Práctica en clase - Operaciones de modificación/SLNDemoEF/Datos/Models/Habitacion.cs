using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Habitacion")]
    public class Habitacion
    {
        [Key]
        public int Id { get; set; }

        public int Numero { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(12)]
        public string Estado { get; set; }

        public int ClinicaId { get; set; }

        [ForeignKey("ClinicaId")]
        public Clinica Clinica { get; set; }
    }
}
