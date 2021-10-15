using System;

namespace Entidades
{
    public class DocumentoComercial
    {
        public string Numero { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIva { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }

        public DocumentoComercial(string numero, string cliente, string direccion, string condicionIva, string condicionVenta, string detalle, decimal total, DateTime fecha)
        {
            Numero = numero;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIva = condicionIva;
            CondicionVenta = condicionVenta;
            Detalle = detalle;
            Total = total;
            Fecha = fecha;
        }
    }
}
