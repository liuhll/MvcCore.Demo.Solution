using System.Data.Entity.ModelConfiguration;
using MvcCoreDemo.Domain.Entities.Model;

namespace MvcCoreDemo.Data.Context.Mapping
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.Quantity)
                .IsRequired();

            // Relationship
            HasRequired(t => t.Order)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(t => t.OrderId);

            HasRequired(t => t.Album)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(t => t.AlbumId);

            Ignore(t => t.ValidationResult);
        }
    }
}
