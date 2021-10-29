using Datos.Admin;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsEF
{
    public partial class FormEspecialidad : Form
    {
        public FormEspecialidad()
        {
            InitializeComponent();
        }

        private void FormEspecialidad_Load(object sender, EventArgs e)
        {
            mostrarEspecialidad();
            llenarComboEspecilidad();
        }

        private void mostrarEspecialidad()
        {
            gridEspecialidades.DataSource = AdmEspecilidad.Listar();
        }

        private void llenarComboEspecilidad()
        {
            List<Especialidad> especialidades = AdmEspecilidad.Listar();

            Especialidad traerTodos = new Especialidad()
                {
                    Nombre = "[TODOS]",
                    Id = 0
                };
            especialidades.Insert(0, traerTodos);
            
            cbEspecilidad.DataSource = especialidades;
            cbEspecilidad.DisplayMember = "Nombre";
            cbEspecilidad.ValueMember = "Id";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad()
            {
                Nombre = txtNombre.Text,
            };

            int filasAfectadas = AdmEspecilidad.Insertar(especialidad);
            if (filasAfectadas <= 0)
                MessageBox.Show("Error al cargar la especialidad");

            llenarComboEspecilidad();
            mostrarEspecialidad();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
            };

            int filasAfectadas = AdmEspecilidad.Modificar(especialidad);
            if (filasAfectadas <= 0)
                MessageBox.Show("Error al modificar la especialidad");

            llenarComboEspecilidad();
            mostrarEspecialidad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int filasAfectadas = AdmEspecilidad.Eliminar(id);
            if (filasAfectadas <= 0)
                MessageBox.Show("Error al eliminar la especialidad");

            llenarComboEspecilidad();
            mostrarEspecialidad();
        }

        private void cbEspecilidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbEspecilidad.SelectedValue);
            if (id == 0)
                mostrarEspecialidad();
            else
                gridEspecialidades.DataSource = AdmEspecilidad.TraerPorId(id);
        }
    }
}
