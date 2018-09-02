using BSU_Teachers.DataAccessLayer.Repositories.Interfaces;
using BSU_Teachers.DataLayer.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BSU_Teachers.Servises.Implementations
{
    public delegate void FacultyChangedEventHandler(Faculty faculty);

    public class FacultyService : IFacultyService
    {

        private readonly IFacultyRepository _facultyRepository;

        public FacultyService(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        public async Task<int> AddFaculty(Faculty faculty)
        {
            return await _facultyRepository.Add(faculty);
        }

        public async Task<int> DeleteFaculty(int id)
        {
            return await _facultyRepository.Detete(id);
        }

        public async Task<IEnumerable<Faculty>> GetAllFaculties()
        {
            return await _facultyRepository.GetAll();
        }

        public async Task<int> UpdateFaculty(Faculty faculty)
        {
            return await _facultyRepository.Update(faculty);
        }
    }
}
