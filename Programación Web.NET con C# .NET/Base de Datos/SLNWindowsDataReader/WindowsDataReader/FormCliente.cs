using Datos.Admin;
using Datos.Models;
using System;
using System.Windows.Forms;

namespace WindowsDataReader
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text)
            };

            int filasAfectadas = AdmCliente.Insertar(cliente);

            if (filasAfectadas > 0)
                MessageBox.Show("Fila insertada correctamente");
        }
    }
}
