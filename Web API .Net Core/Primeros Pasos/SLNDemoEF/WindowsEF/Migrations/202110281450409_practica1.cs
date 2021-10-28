namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class practica1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Medicos", newName: "Medico");
            CreateTable(
                "dbo.Clinica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 12, unicode: false),
                        ClinicaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinica", t => t.ClinicaId, cascadeDelete: true)
                .Index(t => t.ClinicaId);
            
            CreateTable(
                "dbo.Especialidad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Medico", "EspecialidadId", c => c.Int(nullable: false));
            CreateIndex("dbo.Medico", "EspecialidadId");
            AddForeignKey("dbo.Medico", "EspecialidadId", "dbo.Especialidad", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medico", "EspecialidadId", "dbo.Especialidad");
            DropForeignKey("dbo.Habitacion", "ClinicaId", "dbo.Clinica");
            DropIndex("dbo.Medico", new[] { "EspecialidadId" });
            DropIndex("dbo.Habitacion", new[] { "ClinicaId" });
            DropColumn("dbo.Medico", "EspecialidadId");
            DropTable("dbo.Especialidad");
            DropTable("dbo.Habitacion");
            DropTable("dbo.Clinica");
            RenameTable(name: "dbo.Medico", newName: "Medicos");
        }
    }
}
