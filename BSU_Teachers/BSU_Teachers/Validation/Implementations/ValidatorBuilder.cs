using BSU_Teachers.Validation.Abstractions;
using BSU_Teachers.Validation.Implementations;
using BSU_Teachers.Validation.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation
{
    public class ValidatorBuilder<TModel> : IValidatorBuilder<TModel>
    {
        private readonly Validator<TModel> _validator;

        public ValidatorBuilder()
        {
            _validator = new Validator<TModel>();
        }

        public IPropertyValidatorBuilder<TModel> AddRulesFor(Expression<Func<TModel, object>> propertyExpression)
        {
            return new PropertyValidatorBuilder<TModel>(propertyExpression, _validator.Rules);
        }

        public IValidator<TModel> Build() => _validator;
    }
}
