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

        public Guid Id { get; set;  }

        [Required]
        [MaxLength(150)]
        public string Nume { get; set;  }

        [Required]
        [MaxLength(150)]
        public string Model { get; set;  }

    }
}
