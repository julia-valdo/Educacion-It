using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Matricula { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ciudad { get; set; }
    }
}
