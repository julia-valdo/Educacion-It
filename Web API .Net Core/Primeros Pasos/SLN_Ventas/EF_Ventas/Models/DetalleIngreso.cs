using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Ventas.Models
{
    [Table("DetalleIngreso")]
    public class DetalleIngreso
    {
        [Key]
        public int IdDetalleIngreso { get; set; }

        public int IdIngreso { get; set; }

        public int IdArticulo { get; set; }
        [ForeignKey("IdArticulo")]
        public Articulo Articulo { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }

        public int StockInicial { get; set; }

        public int StockActual { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaProduccion { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaVencimiento { get; set; }

        public List<DetalleVenta> DetalleVentas { get; set; }
    }
}
