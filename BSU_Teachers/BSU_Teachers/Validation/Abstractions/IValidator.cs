using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation
{
    public interface IValidator<TModel>
    {
        ValidationResult<TModel> Validate(TModel model);
    }
}
