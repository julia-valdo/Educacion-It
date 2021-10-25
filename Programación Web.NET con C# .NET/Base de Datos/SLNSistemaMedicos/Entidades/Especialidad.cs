namespace Entidades
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Especialidad() { }
        public Especialidad(string nombre)
        {
            Nombre = nombre;
        }
    }
}
