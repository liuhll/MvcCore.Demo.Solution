using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;
using MvcMusicStore.Domain.Entities.Model;

namespace MvcMusicStore.Data.Context.Mapping
{
    public class AlbumMap : EntityTypeConfiguration<Album>
    {
        public AlbumMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Title)
                .HasMaxLength(160)
                .IsRequired();

            Property(t => t.Price)
                .HasPrecision(5, 2)
                .IsRequired();

            // Relationship
            HasRequired(t => t.Artist)
                .WithMany(t => t.Albums)
                .HasForeignKey(t => t.ArtistId);

            HasRequired(t => t.Genre)
                .WithMany(t => t.Albums)
                .HasForeignKey(t => t.GenreId);

            Ignore(t => t.ValidationResult);
        }
    }
}
