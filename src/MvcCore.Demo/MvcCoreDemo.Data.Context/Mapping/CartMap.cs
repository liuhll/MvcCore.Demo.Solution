using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;
using MvcMusicStore.Domain.Entities.Model;

namespace MvcMusicStore.Data.Context.Mapping
{
    public class CartMap : EntityTypeConfiguration<Cart>
    {
        public CartMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            //Property(t => t.CartId)
            //    .IsRequired();

            Property(t => t.AlbumId)
                .IsRequired();

            Property(t => t.Count)
                .IsRequired();

            Property(t => t.DateCreated)
                .IsRequired();

            Ignore(t => t.ValidationResult);
        }
    }
}
