using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation.Rules
{
    public class Required<TModel> : BaseValidationRule<TModel>, IValidationRule<TModel>, IValidatableRule<TModel>
    {
        public Required(Expression<Func<TModel, object>> propertyExpression)
            : base(propertyExpression) { }

        public override string ErrorMessage => "This field is required";

        public override bool Validate(TModel model)
        {
            var propertyValue = GetValue(model)?.ToString();

            return !string.IsNullOrEmpty(propertyValue);
        }
    }
}
