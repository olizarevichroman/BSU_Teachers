using BSU_Teachers.DataLayer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.DataAccessLayer.Contexts
{
    public class CommonContext : DbContext
    {
        public CommonContext(DbContextOptions dbContextOptions)
            :base(dbContextOptions)
        { }

        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Speciality> Specialities { get; set; }
    }
}
