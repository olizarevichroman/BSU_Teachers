using BSU_Teachers.Validation.Abstractions;
using BSU_Teachers.Validation.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation.Implementations
{
    public class PropertyValidatorBuilder<TModel> : IPropertyValidatorBuilder<TModel>
    {
        private readonly Expression<Func<TModel, object>> _propertyExpression;
        private readonly IList<IValidationRule<TModel>> _rules;

        public PropertyValidatorBuilder(Expression<Func<TModel, object>> propertyExpression
            ,IList<IValidationRule<TModel>> rules)
        {
            _propertyExpression = propertyExpression;
            _rules = rules;
        }

        public IPropertyValidatorBuilder<TModel> WithMaxLength(int maxLength)
        {
            _rules.Add(new MaxLength<TModel>(_propertyExpression, maxLength));

            return this;           
        }

        public IPropertyValidatorBuilder<TModel> AsRequired()
        {
            _rules.Add(new Required<TModel>(_propertyExpression));

            return this;
        }
    }
}
