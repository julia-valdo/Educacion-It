using EF_Ventas.Models;
using System.Data.Entity;

namespace EF_Ventas.Data
{
    public class DbVentasContext : DbContext
    {
        public DbVentasContext() : base("KeyVentas") { }

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<DetalleIngreso> DetalleIngresos { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Venta> Venta { get; set; }
    }
}
