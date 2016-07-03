using MvcCoreDemo.Application.Interfaces.Common;
using MvcCoreDemo.Domain.Entities.Model;

namespace MvcCoreDemo.Application.Interfaces
{
    public interface IGenreAppService : IAppService<Genre>
    {
        Genre GetWithAlbums(string genreName);
    }
}
