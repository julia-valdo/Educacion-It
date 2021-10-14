using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public string Cliente { get; set; }
        public string CondicionIva { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }

        public Factura(string tipo, string numero, string cliente, string condicionIva, string condicionVenta, string detalle, decimal total, DateTime fecha)
        {
            Tipo = tipo;
            Numero = numero;
            Cliente = cliente;
            CondicionIva = condicionIva;
            CondicionVenta = condicionVenta;
            Detalle = detalle;
            Total = total;
            Fecha = fecha;
        }
    }
}
