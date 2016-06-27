using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Repository.Common;

namespace MvcCoreDemo.Domain.Interfaces.Repository
{
    public interface IArtistRepository : IRepository<Artist>
    {

    }
}
