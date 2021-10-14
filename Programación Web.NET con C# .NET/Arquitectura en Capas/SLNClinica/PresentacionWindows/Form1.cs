using System;
using System.Windows.Forms;
using Entidades.Models;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearClinica_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica("Clinica Mayo", "4500 San Pablo Road", "clinicamayo@hotmail.com", "904-953-2000");
            MessageBox.Show(clinica.Nombre + ", " + clinica.Domicilio + ".\nEmail: " + clinica.Email + "\nTelefono: " + clinica.Telefono);
        }

        private void btnCrearHabitacion_Click(object sender, EventArgs e)
        {
            Habitacion habitacion = new Habitacion(1, "Libre");
            MessageBox.Show(habitacion.Numero.ToString() + ", " + habitacion.Estado);
        }
    }
}
