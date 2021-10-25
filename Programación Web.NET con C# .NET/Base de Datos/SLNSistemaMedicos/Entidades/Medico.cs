namespace Entidades
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NroMatricula { get; set; }
        public int EspecialidadId { get; set; }

        public Medico() { }
        public Medico(string nombre, string apellido, int nroMatricula)
        {
            Nombre = nombre;
            Apellido = apellido;
            NroMatricula = nroMatricula;
        }
    }
}
