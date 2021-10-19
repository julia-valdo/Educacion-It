using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsList
{
    public partial class frmEmpleado : Form
    {
        List<Empleado> empleados = new List<Empleado>();

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            crearEmpleados();
            gridEmpleados.DataSource = empleados;
        }

        private void crearEmpleados()
        {
            Empleado empleado1 = new Empleado(1, "Julia", "Valdovinos", "Argentina", "Buenos Aires", new DateTime(1998, 01, 21));
            Empleado empleado2 = new Empleado(2, "Wednesday", "Addams", "Estadounidense", "Santa Mónica", new DateTime(1980, 02, 12));
            Empleado empleado3 = new Empleado(3, "Homer", "Simpson", "Estadounidense", "Springfield", new DateTime(1987, 04, 19));

            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado(Convert.ToInt32(txtId.Text), txtApellido.Text, txtNombre.Text, txtNacionalidad.Text, txtCiudad.Text, Convert.ToDateTime(txtFechaNacimiento.Text));
            empleados.Add(empleado);
            actualizarGridEmpleados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            empleados.Remove(empleados.Find(Empleado => Empleado.Nombre == txtNombre.Text));
            actualizarGridEmpleados();
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            foreach (Empleado item in empleados)
            {
                if (item.Id == Convert.ToInt32(txtId.Text))
                    MessageBox.Show(item.Nombre + " " + item.Apellido + "\nNacionalidad: " + item.Nacionalidad + "\nCiudad: " + item.Ciudad + "\nFecha de nacimiento: " + item.FechaNacimiento.ToShortDateString());
            }
            actualizarGridEmpleados();
        }

        private void actualizarGridEmpleados()
        {
            gridEmpleados.DataSource = null;
            gridEmpleados.DataSource = empleados;
        }
    }
}
