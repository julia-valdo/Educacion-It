namespace WindowsPOOClinica.Models
{
    public class Medico
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Matricula { get; set; }

        public Medico(string nombre, string apellido, string matricula)
        {
            Nombre = nombre;
            Apellido = apellido;
            Matricula = matricula;
        }
    }
}
