﻿using System.ComponentModel.DataAnnotations;

namespace WebApiPersonas.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Twitter { get; set; }
    }
}
