using System;

namespace Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioCosto { get; set; }        
        public decimal PrecioBruto { 
            get 
            {
                return PrecioCosto + Convert.ToDecimal(Margen);
            } 
        }
        public decimal PrecioVenta {
            get
            {
                return PrecioBruto + Convert.ToDecimal(1 + IVA);
            } 
        }

        public Producto(string nombre, string descripcion, string proveedor, string categoria, string subCategoria, double margen, double iva)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
            Margen = margen;
            IVA = iva;
        }

        public Producto()
        {
        }
    }
}
