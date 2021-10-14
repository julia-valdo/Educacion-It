namespace Entidades.Models
{
    class Director
    {
        public Medico Medico { get; set; }
        public string Area { get; set; }

        public Director(Medico medico, string area)
        {
            Medico = medico;
            Area = area;
        }
    }
}
