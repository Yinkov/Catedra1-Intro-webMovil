using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catedra1.src.Data;
using catedra1.src.Interfaces;
using catedra1.src.model;
using Microsoft.EntityFrameworkCore;

namespace catedra1.src.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AplicationDBcontext _aplicationDBcontext;

        public UserRepository(AplicationDBcontext aplicationDBcontext){
            _aplicationDBcontext = aplicationDBcontext;
        }

        public async Task<bool> ExtistsByRut(string rut){
            return await _aplicationDBcontext.users.AnyAsync(u => u.Rut == rut);
        }

        public async Task<List<User>> ListUser(){
            return await _aplicationDBcontext.users.ToListAsync();
        }


    }
}