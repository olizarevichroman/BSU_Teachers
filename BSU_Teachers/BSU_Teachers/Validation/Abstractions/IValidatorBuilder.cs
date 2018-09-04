using BSU_Teachers.Validation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation
{
    public interface IValidatorBuilder<TModel>
    {
        IValidator<TModel> Build();

        IPropertyValidatorBuilder<TModel> AddRulesFor(Expression<Func<TModel, object>> propertyExpression);
    }
}
