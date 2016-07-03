using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;
using MvcMusicStore.Domain.Entities.Model;

namespace MvcMusicStore.Data.Context.Mapping
{
    public class GenreMap : EntityTypeConfiguration<Genre>
    {
        public GenreMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Name)
                .IsRequired();

            Property(t => t.Description)
                .IsOptional();

            Ignore(t => t.ValidationResult);
        }
    }
}
