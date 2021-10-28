using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Escuela.Models
{
    [Table("Localidad")]
    public class Localidad
    {
        [Key]
        public int IDLocalidad { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public List<Profesor> Profesores { get; set; }

        public List<Estudiante> Estudiantes { get; set; }
    }
}
