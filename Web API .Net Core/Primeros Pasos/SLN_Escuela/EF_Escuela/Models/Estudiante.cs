using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Escuela.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }

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

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Telefono { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Calle { get; set; }

        public int Numero { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }
    }
}
