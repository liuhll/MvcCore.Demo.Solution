using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Service.Common;

namespace MvcCoreDemo.Domain.Interfaces.Service
{
    public interface IGenreService : IService<Genre>
    {
        Genre GetWithAlbums(string genre);
    }
}
