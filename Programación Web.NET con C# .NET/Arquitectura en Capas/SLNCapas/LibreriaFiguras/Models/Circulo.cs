using System;

namespace LibreriaFiguras.Models
{
    public class Circulo
    {
        public double Radio { get; set; }

        public Circulo (double radio)
        {
            Radio = radio;
        }

        public double Superficie()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
