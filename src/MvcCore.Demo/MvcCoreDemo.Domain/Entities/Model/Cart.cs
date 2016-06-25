using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreDemo.Domain.Interfaces.Validation;
using MvcCoreDemo.Domain.Validation;

namespace MvcCoreDemo.Domain.Entities.Model
{
    public class Cart : AggregateRoot, ISelfValidation
    {
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Album Album { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid { get; }
    }
}
