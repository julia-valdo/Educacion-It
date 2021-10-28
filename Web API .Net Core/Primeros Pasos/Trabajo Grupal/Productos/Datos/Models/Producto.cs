using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Producto")]
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Descripcion { get; set; }

        public decimal PrecioCosto { get; set; }
        public decimal Margen { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_SubCategoria { get; set; }

        [ForeignKey("Id_Proveedor")]
        public Proveedor Proveedor { get; set; }

        [ForeignKey("Id_Categoria")]
        public Categoria Categoria { get; set; }

        [ForeignKey("Id_SubCategoria")]
        public SubCategoria SubCategoria { get; set; }
    }
}
