using BSU_Teachers.DataAccessLayer.Contexts;
using BSU_Teachers.DataAccessLayer.Repositories.Interfaces;
using BSU_Teachers.DataLayer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.DataAccessLayer.Repositories.Implementations
{
    public class FacultyRepository : Repository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(CommonContext commonContext)
            : base(commonContext)
        {

        }
    }
}
