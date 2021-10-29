using Datos.Admin;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsEF
{
    public partial class FormMedico : Form
    {
        public FormMedico()
        {
            InitializeComponent();
        }

        private void FormMedico_Load(object sender, EventArgs e)
        {
            mostrarMedicos();
            llenarComboEspecilidad(cbEspecilidad); 
            llenarComboEspecilidad(cbTraerPorEspecilidad);
        }

        private void mostrarMedicos()
        {
            gridMedicos.DataSource = AdmMedico.Listar();
        }

        private void llenarComboEspecilidad(ComboBox comboBox)
        {
            List<Especialidad> especialidades = AdmEspecilidad.Listar();

            if(comboBox == cbTraerPorEspecilidad)
            {
                Especialidad traerTodos = new Especialidad()
                {
                    Nombre = "[TODOS]",
                    Id = 0
                };
                especialidades.Insert(0, traerTodos);
            }
            comboBox.DataSource = especialidades;
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "Id";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Matricula = Convert.ToInt32(txtMatricula.Text),
                EspecialidadId = Convert.ToInt32(cbEspecilidad.SelectedValue)
            };

            int filasAfectadas = AdmMedico.Insertar(medico);
            if (filasAfectadas <= 0)
                MessageBox.Show("Error al cargar el medico");

            mostrarMedicos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                MedicoId = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Matricula = Convert.ToInt32(txtMatricula.Text),
                EspecialidadId = Convert.ToInt32(cbEspecilidad.SelectedValue)
            };

            int filasAfectadas = AdmMedico.Modificar(medico);
            if (filasAfectadas <= 0)
                MessageBox.Show("Error al modificar el medico");
            
            mostrarMedicos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int filasAfectadas = AdmMedico.Eliminar(id);
            if (filasAfectadas <= 0)
                MessageBox.Show("Error al eliminar el medico");

            mostrarMedicos();
        }

        private void cbTraerPorEspecilidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbTraerPorEspecilidad.SelectedValue);
            if (id == 0)
                mostrarMedicos();
            else
                gridMedicos.DataSource = AdmMedico.ListarEspecialidad(id);
        }
    }
}
