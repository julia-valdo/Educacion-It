using Datos;
using Entidades;
using System;
using System.Data;

namespace WebMedico
{
    public partial class VistaMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mostrarMedicos();
                llenarDropEspecialidad();
                llenarDropTraerEspecialidad();
            }            
        }

        private void mostrarMedicos()
        {
            gridMedicos.DataSource = AdminMedico.Listar();
            gridMedicos.DataBind();
        }

        private void llenarDropEspecialidad()
        {
            DataTable dataTable = AdminEspecialidad.Listar();
            dropEspecialidad.DataSource = dataTable;
            dropEspecialidad.DataValueField = dataTable.Columns["Id"].ToString();
            dropEspecialidad.DataTextField = dataTable.Columns["Nombre"].ToString();
            dropEspecialidad.DataBind();
        }

        private void llenarDropTraerEspecialidad()
        {
            DataTable dataTable = AdminEspecialidad.Listar();
            dropTraerEspecialidad.DataSource = dataTable;
            dropTraerEspecialidad.DataValueField = dataTable.Columns["Id"].ToString();
            dropTraerEspecialidad.DataTextField = dataTable.Columns["Nombre"].ToString();
            
            DataRow fila = dataTable.NewRow();
            fila["Id"] = 0;
            fila["Nombre"] = "TRAER TODO";
            dataTable.Rows.InsertAt(fila, 0);

            dropTraerEspecialidad.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NroMatricula = Convert.ToInt32(txtNroMatricula.Text),
                EspecialidadId = Convert.ToInt32(dropEspecialidad.SelectedValue)
            };

            int filasAfectadas = AdminMedico.Crear(medico);
            if (filasAfectadas > 0)
                mostrarMedicos();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NroMatricula = Convert.ToInt32(txtNroMatricula.Text),
                EspecialidadId = Convert.ToInt32(dropEspecialidad.SelectedValue)
            };

            int filasAfectadas = AdminMedico.Modificar(medico);
            if (filasAfectadas > 0)
                mostrarMedicos();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int filasAfectadas = AdminMedico.Eliminar(id);
            if (filasAfectadas > 0)
                mostrarMedicos();
        }

        protected void dropTraerEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dropTraerEspecialidad.SelectedValue);
            if (id == 0)
                mostrarMedicos();
            else
            {
                gridMedicos.DataSource = AdminMedico.Listar(id);
                gridMedicos.DataBind();
            }
        }
    }
}