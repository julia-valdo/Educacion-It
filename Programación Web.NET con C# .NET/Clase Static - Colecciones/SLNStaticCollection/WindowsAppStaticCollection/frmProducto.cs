using System;
using System.Windows.Forms;
using WindowsAppStaticCollection.Colecciones;

namespace WindowsAppStaticCollection
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            gridProdcutos.DataSource = AdminProducto.Listar();
        }
    }
}
