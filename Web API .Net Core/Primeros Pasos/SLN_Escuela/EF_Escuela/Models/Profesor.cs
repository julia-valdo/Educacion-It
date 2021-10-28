using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Escuela.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        [Key]
        public int IdProfesor { get; set; }

        public int IdLocalidad { get; set; }
        [ForeignKey("IdLocalidad")]
        public Localidad Localidad { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }

        public List<Planilla> Planillas { get; set; }
    }
}
