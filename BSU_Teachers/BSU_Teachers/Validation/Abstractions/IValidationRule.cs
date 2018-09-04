using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation
{
    public interface IValidationRule<TModel> : IValidatableRule<TModel>
    {
        string ErrorMessage { get; }

        string PropertyName { get; }
    }
}
