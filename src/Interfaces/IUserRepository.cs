using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catedra1.src.model;

namespace catedra1.src.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> ExtistsByRut(string rut);

        Task<List<User>> ListUser();
    }
}