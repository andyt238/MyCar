using Microsoft.EntityFrameworkCore;
using MyCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCar.Contexts
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Accidente> Accidente { get; set; }
        public DbSet<Kilometri> Kilometri { get; set; }



    }
}
