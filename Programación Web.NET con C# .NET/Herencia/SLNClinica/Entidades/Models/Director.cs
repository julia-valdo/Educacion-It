namespace Entidades.Models
{
    public class Director:Medico
    {
        public string Area { get; set; }

        public Director(string apellido, string nombre, string matricula, string especialidad, string domicilio, string email, string telefono, string area):base(apellido, nombre, matricula, especialidad, domicilio, email, telefono)
        {
            Area = area;
        }
    }
}
