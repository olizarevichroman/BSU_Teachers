using Newtonsoft.Json;
using System.Collections.Generic;

namespace BSU_Teachers.Validation
{
    public class ValidationResult<TModel>
    {
        public IList<IValidationRule<TModel>> Errors { get; } = new List<IValidationRule<TModel>>();

        [JsonIgnore]
        public bool Success { get; set; }
    }
}