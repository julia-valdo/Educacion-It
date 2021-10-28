namespace EF_Ventas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articuloes",
                c => new
                    {
                        IdArticulo = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 100, unicode: false),
                        Imagen = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdCategoria = c.Int(nullable: false),
                        IdPresentacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdArticulo);
            
            CreateTable(
                "dbo.DetalleIngresoes",
                c => new
                    {
                        IdDetalleIngreso = c.Int(nullable: false, identity: true),
                        IdIngreso = c.Int(nullable: false),
                        IdArticulo = c.Int(nullable: false),
                        PrecioCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockInicial = c.Int(nullable: false),
                        StockActual = c.Int(nullable: false),
                        FechaProduccion = c.DateTime(nullable: false, storeType: "date"),
                        FechaVencimiento = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.IdDetalleIngreso)
                .ForeignKey("dbo.Articuloes", t => t.IdArticulo, cascadeDelete: true)
                .Index(t => t.IdArticulo);
            
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        IdDetalleVenta = c.Int(nullable: false, identity: true),
                        IdVenta = c.Int(nullable: false),
                        IdDetalleIngreso = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        PrecioVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetalleVenta)
                .ForeignKey("dbo.DetalleIngresoes", t => t.IdDetalleIngreso, cascadeDelete: true)
                .ForeignKey("dbo.Venta", t => t.IdVenta, cascadeDelete: true)
                .Index(t => t.IdVenta)
                .Index(t => t.IdDetalleIngreso);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        IdVenta = c.Int(nullable: false, identity: true),
                        IdCliente = c.Int(nullable: false),
                        IdTrabajador = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        TipoComprobante = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        Serie = c.String(nullable: false, maxLength: 20, unicode: false),
                        Correlativo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Igv = c.Int(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.IdVenta)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Trabajadors", t => t.IdTrabajador, cascadeDelete: true)
                .Index(t => t.IdCliente)
                .Index(t => t.IdTrabajador);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Sexo = c.String(nullable: false, maxLength: 10, unicode: false),
                        FechaNacimiento = c.DateTime(nullable: false, storeType: "date"),
                        TipoDocumento = c.String(nullable: false, maxLength: 20, unicode: false),
                        NroDocumento = c.Int(nullable: false),
                        Direccion = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Trabajadors",
                c => new
                    {
                        IdTrabajador = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Sexo = c.String(nullable: false, maxLength: 10, unicode: false),
                        FechaNacimiento = c.DateTime(nullable: false, storeType: "date"),
                        NroDocumento = c.Int(nullable: false),
                        Direccion = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 20, unicode: false),
                        Acceso = c.String(nullable: false, maxLength: 20, unicode: false),
                        Usuario = c.String(nullable: false, maxLength: 20, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IdTrabajador);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venta", "IdTrabajador", "dbo.Trabajadors");
            DropForeignKey("dbo.DetalleVentas", "IdVenta", "dbo.Venta");
            DropForeignKey("dbo.Venta", "IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.DetalleVentas", "IdDetalleIngreso", "dbo.DetalleIngresoes");
            DropForeignKey("dbo.DetalleIngresoes", "IdArticulo", "dbo.Articuloes");
            DropIndex("dbo.Venta", new[] { "IdTrabajador" });
            DropIndex("dbo.Venta", new[] { "IdCliente" });
            DropIndex("dbo.DetalleVentas", new[] { "IdDetalleIngreso" });
            DropIndex("dbo.DetalleVentas", new[] { "IdVenta" });
            DropIndex("dbo.DetalleIngresoes", new[] { "IdArticulo" });
            DropTable("dbo.Trabajadors");
            DropTable("dbo.Cliente");
            DropTable("dbo.Venta");
            DropTable("dbo.DetalleVentas");
            DropTable("dbo.DetalleIngresoes");
            DropTable("dbo.Articuloes");
        }
    }
}
