using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Repository.Common;
using MvcCoreDemo.Domain.Interfaces.Service;
using MvcCoreDemo.Domain.Services.Common;

namespace MvcCoreDemo.Domain.Services
{
    public class CartService : Service<Cart>, ICartService
    {
        public CartService(IRepository<Cart> repository) : base(repository)
        {
        }
    }
}
