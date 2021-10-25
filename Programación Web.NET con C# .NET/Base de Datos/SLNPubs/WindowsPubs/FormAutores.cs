using Datos.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsPubs
{
    public partial class FormAutores : Form
    {
        public FormAutores()
        {
            InitializeComponent();
        }

        private void FormAutores_Load(object sender, EventArgs e)
        {
            mostrarAutores();
            llenarComboCiudad();
        }

        private void btnFiltrarCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text.ToString();
            gridAutores.DataSource = AdmAuthor.Listar(ciudad);
        }

        private void btnFiltrarCiudadEstado_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text.ToString();
            string estado = txtEstado.Text.ToString();
            gridAutores.DataSource = AdmAuthor.Listar(ciudad, estado);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarAutores();
        }

        private void mostrarAutores()
        {
            gridAutores.DataSource = AdmAuthor.Listar();
        }

        private void llenarComboCiudad()
        {
            DataTable Ciudad = AdmAuthor.ListarSoloCiudades();

            cbCiudad.DataSource = Ciudad;
            cbCiudad.DisplayMember = Ciudad.Columns["city"].ToString();
            cbCiudad.ValueMember = Ciudad.Columns["city"].ToString();

            DataRow fila = Ciudad.NewRow();
            fila["city"] = "TRAER TODO";
            Ciudad.Rows.InsertAt(fila, 0);
        }

        private void cbCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ciudad = cbCiudad.SelectedValue.ToString();

            if (ciudad == "TRAER TODO")
                mostrarAutores();
            else
                gridAutores.DataSource = AdmAuthor.ListarDataTable(ciudad);
        }
    }
}
