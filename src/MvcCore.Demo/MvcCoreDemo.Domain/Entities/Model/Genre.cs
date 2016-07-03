using System.Collections.Generic;
using FluentValidation.Results;
using MvcMusicStore.Domain.Interfaces.Validation;

namespace MvcMusicStore.Domain.Entities.Model
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
