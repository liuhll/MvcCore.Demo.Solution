using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace MvcCoreDemo.Domain.Validation
{
    public static class ValidationExtension
    {
        public static ValidationResult Add(this ValidationResult validationResult, ValidationResult validationResults)
        {
            if (validationResults == null) return validationResult;

            foreach (var result in validationResults.Errors.Where(r => r != null))
                validationResult.Errors.Add(result);

            return validationResult;
        }
    }
}
