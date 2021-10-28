using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Ventas.Models
{
    [Table("Venta")]
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }

        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

        public int IdTrabajador { get; set; }
        [ForeignKey("IdTrabajador")]
        public Trabajador Trabajador { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Required]
        [Column(TypeName = "char")]
        [MaxLength(5)]
        public string TipoComprobante { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Serie { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Correlativo { get; set; }

        public int Igv { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string Estado { get; set; }

        public List<DetalleVenta> DetalleVentas { get; set; }
    }
}
