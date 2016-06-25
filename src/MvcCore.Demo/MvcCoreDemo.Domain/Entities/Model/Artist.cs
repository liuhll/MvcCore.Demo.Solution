using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreDemo.Domain.Interfaces.Validation;
using MvcCoreDemo.Domain.Validation;

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
