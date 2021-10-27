using Datos;
using Datos.Models;
using System;
using System.Data;
using System.Web.UI;

namespace WebClub
{
    public partial class VistaJugador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mostrarJugadores();
                llenarDropPuesto();
                llenarDropBuscarPuesto();
            }            
        }

        private void llenarDropBuscarPuesto()
        {
            DataTable dataTable = AdmJugador.ListarPuestos();
            ddlBuscarPuesto.DataSource = dataTable;
            ddlBuscarPuesto.DataTextField = dataTable.Columns["Puesto"].ToString();

            DataRow fila = dataTable.NewRow();
            fila["Puesto"] = "[Todos]";
            dataTable.Rows.InsertAt(fila, 0);

            ddlBuscarPuesto.DataBind();
        }

        private void llenarDropPuesto()
        {
            DataTable dataTable = AdmJugador.ListarPuestos();
            ddlPuesto.DataSource = dataTable;
            ddlPuesto.DataTextField = dataTable.Columns["Puesto"].ToString();
            ddlPuesto.DataBind();
        }

        private void mostrarJugadores()
        {
            gridJugadores.DataSource = AdmJugador.Listar();

            gridJugadores.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text),
                Puesto = ddlPuesto.SelectedValue.ToString()
            };

            int filasAfectadas = AdmJugador.Insertar(jugador);
            if (filasAfectadas > 0)
                mostrarJugadores();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text),
                Puesto = ddlPuesto.SelectedValue.ToString()
            };

            int filasAfectadas = AdmJugador.Modificar(jugador);
            if (filasAfectadas > 0)
                mostrarJugadores();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int filasAfectadas = AdmJugador.Eliminar(id);
            if (filasAfectadas > 0)
                mostrarJugadores();
        }

        protected void ddlBuscarPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string puesto = ddlBuscarPuesto.SelectedValue;
            if (puesto == "[Todos]")
                mostrarJugadores();
            else
            {
                gridJugadores.DataSource = AdmJugador.TraerJugadores(puesto);
                gridJugadores.DataBind();
            }
        }
    }
}