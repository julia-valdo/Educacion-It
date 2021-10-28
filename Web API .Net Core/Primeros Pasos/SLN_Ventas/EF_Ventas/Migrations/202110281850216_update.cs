namespace EF_Ventas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Articuloes", newName: "Articulo");
            RenameTable(name: "dbo.DetalleIngresoes", newName: "DetalleIngreso");
            RenameTable(name: "dbo.DetalleVentas", newName: "DetalleVenta");
            RenameTable(name: "dbo.Trabajadors", newName: "Trabajador");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Trabajador", newName: "Trabajadors");
            RenameTable(name: "dbo.DetalleVenta", newName: "DetalleVentas");
            RenameTable(name: "dbo.DetalleIngreso", newName: "DetalleIngresoes");
            RenameTable(name: "dbo.Articulo", newName: "Articuloes");
        }
    }
}
