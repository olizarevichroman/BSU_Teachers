using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation.Rules
{
    public class MaxLength<TModel> : BaseValidationRule<TModel>,IValidationRule<TModel>, IValidatableRule<TModel>
    {
        private readonly Expression<Func<TModel, object>> _propertyExpression;

        public MaxLength(Expression<Func<TModel, object>> propertyExpression, int maxValue)
            :base(propertyExpression)
        {
            Value = maxValue;
            _propertyExpression = propertyExpression;
        }

        public override string ErrorMessage => $"Max length is {Value}";

        [JsonIgnore]
        public int Value { get; set; }

        public override bool Validate(TModel model)
        {
            var propertyValue = GetValue(model);

            if (propertyValue == null)
            {
                return false;
            }
            else
            {
                return propertyValue.ToString().Length < Value;
            }
        }
    }
}
