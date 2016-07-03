using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMusicStore.Domain.Entities.Model;
using MvcMusicStore.Domain.Interfaces.Repository.Common;
using MvcMusicStore.Domain.Interfaces.Service;
using MvcMusicStore.Domain.Services.Common;

namespace MvcMusicStore.Domain.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IRepository<Order> repository) : base(repository)
        {
        }
    }
}
