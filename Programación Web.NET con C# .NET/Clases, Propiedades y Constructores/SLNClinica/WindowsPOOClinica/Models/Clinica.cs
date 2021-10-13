namespace WindowsPOOClinica.Models
{
    public class Clinica
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }

        public Clinica(string nombre, string domicilio)
        {
            Nombre = nombre;
            Domicilio = domicilio;
        }
    }
}
