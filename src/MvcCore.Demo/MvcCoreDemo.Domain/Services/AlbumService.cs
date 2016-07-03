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
    public class AlbumService : Service<Album>, IAlbumService
    {
        public AlbumService(IRepository<Album> repository) : base(repository)
        {
        }
    }
}
