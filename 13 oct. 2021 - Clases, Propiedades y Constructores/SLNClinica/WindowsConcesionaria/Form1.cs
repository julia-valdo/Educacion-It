using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsConcesionaria.Models;

namespace WindowsConcesionaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto("BMW", "Sedan", "Amarillo", 5, "AAA 111", 1935);

            MessageBox.Show(auto.Marca + " " + auto.Modelo + " " + auto.Año + ", " + auto.Color + ", " + auto.NroPuertas + " puertas, " + "matricula: " + auto.Matricula);
        }

        private void btnCrearCamioneta_Click(object sender, EventArgs e)
        {
            Camioneta camioneta = new Camioneta("Chevrolet", "Spin", "Blanco", 5, "FFF 666", 2015);

            MessageBox.Show(camioneta.Marca + " " + camioneta.Modelo + " " + camioneta.Año + ", " + camioneta.Color + ", " + camioneta.NroPuertas + " puertas, " + "matricula: " + camioneta.Matricula);
        }

        private void btnCrearMoto_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto("Scooter", "Negro", "UUU 000", 2006);

            MessageBox.Show(moto.Modelo + " " + moto.Año + ", " + moto.Color + ", " + "matricula: " + moto.Matricula);
        }
    }
}
