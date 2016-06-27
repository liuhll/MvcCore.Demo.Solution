using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreDemo.Domain.Entities.Model;

namespace MvcCoreDemo.Data.Context.Mapping
{
    public class ArtistMap : EntityTypeConfiguration<Artist>
    {
        public ArtistMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(50)
                .IsRequired();

            Ignore(t => t.ValidationResult);
        }
    }
}
