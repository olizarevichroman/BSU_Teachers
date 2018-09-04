using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation
{
    public interface IValidatableRule<in TModel>
    {
        bool Validate(TModel model);
    }
}
