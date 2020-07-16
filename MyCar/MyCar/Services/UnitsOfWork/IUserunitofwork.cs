using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCar.Services.User_unit_of_work
{
    interface IUserunitofwork : IDisposable
    {
        IUserunitofwork Users { get; }

        int Complete();
    }
}
