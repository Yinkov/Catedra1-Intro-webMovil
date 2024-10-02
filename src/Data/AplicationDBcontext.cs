using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using catedra1.src.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace catedra1.src.Data
{
    public class AplicationDBcontext(DbContextOptions DbContextOptions) : DbContext (DbContextOptions)
    {
        public DbSet<User> users {get;set;} = null!;
    }
}