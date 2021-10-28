using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Escuela.Models
{
    [Table("Tipo")]
    public class Tipo
    {
        [Key]
        public int IdTipo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }
    }
}
