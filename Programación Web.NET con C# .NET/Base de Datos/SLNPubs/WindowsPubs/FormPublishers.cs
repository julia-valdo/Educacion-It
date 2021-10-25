using Datos.Admin;
using System;
using System.Windows.Forms;

namespace WindowsPubs
{
    public partial class FormPublishers : Form
    {
        public FormPublishers()
        {
            InitializeComponent();
        }

        private void FormPublishers_Load(object sender, EventArgs e)
        {
            mostrarPublishers();
        }

        private void btnFiltrarCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text.ToString();
            gridPublishers.DataSource = AdmPublisher.Listar(ciudad);
        }

        private void btnFiltrarCiudadEstado_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text.ToString();
            string estado = txtEstado.Text.ToString();
            gridPublishers.DataSource = AdmPublisher.Listar(ciudad, estado);
        }

        private void btnFiltrarCiudadEstadoPais_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text.ToString();
            string estado = txtEstado.Text.ToString();
            string pais = txtCountry.Text.ToString();
            gridPublishers.DataSource = AdmPublisher.Listar(ciudad, estado, pais);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarPublishers();
        }

        private void mostrarPublishers()
        {
            gridPublishers.DataSource = AdmPublisher.Listar();
        }
    }
}
