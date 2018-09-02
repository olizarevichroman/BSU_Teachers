using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.DataLayer.Models.Entities
{
    public class Speciality : IEntity
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }


        public int FacultyId { get; set; }

        [ForeignKey(nameof(FacultyId))]
        public Faculty Faculty { get; set; }
    }
}
