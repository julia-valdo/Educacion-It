using System;

namespace Entidades
{
    public class Factura:DocumentoComercial
    {
        public string Tipo { get; set; }

        public Factura(string tipo, string numero, string cliente, string direccion, string condicionIva, string condicionVenta, string detalle, decimal total, DateTime fecha):base(numero, cliente, direccion, condicionIva, condicionVenta, detalle, total, fecha)
        {
            Tipo = tipo;
        }
    }
}
