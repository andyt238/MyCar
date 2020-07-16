using MyCar.Contexts;
using MyCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCarWebApi.Services.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly CarContext _context;

        public UserRepository(CarContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<User> GetAdminUsers()
        {
            return _context.Users
               
                .ToList();
        }
    }
}