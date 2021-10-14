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

namespace WinAppLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void limpiarListBox()
        {
            lstMostrar.Items.Clear();
        }

        public void crearAutor()
        {
            Autor autor = new Autor("Thomas B.", "Allen", "Calle 1", "Bridgeport", "Estados Unidos", new DateTime(1929, 03,20));
            lstMostrar.Items.Add("Autor: " + autor.Nombre + " " + autor.Apellido + ". " + autor.Domicilio + ", " + autor.Ciudad + ", " + autor.Pais + ". " + autor.FechaNacimiento.ToShortDateString());
        }
        public void crearEmpleado()
        {
            Empleado empleado = new Empleado("Julia", "Valdovinos", "Vendedor", new DateTime(2020, 10, 09));
            lstMostrar.Items.Add("Vendido por: " + empleado.Nombre + " " + empleado.Apellido + ", " + empleado.Titulo + " Fecha de ingreso: " + empleado.FechaIngreso.ToShortDateString());
        }
        public void crearPublicador()
        {
            Publicador publicador = new Publicador("Bantam Doubleday Dell Publishing Group Inc", "Calle 123", "New York", "Estado Unidos", "doubleday@hotmail.com");
            lstMostrar.Items.Add("Publicado por: " + publicador.Nombre + ". " + publicador.Domicilio + ", " + publicador.Ciudad + ", " + publicador.Pais + ". Email: " + publicador.Contacto);
        }
        public void crearTitulo()
        {
            Titulo titulo = new Titulo("Thomas B. Allen", "Posesion", "Horror", "La verdadera historia que inspiró el clásico El exorcista", 623.7);
            lstMostrar.Items.Add(titulo._Titulo + ", " + titulo.NombreAutor + ". Categoria: " + titulo.Categoria + ". " + titulo.Notas + ". Precio: $" + titulo.Precio);
        }
        public void crearVenta()
        {
            Venta venta = new Venta("Yenny", "Posesion", 1, 001, new DateTime(2021, 10, 14));
            lstMostrar.Items.Add(venta.Tienda + ". Vendido: " + venta.Titulo + ", " + venta.Cantidad + ". Numero de orden: " + venta.NumeroOrden + ". Fecha: " + venta.Fecha.ToShortDateString());
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            limpiarListBox();
            
            crearVenta();
            crearEmpleado();
            crearTitulo();
            crearAutor();
            crearPublicador();
        }
    }
}
