using FluentValidation.Results;
using MvcCoreDemo.Domain.Validation;

namespace MvcCoreDemo.Domain.Interfaces.Validation
{
    public interface ISelfValidation
    {
        ValidationResult ValidationResult { get; }
        bool IsValid { get; }
    }
}
