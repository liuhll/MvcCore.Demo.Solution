using System.Data.Entity.ModelConfiguration;
using MvcCoreDemo.Domain.Entities.Model;

namespace MvcCoreDemo.Data.Context.Mapping
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
