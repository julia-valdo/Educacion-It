using Datos.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsDataReader
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            mostrarProductos();
            llenarComboCategoria();
        }

        private void btnTraerPorCategoriaID_Click(object sender, EventArgs e)
        {
            int categoriaId = Convert.ToInt32(txtCategoriaID.Text);
            gridProductos.DataSource = AdmProduct.Listar(categoriaId);
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void llenarComboCategoria()
        {
            DataTable Categoria = AdmCategory.Listar();

            cbCategoria.DataSource = Categoria;
            cbCategoria.DisplayMember = Categoria.Columns["CategoryName"].ToString();
            cbCategoria.ValueMember = Categoria.Columns["CategoryID"].ToString();

            //Agregar una fila al DataTable "Categoria" en memoria
            DataRow fila = Categoria.NewRow();
            fila["CategoryID"] = 0;
            fila["CategoryName"] = "TRAER TODO";
            Categoria.Rows.InsertAt(fila, 0);
        }

        private void cbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //SelectedValue captura el id "ValueMember"
            int categoriaId = Convert.ToInt32(cbCategoria.SelectedValue);

            if (categoriaId == 0)
                mostrarProductos();
            else
                gridProductos.DataSource = AdmProduct.Listar(categoriaId);
        }

        private void mostrarProductos()
        {
            gridProductos.DataSource = AdmProduct.Listar();
        }
    }
}
