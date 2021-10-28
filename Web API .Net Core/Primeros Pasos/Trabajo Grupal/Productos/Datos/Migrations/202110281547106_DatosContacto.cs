namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatosContacto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DatosContacto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false),
                        Direccion = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DatosContacto");
        }
    }
}
