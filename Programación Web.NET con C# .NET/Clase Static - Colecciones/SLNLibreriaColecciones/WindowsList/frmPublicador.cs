using System;
using System.Windows.Forms;
using Entidades.AdminPublicadores;
using Entidades.Models;

namespace WindowsList
{
    public partial class frmPublicador : Form
    {
        public frmPublicador()
        {
            InitializeComponent();
        }

        private void frmPublicador_Load(object sender, EventArgs e)
        {            
            gridPublicador.DataSource = AdminPublicador.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Publicador publicador = new Publicador(Convert.ToInt32(txtId.Text), txtApellido.Text, txtNombre.Text, txtCiudad.Text, Convert.ToDateTime(txtFechaNacimiento.Text));

            AdminPublicador.Insertar(publicador);
            actualizarGriPublicador();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AdminPublicador.Eliminar(Convert.ToInt32(txtId.Text));
            actualizarGriPublicador();
        }

        private void actualizarGriPublicador()
        {
            gridPublicador.DataSource = null;
            gridPublicador.DataSource = AdminPublicador.Listar();
        }        
    }
}
