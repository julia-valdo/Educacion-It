using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public string Tienda { get; set; }
        public string Titulo { get; set; }
        public int NumeroOrden { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public Venta(string tienda, string titulo, int cantidad, int numeroOrden, DateTime fecha)
        {
            Tienda = tienda;
            Titulo = titulo;
            NumeroOrden = numeroOrden;
            Cantidad = cantidad;
            Fecha = fecha;
        }
    }
}
