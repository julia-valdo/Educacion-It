using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTransport
{
    public partial class VistaAuto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mostrarAutos();
                llenarDropListMarca();
                llenarDropListBuscarMarca();
            }
        }

        private void mostrarAutos()
        {
            gridAutos.DataSource = AdmAuto.Listar();
            gridAutos.DataBind();
        }

        private void llenarDropListMarca()
        {
            DataTable marcas = AdmAuto.ListarMarcas();
            ddlMarca.DataSource = marcas;
            ddlMarca.DataValueField = marcas.Columns["Marca"].ToString();
            ddlMarca.DataBind();
        }

        private void llenarDropListBuscarMarca()
        {
            DataTable marcas = AdmAuto.ListarMarcas();
            ddlBuscarMarca.DataSource = marcas;
            ddlBuscarMarca.DataValueField = marcas.Columns["Marca"].ToString();

            DataRow fila = marcas.NewRow();
            fila["Marca"] = "TRAER TODO";
            marcas.Rows.InsertAt(fila, 0);

            ddlBuscarMarca.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto()
            {
                Marca = ddlMarca.SelectedValue,
                Modelo = txtModelo.Text,
                Matricula = txtMatricula.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text)
            };

            int filasAfectadas = AdmAuto.Insertar(auto);
            if (filasAfectadas > 0)
                mostrarAutos();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto()
            {
                Id = Convert.ToInt32(txtId.Text),
                Marca = ddlMarca.SelectedValue,
                Modelo = txtModelo.Text,
                Matricula = txtMatricula.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text)
            };

            int filasAfectadas = AdmAuto.Modificar(auto);
            if (filasAfectadas > 0)
                mostrarAutos();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int filasAfectadas = AdmAuto.Eliminar(id);
            if (filasAfectadas > 0)
                mostrarAutos();
        }

        protected void ddlBuscarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marca = ddlBuscarMarca.SelectedValue;
            if (marca == "TRAER TODO")
                mostrarAutos();
            else
            {
                gridAutos.DataSource = AdmAuto.Listar(marca);
                gridAutos.DataBind();
            }
        }
    }
}