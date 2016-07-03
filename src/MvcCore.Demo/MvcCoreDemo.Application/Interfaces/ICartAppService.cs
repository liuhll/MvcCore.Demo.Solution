using System.Collections.Generic;
using FluentValidation.Results;
using MvcCoreDemo.Application.Interfaces.Common;
using MvcCoreDemo.Domain.Entities.Model;

namespace MvcCoreDemo.Application.Interfaces
{
    public interface ICartAppService : IAppService<Cart>
    {
        ValidationResult Remove(IEnumerable<Cart> carts);
        ValidationResult Update(IEnumerable<Cart> carts);
    }
}
