﻿using Datos.Models;
using System.Data.Entity;

namespace Datos
{
    public class DbProductosContext:DbContext
    {
        public DbProductosContext() : base("KeyDBProductos") { }

        public DbSet<DatosContacto> DatosContactos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
