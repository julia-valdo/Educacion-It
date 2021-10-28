using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Escuela.Models
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        public int IdPlan { get; set; }

        public int IdCarrera { get; set; }
        [ForeignKey("IdCarrera")]
        public Carrera Carrera { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }
    }
}
