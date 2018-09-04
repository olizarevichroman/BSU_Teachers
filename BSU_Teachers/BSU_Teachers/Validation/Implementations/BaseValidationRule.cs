using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation
{
    public abstract class BaseValidationRule<TModel> : IValidationRule<TModel>
    {
        private Expression<Func<TModel, object>> _propertyExpression;

        public BaseValidationRule(Expression<Func<TModel, object>> propertyExpression)
        {
            _propertyExpression = propertyExpression;
            PropertyName = GetPropertyName();
        }

        public abstract string ErrorMessage { get; }

        public abstract bool Validate(TModel model);

        public string PropertyName { get; set; }

        protected object GetValue(TModel model)
        {
            var del = _propertyExpression.Compile();
            return del(model);
        }

        private string GetPropertyName()
        {
            var propertyMemberExpression = _propertyExpression.Body as MemberExpression;
            return propertyMemberExpression.Member.Name;
        }
    }
}
