using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMusicStore.Domain.Entities.Model;
using MvcMusicStore.Domain.Interfaces.Service.Common;

namespace MvcMusicStore.Domain.Interfaces.Service
{
    public interface IGenreService : IService<Genre>
    {
        Genre GetWithAlbums(string genre);
    }
}
