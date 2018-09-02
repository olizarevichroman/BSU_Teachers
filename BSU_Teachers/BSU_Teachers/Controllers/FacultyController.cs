using BSU_Teachers.DataLayer.Models.Entities;
using BSU_Teachers.Servises;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private readonly IFacultyService _facultyService;

        public FacultyController(IFacultyService facultyService)
        {
            _facultyService = facultyService;
        }

        public async Task<IActionResult> GetAll()
        {
            return Ok(await _facultyService.GetAllFaculties());
        }

        public async Task<IActionResult> Delete(Faculty faculty)
        {
            await _facultyService.DeleteFaculty(faculty.Id.Value);
            return NoContent();
        }

        public async Task<IActionResult> Edit(Faculty faculty)
        {
            await _facultyService.UpdateFaculty(faculty);

            return Ok("faculty edited");
        }

        public async Task<IActionResult> AddFaculty(Faculty faculty)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            await _facultyService.AddFaculty(faculty);

            return Ok("Faculty added");
        }

    }
}
