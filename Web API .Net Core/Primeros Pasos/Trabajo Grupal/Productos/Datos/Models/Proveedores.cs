using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Proveedor")]
    public class Proveedor
    {       
        public int Id { get; set; }

        public List<Producto> Productos { get; set; }

        public int id_Empresa { get; set; }
        [ForeignKey("id_Empresa")]
        public Empresa Empresa { get; set; }
    }
}
