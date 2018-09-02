using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.DataLayer.Models.Entities
{
    public class Faculty : IEntity
    {
        [Key]   
        public int? Id { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage = "Faculty should contains the name")]
        [MaxLength(40)]
        public string Name { get; set; }
    }
}
