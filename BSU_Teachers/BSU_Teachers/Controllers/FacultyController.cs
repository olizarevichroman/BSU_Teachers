using BSU_Teachers.DataLayer.Models.Entities;
using BSU_Teachers.Servises;
using BSU_Teachers.Validation;
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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _facultyService.GetAllFaculties());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Faculty faculty)
        {
            await _facultyService.DeleteFaculty(faculty.Id.Value);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Faculty faculty)
        {
            await _facultyService.UpdateFaculty(faculty);

            return Ok("faculty edited");
        }

        [HttpPost]
        public async Task<IActionResult> Add(Faculty faculty)
        {
            var a = new ValidatorBuilder<Faculty>();
            a.AddRulesFor(f => f.Name)
                .AsRequired()
                .WithMaxLength(20);

            var b = a.Build();

            var c = b.Validate(faculty);
            if (c.Success == false)
            {
                return BadRequest(c);
            }
            

            await _facultyService.AddFaculty(faculty);

            

            return Ok("Faculty added");
        }

    }
}
