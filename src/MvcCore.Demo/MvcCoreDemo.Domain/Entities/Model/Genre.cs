using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreDemo.Domain.Interfaces.Validation;
using MvcCoreDemo.Domain.Validation;

namespace MvcCoreDemo.Domain.Entities.Model
{
    public class Genre : AggregateRoot, ISelfValidation
    {
        public Genre()
        {
            Albums = new List<Album>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Album> Albums { get; set; }
        public ValidationResult ValidationResult { get; }
        public bool IsValid { get; }
    }
}
