using MvcCoreDemo.Data.Repository.EntityFramework.Common;
using MvcCoreDemo.Domain.Entities.Model;
using MvcCoreDemo.Domain.Interfaces.Repository;

namespace MvcCoreDemo.Data.Repository.EntityFramework
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
    }
}
