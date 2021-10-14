using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto("Sprite", "Bebida gaseosa con sabor a Lima limon", "The Coca-Cola Company", "Bebida", "Gaseosa", 5, 0.21);
            MessageBox.Show(producto.Nombre + ", " + producto.Descripcion + ".\nProveedor: " + producto.Proveedor + ".\nDescripcion: " + producto.Categoria + ", " + producto.SubCategoria + ".\nMargen: " + producto.Margen + ", IVA: " + producto.IVA*100 + "%");
        }

        private void btnCrearEmpresa_Click(object sender, EventArgs e)
        {
            ClienteEmpresa empresa = new ClienteEmpresa("Carrefour", "30-58462038-9", "Lunes a Domingo 9:00 a 18:00 hs.", "carrefour@hotmail.com", "0 800 444 8484", "Calle 123");
            MessageBox.Show(empresa.Nombre + "\nCUIT: " + empresa.CUIT + "\nContacto: " + empresa.Contacto + "\nEmail: " + empresa.Email + "\nTelefono: " + empresa.Telefono + "\nDireccion: " + empresa.Direccion);
        }

        private void btnCrearIndividuo_Click(object sender, EventArgs e)
        {
            ClienteIndividuo individuo = new ClienteIndividuo("Julia", "Valdovinos", "0-1234567-89", "valdojuli@hotmail.com", "4444-4444", "Av. siempreviva 572");
            MessageBox.Show(individuo.Nombre + " " + individuo.Apellido + ", " + individuo.CUIT + "\nEmail: " + individuo.Email + "\nTelefono: " + individuo.Telefono + "\nDireccion: " + individuo.Direccion);
        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura("A", "12345", "Julia Valdovinos", "Responsable Inscripto", "Consumidor Final", "Compra de bebida gaseosa", 126, new DateTime(2021, 10, 14));
            MessageBox.Show("Cliente: " + factura.Cliente + ".\nFactura Tipo: " + factura.Tipo + ", " + factura.CondicionVenta + ", " + factura.CondicionIva + "\nDetalle: " + factura.Detalle + ", total: $" + factura.Total + "\nFecha: " + factura.Fecha.ToShortDateString());
        }

        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor("The Coca-Cola Company", "30-12345678-9", "Lunes a Domingo 9:00 a 17:00", "cocacola@hotmail.com", "0800-888-8888", "Atlanta, Georgia, Estados Unidos");
            MessageBox.Show(proveedor.Nombre + "\nCUIT: " + proveedor.CUIT + "\nContacto: " + proveedor.Contacto + "\nEmail: " + proveedor.Email + "\nTelefono: " + proveedor.Telefono + "\nDireccion: " + proveedor.Direccion);
        }

        private void btnCrearRemito_Click(object sender, EventArgs e)
        {
            Remito remito = new Remito("000000", "Julia Valdovinos", "Calle 123", "Responsable Inscripto", "Consumidor Final", "Compra de bebida gaseosa", 126, new DateTime(2021, 10, 14), new DateTime(2021, 10, 15));
            MessageBox.Show("Cliente: " + remito.Cliente + ".\nRemito numero: " + remito.Numero + ", " + remito.CondicionVenta + ", " + remito.CondicionIva + "\nDetalle: " + remito.Detalle + ", total: $" + remito.Total + "\nDireccion: " + remito.Direccion + "\nFecha: " + remito.Fecha.ToShortDateString() + ", fecha de entrega: " + remito.FechaEntrega.ToShortDateString());
        }

        private void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor("John", "Pemberton", "12345678", "vendedor@hotmail.com", "0 800 000 001", "Knoxville, Georgia, Estados Unidos");
            MessageBox.Show(vendedor.Nombre + " " + vendedor.Apellido + ", " + vendedor.DNI + "\nEmail: " + vendedor.Email + "\nTelefono: " + vendedor.Telefono + "\nDireccion: " + vendedor.Direccion);
        }
    }
}
