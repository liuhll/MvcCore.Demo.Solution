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
    public class GenreService : Service<Genre>, IGenreService
    {
        public GenreService(IRepository<Genre> repository) : base(repository)
        {
        }

        public Genre GetWithAlbums(string genre)
        {
            throw new NotImplementedException();
        }
    }
}
