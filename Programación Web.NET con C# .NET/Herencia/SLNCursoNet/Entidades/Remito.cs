using System;

namespace Entidades
{
    public class Remito:DocumentoComercial
    {
        public DateTime FechaEntrega { get; set; }

        public Remito(string numero, string cliente, string direccion, string condicionIva, string condicionVenta, string detalle, decimal total, DateTime fecha, DateTime fechaEntrega):base(numero, cliente, direccion, condicionIva, condicionVenta, detalle, total, fecha)
        {
            FechaEntrega = fechaEntrega;
        }
    }
}
