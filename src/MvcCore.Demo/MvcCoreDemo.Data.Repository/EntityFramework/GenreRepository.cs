using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreDemo.Data.Repository.EntityFramework.Common;
using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces;

namespace MvcCoreDemo.Data.Repository.EntityFramework
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
    }
}
