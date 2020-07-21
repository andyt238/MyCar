using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCar.Entities
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        [MaxLength(150)]
        public string FirstName { get; set;  }
        [MaxLength(150)]
        public string LastName { get; set; }
        [MaxLength(150)]
        public string Password { get; set; }
        [MaxLength(150)]
        public bool IsAdmin { get; set; }
        [MaxLength(150)]
        public bool? Deleted { get; set; }

    }
}
