using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation.Abstractions
{
    public interface IPropertyValidatorBuilder<TModel>
    {
        IPropertyValidatorBuilder<TModel> AsRequired();

        IPropertyValidatorBuilder<TModel> WithMaxLength(int maxLength);
    }
}
