using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Escuela.Models
{
    [Table("Carrera")]
    public class Carrera
    {
        [Key]
        public int IdCarrera { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public List<Planilla> Planillas { get; set; }

        public List<Plan> Planes { get; set; }
    }
}
