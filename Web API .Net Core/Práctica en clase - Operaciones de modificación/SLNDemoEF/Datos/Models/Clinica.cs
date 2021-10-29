using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Clinica")]
    public class Clinica
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaInicioActividades { get; set; }

        public List<Habitacion> Habitaciones { get; set; }
    }
}
