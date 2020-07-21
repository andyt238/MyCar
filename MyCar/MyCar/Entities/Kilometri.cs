using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCar.Entities
{
    public class Kilometri
    {
        [Key]
        public Guid Id {get;set;}
        [Required]
        [MaxLength(150)]
        public string Km { get; set; }

    }
}
