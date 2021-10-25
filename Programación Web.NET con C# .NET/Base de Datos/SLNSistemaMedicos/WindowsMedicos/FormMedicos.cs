using Datos;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsMedicos
{
    public partial class FormMedicos : Form
    {
        public FormMedicos()
        {
            InitializeComponent();
        }

        private void FormMedicos_Load(object sender, EventArgs e)
        {
            mostrarMedicos();
            llenarComboEspecialidad();
            llenarComboTraerEspecialidad();
        }

        private void llenarComboEspecialidad()
        {
            DataTable Especialidad = AdminEspecialidad.Listar();

            cbEspecialidad.DataSource = Especialidad;
            cbEspecialidad.DisplayMember = Especialidad.Columns["Nombre"].ToString();
            cbEspecialidad.ValueMember = Especialidad.Columns["Id"].ToString();
        }

        private void llenarComboTraerEspecialidad()
        {
            DataTable Especialidad = AdminEspecialidad.Listar();

            cbTraerEspecialidad.DataSource = Especialidad;
            cbTraerEspecialidad.DisplayMember = Especialidad.Columns["Nombre"].ToString();
            cbTraerEspecialidad.ValueMember = Especialidad.Columns["Id"].ToString();

            DataRow fila = Especialidad.NewRow();
            fila["Id"] = 0;
            fila["Nombre"] = "TRAER TODO";
            Especialidad.Rows.InsertAt(fila, 0);
        }

        private void mostrarMedicos()
        {
            gridMedicos.DataSource = AdminMedico.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NroMatricula = Convert.ToInt32(txtNroMatricula.Text),
                EspecialidadId = Convert.ToInt32(cbEspecialidad.SelectedValue)
            };

            int filasAfectadas = AdminMedico.Crear(medico);
            if (filasAfectadas <= 0)
                MessageBox.Show("Error al cargar el medico");

            mostrarMedicos();
        }

        private void cbTraerEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbTraerEspecialidad.SelectedValue);

            if (id == 0)
                mostrarMedicos();
            else
                gridMedicos.DataSource = AdminMedico.Listar(id);
        }

        private void btnCrearEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad()
            {
                Nombre = txtCrearEspecialidad.Text
            };

            int filasAfectadas = AdminEspecialidad.Crear(especialidad);
            if (filasAfectadas <= 0)
                MessageBox.Show("Error al cargar la especialidad");

            llenarComboEspecialidad();
            llenarComboTraerEspecialidad();
        }
    }
}
