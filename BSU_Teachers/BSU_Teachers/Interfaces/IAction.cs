using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.Interfaces
{
    interface IAction
    {
        Task<IActionResult> ProcessAsync();
    }
}
