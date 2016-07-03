using System.Collections.Generic;
using FluentValidation.Results;
using MvcCoreDemo.Domain.Interfaces.Validation;

namespace MvcCoreDemo.Domain.Entities.Model
{
    public class Artist : AggregateRoot, ISelfValidation
    {
        public string Name { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public ValidationResult ValidationResult { get; }
        public bool IsValid { get; }
    }
}
