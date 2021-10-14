namespace LibreriaFiguras.Models
{
    public class Triangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Triangulo (int Base, int Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public int Superficie()
        {
            return Base * Altura / 2;
        }
    }
}
