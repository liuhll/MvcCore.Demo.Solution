using FluentValidation.Results;
using MvcCoreDemo.Domain.Interfaces.Validation;

namespace MvcCoreDemo.Domain.Entities.Model
{
    public class OrderDetail : AggregateRoot, ISelfValidation
    {
        public int OrderId { get; set; }
        public int AlbumId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Album Album { get; set; }
        public virtual Order Order { get; set; }

        public ValidationResult ValidationResult { get; }
        public bool IsValid { get; }
    }
}
