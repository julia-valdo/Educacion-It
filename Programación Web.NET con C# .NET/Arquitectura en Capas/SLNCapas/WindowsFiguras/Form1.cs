using LibreriaFiguras.Models;
using System;
using System.Windows.Forms;

namespace WindowsFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSupCirculo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRadio.Text))
                MessageBox.Show("Ingrese un radio");
            else
            {
                Circulo circulo = new Circulo(Convert.ToDouble(txtRadio.Text));
                MessageBox.Show("Superficie del circulo: " + circulo.Superficie());
            }                        
        }

        private void btnSupTriangulo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBase.Text) || string.IsNullOrEmpty(txtAltura.Text))
                MessageBox.Show("Debe ingresar una base y una altura");
            else
            {
                Triangulo triangulo = new Triangulo(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltura.Text));
                MessageBox.Show("Superficie del triangulo: " + triangulo.Superficie());
            }            
        }

        private void btnSupRectangulo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBase.Text) || string.IsNullOrEmpty(txtAltura.Text))
                MessageBox.Show("Debe ingresar una base y una altura");
            else
            {
                Rectangulo rectangulo = new Rectangulo(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltura.Text));
                MessageBox.Show("Superficie del rectangulo: " + rectangulo.Superficie());
            }            
        }
    }
}
