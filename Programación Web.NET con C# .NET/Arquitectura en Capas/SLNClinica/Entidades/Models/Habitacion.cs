namespace Entidades.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }

        public Habitacion() { }
        public Habitacion(int numero, string estado)
        {
            Numero = numero;
            Estado = estado;
        }
    }
}
