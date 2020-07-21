using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCar.Entities
{
    public class Producator
    {
        [Key]

        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string NumeProducator { get; set; }

        [Required]
        [MaxLength(150)]
        public string Model { get; set; }
        public bool? Deleted { get; set; }
    }
}

