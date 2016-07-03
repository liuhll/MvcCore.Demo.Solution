using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Repository.Common;
using MvcCoreDemo.Domain.Interfaces.Service;
using MvcCoreDemo.Domain.Services.Common;

namespace MvcCoreDemo.Domain.Services
{
    public class OrderDetailService : Service<OrderDetail>, IOrderDetailService
    {
        public OrderDetailService(IRepository<OrderDetail> repository) : base(repository)
        {
        }
    }
}
