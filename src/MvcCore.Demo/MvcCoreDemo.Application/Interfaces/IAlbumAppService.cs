using System.Collections.Generic;
using MvcCoreDemo.Application.Interfaces.Common;
using MvcCoreDemo.Domain.Entities.Model;

namespace MvcCoreDemo.Application.Interfaces
{
    public interface IAlbumAppService : IAppService<Album>
    {
        IEnumerable<Album> GetTopSellingAlbums(int count);
        
    }
}
