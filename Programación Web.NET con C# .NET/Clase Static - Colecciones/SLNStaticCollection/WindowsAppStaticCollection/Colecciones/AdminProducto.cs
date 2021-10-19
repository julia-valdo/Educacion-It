using System.Collections.Generic;

namespace WindowsAppStaticCollection.Colecciones
{
    public static class AdminProducto
    {
        public static List<Producto> Listar()
        {
            //TODO Falta implementar Listar(), Select... from Producto
            List<Producto> lista = new List<Producto>()
            {
                new Producto(){CategoriaId = 1, Id = 1, Nombre = "Teclado",   Color = "Negro",  Precio = 1000},
                new Producto(){CategoriaId = 1, Id = 2, Nombre = "Impresora", Color = "Blanco", Precio = 1100},
                new Producto(){CategoriaId = 1, Id = 3, Nombre = "CPU",       Color = "Negro",  Precio = 100000}
            };
            return lista;
        } 
        
        public static List<Producto> Listar(string color)
        {
            //TODO Falta implementar Listar(string color), Select... from Producto where Color
            return null;
        }

        public static List<Producto> Listar(int categoriaId)
        {
            //TODO Falta implementar Listar(int categoriaId), Select... from Producto where CategoriaId
            return null;
        }

        public static Producto TraerUno(int id)
        {
            //TODO Falta implementar TraerUno(int id)
            return null;
        }

        public static int Insertar(Producto producto)
        {
            //TODO Falta implementar Insertar(Producto producto)
            return 0;
        }

        public static int Modificar(Producto producto)
        {
            //TODO Falta implementar Modificar(Producto producto)
            return 0;
        }

        public static int Eliminar(Producto producto)
        {
            //TODO Falta implementar Eliminar(Producto producto)
            return 0;
        }
    }
}
