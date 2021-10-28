namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 50, unicode: false),
                        PrecioCosto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Margen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Id_Proveedor = c.Int(nullable: false),
                        Id_Categoria = c.Int(nullable: false),
                        Id_SubCategoria = c.Int(nullable: false),
                        Proveedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Id_Categoria, cascadeDelete: true)
                .ForeignKey("dbo.SubCategorias", t => t.Id_SubCategoria, cascadeDelete: true)
                .ForeignKey("dbo.Proveedor", t => t.Proveedor_Id)
                .Index(t => t.Id_Categoria)
                .Index(t => t.Id_SubCategoria)
                .Index(t => t.Proveedor_Id);
            
            CreateTable(
                "dbo.SubCategorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Categoria = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdCategoria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.IdCategoria, cascadeDelete: false)
                .Index(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        CUIT = c.String(nullable: false, maxLength: 50, unicode: false),
                        id_DatosContacto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DatosContacto", t => t.id_DatosContacto, cascadeDelete: true)
                .Index(t => t.id_DatosContacto);
            
            CreateTable(
                "dbo.Proveedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        id_Empresa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empresa", t => t.id_Empresa, cascadeDelete: true)
                .Index(t => t.id_Empresa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "Proveedor_Id", "dbo.Proveedor");
            DropForeignKey("dbo.Proveedor", "id_Empresa", "dbo.Empresa");
            DropForeignKey("dbo.Empresa", "id_DatosContacto", "dbo.DatosContacto");
            DropForeignKey("dbo.Producto", "Id_SubCategoria", "dbo.SubCategorias");
            DropForeignKey("dbo.SubCategorias", "IdCategoria", "dbo.Categorias");
            DropForeignKey("dbo.Producto", "Id_Categoria", "dbo.Categorias");
            DropIndex("dbo.Proveedor", new[] { "id_Empresa" });
            DropIndex("dbo.Empresa", new[] { "id_DatosContacto" });
            DropIndex("dbo.SubCategorias", new[] { "IdCategoria" });
            DropIndex("dbo.Producto", new[] { "Proveedor_Id" });
            DropIndex("dbo.Producto", new[] { "Id_SubCategoria" });
            DropIndex("dbo.Producto", new[] { "Id_Categoria" });
            DropTable("dbo.Proveedor");
            DropTable("dbo.Empresa");
            DropTable("dbo.SubCategorias");
            DropTable("dbo.Producto");
            DropTable("dbo.Categorias");
        }
    }
}
