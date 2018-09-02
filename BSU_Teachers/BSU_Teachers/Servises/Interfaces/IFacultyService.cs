using BSU_Teachers.DataLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.Servises
{
    public interface IFacultyService 
    {
        Task<int> AddFaculty(Faculty faculty);

        Task<IEnumerable<Faculty>> GetAllFaculties();

        Task<int> UpdateFaculty(Faculty faculty);

        Task<int> DeleteFaculty(int id);
    }
}
