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

        public string Name { get; set; }
    }
}
