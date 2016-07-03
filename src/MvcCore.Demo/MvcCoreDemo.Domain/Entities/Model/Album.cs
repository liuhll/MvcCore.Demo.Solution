using System;
using System.Collections.Generic;
using FluentValidation.Results;
using MvcMusicStore.Domain.Interfaces.Validation;

namespace MvcMusicStore.Domain.Entities.Model
{
    public class Album : AggregateRoot, ISelfValidation
    {
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get { throw new NotImplementedException(); }
        }
    }
}
