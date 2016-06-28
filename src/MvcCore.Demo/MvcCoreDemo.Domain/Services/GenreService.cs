using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Repository.Common;
using MvcCoreDemo.Domain.Interfaces.Service;
using MvcCoreDemo.Domain.Services.Common;

namespace MvcCoreDemo.Domain.Services
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
