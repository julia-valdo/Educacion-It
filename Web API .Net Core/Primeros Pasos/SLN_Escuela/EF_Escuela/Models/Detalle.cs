using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Escuela.Models
{
    [Table("Detalle")]
    public class Detalle
    {
        [Key]
        public int IdDetalle { get; set; }

        public int IdPlanilla { get; set; }
        [ForeignKey("IdPlanilla")]
        public Planilla Planilla { get; set; }

        public int IdEstado { get; set; }
        [ForeignKey("IdEstado")]
        public Estado Estado { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }
    }
}
