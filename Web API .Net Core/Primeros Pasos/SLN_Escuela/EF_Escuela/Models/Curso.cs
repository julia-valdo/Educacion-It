using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Escuela.Models
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public List<Planilla> Planillas { get; set; }
    }
}
