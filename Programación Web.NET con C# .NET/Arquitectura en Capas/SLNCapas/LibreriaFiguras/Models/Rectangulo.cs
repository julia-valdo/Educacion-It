namespace LibreriaFiguras.Models
{
    public class Rectangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Rectangulo (int Base, int Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public int Superficie ()
        {
            return Base * Altura;
        }
    }
}
