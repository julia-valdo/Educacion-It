using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Ventas.Models
{
    [Table("Articulo")]
    public class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Codigo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Descripcion { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Imagen { get; set; }

        public int IdCategoria { get; set; }

        public int IdPresentacion { get; set; }

        public List<DetalleIngreso> DetalleIngresos { get; set; }
    }
}
