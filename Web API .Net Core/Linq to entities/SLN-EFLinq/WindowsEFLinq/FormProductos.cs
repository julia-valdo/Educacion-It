using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsEFLinq.Data;

namespace WindowsEFLinq
{
    public partial class FormProductos : Form
    {
        NorthwindContext context = new NorthwindContext();

        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            //Traer todos los productos:
            var lista = (from p in context.Products
                         select p).ToList();

            gridProductos.DataSource = lista;
        }

        private void btnTraerPorCategoria_Click(object sender, EventArgs e)
        {
            int categoriaId = 2;

            //Traer por categoria:
            var lista = (from p in context.Products
                         where p.CategoryID == categoriaId
                         select p).ToList();

            gridProductos.DataSource = lista;
        }

        private void btnTraerPorNombreProducto_Click(object sender, EventArgs e)
        {
            string nombrePorducto = "Queso Cabrales";

            //Traer por nombre de producto:
            var producto = (from p in context.Products
                         where p.ProductName == nombrePorducto
                         select p).SingleOrDefault();

            MessageBox.Show(producto.ProductName + " $" + producto.UnitPrice.ToString());
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            int id = 2;

            //Traer por id:
            var producto = (from p in context.Products
                            where p.ProductID == id
                            select p).SingleOrDefault();

            MessageBox.Show(producto.ProductID.ToString() + ". " + producto.ProductName + " $" + producto.UnitPrice.ToString());
        }

        private void btnTraerProductoCategoria_Click(object sender, EventArgs e)
        {
            var lista = (from c in context.Categories
                         join p in context.Products
                         on c.CategoryID equals p.CategoryID
                         select new 
                         {
                             c.CategoryID, 
                             Category = c.CategoryName,
                             Product = p.ProductName, 
                             p.UnitPrice
                         }
                         ).ToList();

            gridProductos.DataSource = lista;
        }
    }
}
