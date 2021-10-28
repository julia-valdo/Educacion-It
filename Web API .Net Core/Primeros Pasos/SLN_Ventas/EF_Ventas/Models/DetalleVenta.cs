using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Ventas.Models
{
    [Table("DetalleVenta")]
    public class DetalleVenta
    {
        [Key]
        public int IdDetalleVenta { get; set; }

        public int IdVenta { get; set; }
        [ForeignKey("IdVenta")]
        public Venta Venta { get; set; }

        public int IdDetalleIngreso { get; set; }
        [ForeignKey("IdDetalleIngreso")]
        public DetalleIngreso DetalleIngreso { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioVenta { get; set; }

        public int Descuento { get; set; }
    }
}
