using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSU_Teachers.Validation
{
    public class Validator<TModel> : IValidator<TModel> 
    {
        private ValidationResult<TModel> _validationResult;

        public Validator()
        {
            _validationResult = new ValidationResult<TModel>();
            Rules = new List<IValidationRule<TModel>>();
        }

        public IList<IValidationRule<TModel>> Rules { get; set; }

        public ValidationResult<TModel> Validate(TModel model)
        {
            foreach (var rule in Rules)
            {
                if (rule.Validate(model) == false)
                {
                    _validationResult.Errors.Add(rule);
                }
            }

            _validationResult.Success = _validationResult.Errors.Count == 0 ? true : false;

            return _validationResult;
        }
    }
}
