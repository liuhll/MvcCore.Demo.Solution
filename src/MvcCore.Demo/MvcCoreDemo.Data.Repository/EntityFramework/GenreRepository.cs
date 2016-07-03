using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMusicStore.Data.Repository.EntityFramework.Common;
using MvcMusicStore.Domain.Entities.Model;
using MvcMusicStore.Domain.Interfaces;
using MvcMusicStore.Domain.Interfaces.Repository;

namespace MvcMusicStore.Data.Repository.EntityFramework
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
    }
}
